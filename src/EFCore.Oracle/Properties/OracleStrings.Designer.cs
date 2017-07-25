// <auto-generated />

using System;
using System.Reflection;
using System.Resources;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Microsoft.EntityFrameworkCore.Internal
{
    /// <summary>
    ///		This API supports the Entity Framework Core infrastructure and is not intended to be used
    ///     directly from your code. This API may change or be removed in future releases.
    /// </summary>
    public static class OracleStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.Properties.OracleStrings", typeof(OracleStrings).GetTypeInfo().Assembly);

        /// <summary>
        ///     Identity value generation cannot be used for the property '{property}' on entity type '{entityType}' because the property type is '{propertyType}'. Identity value generation can only be used with signed integer properties.
        /// </summary>
        public static string IdentityBadType([CanBeNull] object property, [CanBeNull] object entityType, [CanBeNull] object propertyType)
            => string.Format(
                GetString("IdentityBadType", nameof(property), nameof(entityType), nameof(propertyType)),
                property, entityType, propertyType);

        /// <summary>
        ///     Data type '{dataType}' is not supported in this form. Either specify the length explicitly in the type name, for example as '{dataType}(16)', or remove the data type and use APIs such as HasMaxLength to allow EF choose the data type.
        /// </summary>
        public static string UnqualifiedDataType([CanBeNull] object dataType)
            => string.Format(
                GetString("UnqualifiedDataType", nameof(dataType)),
                dataType);

        /// <summary>
        ///     Oracle sequences cannot be used to generate values for the property '{property}' on entity type '{entityType}' because the property type is '{propertyType}'. Sequences can only be used with integer properties.
        /// </summary>
        public static string SequenceBadType([CanBeNull] object property, [CanBeNull] object entityType, [CanBeNull] object propertyType)
            => string.Format(
                GetString("SequenceBadType", nameof(property), nameof(entityType), nameof(propertyType)),
                property, entityType, propertyType);

        /// <summary>
        ///     Oracle requires the table name to be specified for rename index operations. Specify table name in the call to MigrationBuilder.RenameIndex.
        /// </summary>
        public static string IndexTableRequired
            => GetString("IndexTableRequired");

        /// <summary>
        ///     To set memory-optimized on a table on or off the table needs to be dropped and recreated.
        /// </summary>
        public static string AlterMemoryOptimizedTable
            => GetString("AlterMemoryOptimizedTable");

        /// <summary>
        ///     To change the IDENTITY property of a column, the column needs to be dropped and recreated.
        /// </summary>
        public static string AlterIdentityColumn
            => GetString("AlterIdentityColumn");

        /// <summary>
        ///     No type was specified for the decimal column '{property}' on entity type '{entityType}'. This will cause values to be silently truncated if they do not fit in the default precision and scale. Explicitly specify the Oracle column type that can accomadate all the values using 'ForOracleHasColumnType()'.
        /// </summary>
        public static readonly EventDefinition<string, string> LogDefaultDecimalTypeColumn
            = new EventDefinition<string, string>(
                OracleEventId.DecimalTypeDefaultWarning,
                LogLevel.Warning,
                LoggerMessage.Define<string, string>(
                    LogLevel.Warning,
                    OracleEventId.DecimalTypeDefaultWarning,
                    _resourceManager.GetString("LogDefaultDecimalTypeColumn")));

        /// <summary>
        ///     The property '{property}' on entity type '{entityType}' is of type 'byte', but is set up to use a Oracle identity column. This requires that values starting at 255 and counting down will be used for temporary key values. A temporary key value is needed for every entity inserted in a single call to 'SaveChanges'. Care must be taken that these values do not collide with real key values.
        /// </summary>
        public static readonly EventDefinition<string, string> LogByteIdentityColumn
            = new EventDefinition<string, string>(
                OracleEventId.ByteIdentityColumnWarning,
                LogLevel.Warning,
                LoggerMessage.Define<string, string>(
                    LogLevel.Warning,
                    OracleEventId.ByteIdentityColumnWarning,
                    _resourceManager.GetString("LogByteIdentityColumn")));

        /// <summary>
        ///     The property '{property}' on entity type '{entityType}' is configured to use 'SequenceHiLo' value generator, which is only intended for keys. If this was intentional configure an alternate key on the property, otherwise call 'ValueGeneratedNever' or configure store generation for this property.
        /// </summary>
        public static string NonKeyValueGeneration([CanBeNull] object property, [CanBeNull] object entityType)
            => string.Format(
                GetString("NonKeyValueGeneration", nameof(property), nameof(entityType)),
                property, entityType);

        /// <summary>
        ///     The properties {properties} are configured to use 'Identity' value generator and are mapped to the same table '{table}'. Only one column per table can be configured as 'Identity'. Call 'ValueGeneratedNever' for properties that should not use 'Identity'.
        /// </summary>
        public static string MultipleIdentityColumns([CanBeNull] object properties, [CanBeNull] object table)
            => string.Format(
                GetString("MultipleIdentityColumns", nameof(properties), nameof(table)),
                properties, table);

        /// <summary>
        ///     Cannot use table '{table}' for entity type '{entityType}' since it is being used for entity type '{otherEntityType}' and entity type '{memoryOptimizedEntityType}' is marked as memory-optimized, but entity type '{nonMemoryOptimizedEntityType}' is not.
        /// </summary>
        public static string IncompatibleTableMemoryOptimizedMismatch([CanBeNull] object table, [CanBeNull] object entityType, [CanBeNull] object otherEntityType, [CanBeNull] object memoryOptimizedEntityType, [CanBeNull] object nonMemoryOptimizedEntityType)
            => string.Format(
                GetString("IncompatibleTableMemoryOptimizedMismatch", nameof(table), nameof(entityType), nameof(otherEntityType), nameof(memoryOptimizedEntityType), nameof(nonMemoryOptimizedEntityType)),
                table, entityType, otherEntityType, memoryOptimizedEntityType, nonMemoryOptimizedEntityType);

        /// <summary>
        ///     Found default schema {defaultSchema}.
        /// </summary>
        public static readonly EventDefinition<string> LogFoundDefaultSchema
            = new EventDefinition<string>(
                OracleEventId.DefaultSchemaFound,
                LogLevel.Debug,
                LoggerMessage.Define<string>(
                    LogLevel.Debug,
                    OracleEventId.DefaultSchemaFound,
                    _resourceManager.GetString("LogFoundDefaultSchema")));

        /// <summary>
        ///     Found type alias with name: {alias} which maps to underlying data type {dataType}.
        /// </summary>
        public static readonly EventDefinition<string, string> LogFoundTypeAlias
            = new EventDefinition<string, string>(
                OracleEventId.TypeAliasFound,
                LogLevel.Debug,
                LoggerMessage.Define<string, string>(
                    LogLevel.Debug,
                    OracleEventId.TypeAliasFound,
                    _resourceManager.GetString("LogFoundTypeAlias")));

        /// <summary>
        ///     Found column with table: {tableName}, column name: {columnName}, data type: {dataType}, ordinal: {ordinal}, nullable: {isNullable}, primary key ordinal: {primaryKeyOrdinal}, default value: {defaultValue}, computed value: {computedValue}, precision: {precision}, scale: {scale}, maximum length: {maxLength}, identity: {isIdentity}, computed: {isComputed}.
        /// </summary>
        public static readonly FallbackEventDefinition LogFoundColumn
            = new FallbackEventDefinition(
                OracleEventId.ColumnFound,
                LogLevel.Debug,
                _resourceManager.GetString("LogFoundColumn"));

        /// <summary>
        ///     Found foreign key column with table: {tableName}, foreign key name: {fkName}, principal table: {principalTableName}, column name: {columnName}, principal column name: {principalColumnName}, update action: {updateAction}, delete action: {deleteAction}, ordinal: {ordinal}.
        /// </summary>
        public static readonly FallbackEventDefinition LogFoundForeignKeyColumn
            = new FallbackEventDefinition(
                OracleEventId.ForeignKeyColumnFound,
                LogLevel.Debug,
                _resourceManager.GetString("LogFoundForeignKeyColumn"));

        /// <summary>
        ///     Found a column on index {indexName} on table {tableName} with an empty or null name. Not including column in index.
        /// </summary>
        public static readonly EventDefinition<string, string> LogColumnNameEmptyOnIndex
            = new EventDefinition<string, string>(
                OracleEventId.IndexColumnNotNamedWarning,
                LogLevel.Warning,
                LoggerMessage.Define<string, string>(
                    LogLevel.Warning,
                    OracleEventId.IndexColumnNotNamedWarning,
                    _resourceManager.GetString("LogColumnNameEmptyOnIndex")));

        /// <summary>
        ///     Column {columnName} belongs to table {tableName} which is not included in the selection set. Skipping.
        /// </summary>
        public static readonly EventDefinition<string, string> LogColumnNotInSelectionSet
            = new EventDefinition<string, string>(
                OracleEventId.ColumnSkipped,
                LogLevel.Debug,
                LoggerMessage.Define<string, string>(
                    LogLevel.Debug,
                    OracleEventId.ColumnSkipped,
                    _resourceManager.GetString("LogColumnNotInSelectionSet")));

        /// <summary>
        ///     Foreign key column {columnName} belongs to foreign key {fkName} on table {tableName} which is not included in the selection set. Skipping.
        /// </summary>
        public static readonly EventDefinition<string, string, string> LogForeignKeyColumnNotInSelectionSet
            = new EventDefinition<string, string, string>(
                OracleEventId.ForeignKeyColumnMissingWarning,
                LogLevel.Warning,
                LoggerMessage.Define<string, string, string>(
                    LogLevel.Warning,
                    OracleEventId.ForeignKeyColumnMissingWarning,
                    _resourceManager.GetString("LogForeignKeyColumnNotInSelectionSet")));

        /// <summary>
        ///     Found a foreign key on table {tableName} with an empty or null name. Skipping foreign key.
        /// </summary>
        public static readonly EventDefinition<string> LogForeignKeyNameEmpty
            = new EventDefinition<string>(
                OracleEventId.ForeignKeyNotNamedWarning,
                LogLevel.Warning,
                LoggerMessage.Define<string>(
                    LogLevel.Warning,
                    OracleEventId.ForeignKeyNotNamedWarning,
                    _resourceManager.GetString("LogForeignKeyNameEmpty")));

        /// <summary>
        ///     Could not scaffold the foreign key '{foreignKeyName}'.  The following columns in the foreign key could not be scaffolded: {columnNames}.
        /// </summary>
        public static readonly EventDefinition<string, string> LogForeignKeyScaffoldErrorPropertyNotFound
            = new EventDefinition<string, string>(
                OracleEventId.ForeignKeyColumnsNotMappedWarning,
                LogLevel.Warning,
                LoggerMessage.Define<string, string>(
                    LogLevel.Warning,
                    OracleEventId.ForeignKeyColumnsNotMappedWarning,
                    _resourceManager.GetString("LogForeignKeyScaffoldErrorPropertyNotFound")));

        /// <summary>
        ///     For foreign key {fkName} on table {tableName}, unable to model the end of the foreign key on principal table {principaltableName}. This is usually because the principal table was not included in the selection set.
        /// </summary>
        public static readonly EventDefinition<string, string, string> LogPrincipalTableNotInSelectionSet
            = new EventDefinition<string, string, string>(
                OracleEventId.ForeignKeyReferencesMissingPrincipalTableWarning,
                LogLevel.Warning,
                LoggerMessage.Define<string, string, string>(
                    LogLevel.Warning,
                    OracleEventId.ForeignKeyReferencesMissingPrincipalTableWarning,
                    _resourceManager.GetString("LogPrincipalTableNotInSelectionSet")));

        /// <summary>
        ///     Found index column on index {indexName} on table {tableName}, column name: {columnName}, ordinal: {ordinal}.
        /// </summary>
        public static readonly EventDefinition<string, string, string, int?> LogFoundIndexColumn
            = new EventDefinition<string, string, string, int?>(
                OracleEventId.IndexColumnFound,
                LogLevel.Debug,
                LoggerMessage.Define<string, string, string, int?>(
                    LogLevel.Debug,
                    OracleEventId.IndexColumnFound,
                    _resourceManager.GetString("LogFoundIndexColumn")));

        /// <summary>
        ///     Index column {columnName} belongs to index {indexName} on table {tableName} which is not included in the selection set. Skipping.
        /// </summary>
        public static readonly EventDefinition<string, string, string> LogIndexColumnNotInSelectionSet
            = new EventDefinition<string, string, string>(
                OracleEventId.IndexColumnSkipped,
                LogLevel.Warning,
                LoggerMessage.Define<string, string, string>(
                    LogLevel.Warning,
                    OracleEventId.IndexColumnSkipped,
                    _resourceManager.GetString("LogIndexColumnNotInSelectionSet")));

        /// <summary>
        ///     Unable to scaffold the index '{indexName}'. The following columns could not be scaffolded: {columnNames}.
        /// </summary>
        public static readonly EventDefinition<string, string> LogUnableToScaffoldIndexMissingProperty
            = new EventDefinition<string, string>(
                OracleEventId.IndexColumnsNotMappedWarning,
                LogLevel.Warning,
                LoggerMessage.Define<string, string>(
                    LogLevel.Warning,
                    OracleEventId.IndexColumnsNotMappedWarning,
                    _resourceManager.GetString("LogUnableToScaffoldIndexMissingProperty")));

        /// <summary>
        ///     Found an index on table {tableName} with an empty or null name. Skipping index.
        /// </summary>
        public static readonly EventDefinition<string> LogIndexNameEmpty
            = new EventDefinition<string>(
                OracleEventId.IndexNotNamedWarning,
                LogLevel.Warning,
                LoggerMessage.Define<string>(
                    LogLevel.Warning,
                    OracleEventId.IndexNotNamedWarning,
                    _resourceManager.GetString("LogIndexNameEmpty")));

        /// <summary>
        ///     For index {indexName}. Unable to find parent table {tableName}. Skipping index.
        /// </summary>
        public static readonly EventDefinition<string, string> LogUnableToFindTableForIndex
            = new EventDefinition<string, string>(
                OracleEventId.IndexTableMissingWarning,
                LogLevel.Warning,
                LoggerMessage.Define<string, string>(
                    LogLevel.Warning,
                    OracleEventId.IndexTableMissingWarning,
                    _resourceManager.GetString("LogUnableToFindTableForIndex")));

        /// <summary>
        ///     Unable to find a schema in the database matching the selected schema {schema}.
        /// </summary>
        public static readonly EventDefinition<string> LogMissingSchema
            = new EventDefinition<string>(
                OracleEventId.MissingSchemaWarning,
                LogLevel.Warning,
                LoggerMessage.Define<string>(
                    LogLevel.Warning,
                    OracleEventId.MissingSchemaWarning,
                    _resourceManager.GetString("LogMissingSchema")));

        /// <summary>
        ///     Unable to find a table in the database matching the selected table {table}.
        /// </summary>
        public static readonly EventDefinition<string> LogMissingTable
            = new EventDefinition<string>(
                OracleEventId.MissingTableWarning,
                LogLevel.Warning,
                LoggerMessage.Define<string>(
                    LogLevel.Warning,
                    OracleEventId.MissingTableWarning,
                    _resourceManager.GetString("LogMissingTable")));

        /// <summary>
        ///     Found sequence name: {name}, data type: {dataType}, cyclic: {isCyclic}, increment: {increment}, start: {start}, minimum: {min}, maximum: {max}.
        /// </summary>
        public static readonly FallbackEventDefinition LogFoundSequence
            = new FallbackEventDefinition(
                OracleEventId.SequenceFound,
                LogLevel.Debug,
                _resourceManager.GetString("LogFoundSequence"));

        /// <summary>
        ///     Sequence name cannot be null or empty. Entity Framework cannot model a sequence that does not have a name.
        /// </summary>
        public static readonly EventDefinition LogSequencesRequireName
            = new EventDefinition(
                OracleEventId.SequenceNotNamedWarning,
                LogLevel.Warning,
                LoggerMessage.Define(
                    LogLevel.Warning,
                    OracleEventId.SequenceNotNamedWarning,
                    _resourceManager.GetString("LogSequencesRequireName")));

        /// <summary>
        ///     Found table with name: {name}.
        /// </summary>
        public static readonly EventDefinition<string> LogFoundTable
            = new EventDefinition<string>(
                OracleEventId.TableFound,
                LogLevel.Debug,
                LoggerMessage.Define<string>(
                    LogLevel.Debug,
                    OracleEventId.TableFound,
                    _resourceManager.GetString("LogFoundTable")));

        /// <summary>
        ///     Table {tableName} is not included in the selection set. Skipping.
        /// </summary>
        public static readonly EventDefinition<string> LogTableNotInSelectionSet
            = new EventDefinition<string>(
                OracleEventId.TableSkipped,
                LogLevel.Debug,
                LoggerMessage.Define<string>(
                    LogLevel.Debug,
                    OracleEventId.TableSkipped,
                    _resourceManager.GetString("LogTableNotInSelectionSet")));

        /// <summary>
        ///     Found a column on table {tableName} with an empty or null name. Skipping column.
        /// </summary>
        public static readonly EventDefinition<string> LogColumnNameEmptyOnTable
            = new EventDefinition<string>(
                OracleEventId.ColumnNotNamedWarning,
                LogLevel.Warning,
                LoggerMessage.Define<string>(
                    LogLevel.Warning,
                    OracleEventId.ColumnNotNamedWarning,
                    _resourceManager.GetString("LogColumnNameEmptyOnTable")));

        /// <summary>
        ///     Found a column on foreign key {tableName}.{fkName} with an empty or null name. Not including column in foreign key
        /// </summary>
        public static readonly EventDefinition<string, string> LogColumnNameEmptyOnForeignKey
            = new EventDefinition<string, string>(
                OracleEventId.ForeignKeyColumnNotNamedWarning,
                LogLevel.Warning,
                LoggerMessage.Define<string, string>(
                    LogLevel.Warning,
                    OracleEventId.ForeignKeyColumnNotNamedWarning,
                    _resourceManager.GetString("LogColumnNameEmptyOnForeignKey")));

        /// <summary>
        ///     The database name could not be determined. To use EnsureDeleted, the connection string must specify Initial Catalog.
        /// </summary>
        public static string NoInitialCatalog
            => GetString("NoInitialCatalog");

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);
            for (var i = 0; i < formatterNames.Length; i++)
            {
                value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
            }

            return value;
        }
    }
}
