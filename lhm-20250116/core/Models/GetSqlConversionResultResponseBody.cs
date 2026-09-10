// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetSqlConversionResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The data list returned by the operation. For the structure of each element, see the child parameters.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetSqlConversionResultResponseBodyData> Data { get; set; }
        public class GetSqlConversionResultResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connection timeout</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The completion time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16T10:00:00Z</para>
            /// </summary>
            [NameInMap("finishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The script ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890</para>
            /// </summary>
            [NameInMap("scriptId")]
            [Validation(Required=false)]
            public long? ScriptId { get; set; }

            /// <summary>
            /// <para>The script name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node_script_demo</para>
            /// </summary>
            [NameInMap("scriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>The script conversion status. In conversion job scenarios: pass for conversion succeeded, turning for converting, and fail for conversion failed. In some scenarios: success for succeeded, failed for failed, and skipped for skipped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("scriptTransformStatus")]
            [Validation(Required=false)]
            public string ScriptTransformStatus { get; set; }

            /// <summary>
            /// <para>The converted script content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM t;</para>
            /// </summary>
            [NameInMap("sqlResultContent")]
            [Validation(Required=false)]
            public string SqlResultContent { get; set; }

            /// <summary>
            /// <para>The original script content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SELECT * FROM t;</para>
            /// </summary>
            [NameInMap("sqlSourceContent")]
            [Validation(Required=false)]
            public string SqlSourceContent { get; set; }

            /// <summary>
            /// <para>The table name mapping.</para>
            /// </summary>
            [NameInMap("tableMappingList")]
            [Validation(Required=false)]
            public List<GetSqlConversionResultResponseBodyDataTableMappingList> TableMappingList { get; set; }
            public class GetSqlConversionResultResponseBodyDataTableMappingList : TeaModel {
                /// <summary>
                /// <para>The primary key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The source type. Valid values: DB and Schema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>db_demo</para>
                /// </summary>
                [NameInMap("sourceSchema")]
                [Validation(Required=false)]
                public string SourceSchema { get; set; }

                /// <summary>
                /// <para>The source table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table_demo</para>
                /// </summary>
                [NameInMap("sourceTableName")]
                [Validation(Required=false)]
                public string SourceTableName { get; set; }

                /// <summary>
                /// <para>The target table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table_demo</para>
                /// </summary>
                [NameInMap("targetTableName")]
                [Validation(Required=false)]
                public string TargetTableName { get; set; }

                /// <summary>
                /// <para>The target type. Valid values: DB and Schema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hive</para>
                /// </summary>
                [NameInMap("targetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

                /// <summary>
                /// <para>The SQL conversion task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("tenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10001</para>
                /// </summary>
                [NameInMap("uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. An empty string is returned if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The page size, which is the number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues with this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. A value of true indicates success. A value of false indicates failure. If the call fails, check errCode and errMessage for troubleshooting.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records that meet the query conditions. This value is used for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
