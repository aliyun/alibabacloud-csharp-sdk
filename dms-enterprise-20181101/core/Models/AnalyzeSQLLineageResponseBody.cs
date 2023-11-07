// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AnalyzeSQLLineageResponseBody : TeaModel {
        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returned data set of SQL lineage.
        /// </summary>
        [NameInMap("LineageResult")]
        [Validation(Required=false)]
        public AnalyzeSQLLineageResponseBodyLineageResult LineageResult { get; set; }
        public class AnalyzeSQLLineageResponseBodyLineageResult : TeaModel {
            /// <summary>
            /// The details about the lineage.
            /// </summary>
            [NameInMap("Lineages")]
            [Validation(Required=false)]
            public List<AnalyzeSQLLineageResponseBodyLineageResultLineages> Lineages { get; set; }
            public class AnalyzeSQLLineageResponseBodyLineageResultLineages : TeaModel {
                /// <summary>
                /// The target.
                /// </summary>
                [NameInMap("Dst")]
                [Validation(Required=false)]
                public string Dst { get; set; }

                /// <summary>
                /// The type of the lineage. Valid values:
                /// 
                /// *   **FIELD_DEPEND_FIELD**: Fields depend on fields.
                /// *   **TABLE_DEPEND_TABLE**: Tables depend on tables.
                /// *   **FIELD_INFLU_TABLE**: Fields influence tables.
                /// *   **FIELD_INFLU_FIELD**: Fields influence fields.
                /// *   **FIELD_INFLU_TABLE**: Tables influence fields.
                /// *   **FIELD_JOIN_FIELD**: Fields are associated with fields.
                /// </summary>
                [NameInMap("LineageType")]
                [Validation(Required=false)]
                public string LineageType { get; set; }

                /// <summary>
                /// The operation type of the SQL statement in which the data lineage is generated. For example, if the operation type is SELECT, the data lineage is generated from a SELECT statement.
                /// 
                /// >  This field is an extended field which has no practical use.
                /// </summary>
                [NameInMap("OperType")]
                [Validation(Required=false)]
                public string OperType { get; set; }

                /// <summary>
                /// The handling details. This parameter is returned only when LineageType is FIELD_DEPEND_FIELD.
                /// </summary>
                [NameInMap("ProcessDetail")]
                [Validation(Required=false)]
                public AnalyzeSQLLineageResponseBodyLineageResultLineagesProcessDetail ProcessDetail { get; set; }
                public class AnalyzeSQLLineageResponseBodyLineageResultLineagesProcessDetail : TeaModel {
                    /// <summary>
                    /// The calculating method. Valid values:
                    /// 
                    /// *   **DIRECT**: No function or expression is used.
                    /// *   **EXPR**: A function or expression is used.
                    /// </summary>
                    [NameInMap("CalWay")]
                    [Validation(Required=false)]
                    public string CalWay { get; set; }

                    /// <summary>
                    /// The SQL code snippet for field processing.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                }

                /// <summary>
                /// The source.
                /// </summary>
                [NameInMap("Src")]
                [Validation(Required=false)]
                public string Src { get; set; }

            }

            /// <summary>
            /// The table and field metadata information.
            /// </summary>
            [NameInMap("ObjectMetadata")]
            [Validation(Required=false)]
            public List<AnalyzeSQLLineageResponseBodyLineageResultObjectMetadata> ObjectMetadata { get; set; }
            public class AnalyzeSQLLineageResponseBodyLineageResultObjectMetadata : TeaModel {
                /// <summary>
                /// The fields in the metatable.
                /// </summary>
                [NameInMap("Fields")]
                [Validation(Required=false)]
                public List<AnalyzeSQLLineageResponseBodyLineageResultObjectMetadataFields> Fields { get; set; }
                public class AnalyzeSQLLineageResponseBodyLineageResultObjectMetadataFields : TeaModel {
                    /// <summary>
                    /// The name of the field.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The object name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The source of metadata. Valid values:
                /// 
                /// *   **DDL**: The metadata comes from parsed SQL statements or definition of databases and tables collected by DMS.
                /// *   **LINEAGE**: The metadata comes from lineage analysis results.
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// The object type. Valid values:
                /// 
                /// *   **TABLE**
                /// *   **VIEW**
                /// *   **TMP_TABLE**
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
