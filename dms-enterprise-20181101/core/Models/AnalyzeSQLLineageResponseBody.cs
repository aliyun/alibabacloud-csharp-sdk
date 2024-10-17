// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AnalyzeSQLLineageResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>Returned data set of SQL lineage.</para>
        /// </summary>
        [NameInMap("LineageResult")]
        [Validation(Required=false)]
        public AnalyzeSQLLineageResponseBodyLineageResult LineageResult { get; set; }
        public class AnalyzeSQLLineageResponseBodyLineageResult : TeaModel {
            /// <summary>
            /// <para>The details about the lineage.</para>
            /// </summary>
            [NameInMap("Lineages")]
            [Validation(Required=false)]
            public List<AnalyzeSQLLineageResponseBodyLineageResultLineages> Lineages { get; set; }
            public class AnalyzeSQLLineageResponseBodyLineageResultLineages : TeaModel {
                /// <summary>
                /// <para>The target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dmstest.a.id</para>
                /// </summary>
                [NameInMap("Dst")]
                [Validation(Required=false)]
                public string Dst { get; set; }

                /// <summary>
                /// <para>The type of the lineage. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FIELD_DEPEND_FIELD</b>: Fields depend on fields.</description></item>
                /// <item><description><b>TABLE_DEPEND_TABLE</b>: Tables depend on tables.</description></item>
                /// <item><description><b>FIELD_INFLU_TABLE</b>: Fields influence tables.</description></item>
                /// <item><description><b>FIELD_INFLU_FIELD</b>: Fields influence fields.</description></item>
                /// <item><description><b>FIELD_INFLU_TABLE</b>: Tables influence fields.</description></item>
                /// <item><description><b>FIELD_JOIN_FIELD</b>: Fields are associated with fields.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FIELD_DEPEND_FIELD</para>
                /// </summary>
                [NameInMap("LineageType")]
                [Validation(Required=false)]
                public string LineageType { get; set; }

                /// <summary>
                /// <para>The operation type of the SQL statement in which the data lineage is generated. For example, if the operation type is SELECT, the data lineage is generated from a SELECT statement.</para>
                /// <remarks>
                /// <para> This field is an extended field which has no practical use.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT</para>
                /// </summary>
                [NameInMap("OperType")]
                [Validation(Required=false)]
                public string OperType { get; set; }

                /// <summary>
                /// <para>The handling details. This parameter is returned only when LineageType is FIELD_DEPEND_FIELD.</para>
                /// </summary>
                [NameInMap("ProcessDetail")]
                [Validation(Required=false)]
                public AnalyzeSQLLineageResponseBodyLineageResultLineagesProcessDetail ProcessDetail { get; set; }
                public class AnalyzeSQLLineageResponseBodyLineageResultLineagesProcessDetail : TeaModel {
                    /// <summary>
                    /// <para>The calculating method. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>DIRECT</b>: No function or expression is used.</description></item>
                    /// <item><description><b>EXPR</b>: A function or expression is used.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DIRECT</para>
                    /// </summary>
                    [NameInMap("CalWay")]
                    [Validation(Required=false)]
                    public string CalWay { get; set; }

                    /// <summary>
                    /// <para>The SQL code snippet for field processing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dmstest.b.id</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                }

                /// <summary>
                /// <para>The source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dmstest.b.id</para>
                /// </summary>
                [NameInMap("Src")]
                [Validation(Required=false)]
                public string Src { get; set; }

            }

            /// <summary>
            /// <para>The table and field metadata information.</para>
            /// </summary>
            [NameInMap("ObjectMetadata")]
            [Validation(Required=false)]
            public List<AnalyzeSQLLineageResponseBodyLineageResultObjectMetadata> ObjectMetadata { get; set; }
            public class AnalyzeSQLLineageResponseBodyLineageResultObjectMetadata : TeaModel {
                /// <summary>
                /// <para>The fields in the metatable.</para>
                /// </summary>
                [NameInMap("Fields")]
                [Validation(Required=false)]
                public List<AnalyzeSQLLineageResponseBodyLineageResultObjectMetadataFields> Fields { get; set; }
                public class AnalyzeSQLLineageResponseBodyLineageResultObjectMetadataFields : TeaModel {
                    /// <summary>
                    /// <para>The name of the field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dmstest.a.id</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The object name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The source of metadata. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>DDL</b>: The metadata comes from parsed SQL statements or definition of databases and tables collected by DMS.</description></item>
                /// <item><description><b>LINEAGE</b>: The metadata comes from lineage analysis results.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DDL</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The object type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>TABLE</b></description></item>
                /// <item><description><b>VIEW</b></description></item>
                /// <item><description><b>TMP_TABLE</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TABLE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4B07137-F6AE-4756-8474-7F92BB6C4E04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
