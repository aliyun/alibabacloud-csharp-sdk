// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListStoragePartitionsInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListStoragePartitionsInfoResponseBodyData Data { get; set; }
        public class ListStoragePartitionsInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The statistical date. The format is YYYYMMDD.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20241205</para>
            /// </summary>
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The list of partition storage information.</para>
            /// </summary>
            [NameInMap("storagePartitionInfoList")]
            [Validation(Required=false)]
            public List<ListStoragePartitionsInfoResponseBodyDataStoragePartitionInfoList> StoragePartitionInfoList { get; set; }
            public class ListStoragePartitionsInfoResponseBodyDataStoragePartitionInfoList : TeaModel {
                /// <summary>
                /// <para>The number of files.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("fileCount")]
                [Validation(Required=false)]
                public long? FileCount { get; set; }

                /// <summary>
                /// <para>The storage size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public double? FileSize { get; set; }

                /// <summary>
                /// <para>The unit of the storage size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GB</para>
                /// </summary>
                [NameInMap("fileSizeUnit")]
                [Validation(Required=false)]
                public string FileSizeUnit { get; set; }

                /// <summary>
                /// <para>Indicates whether the table is partitioned. This API operation returns only partition information. You can ignore this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isPartitioned")]
                [Validation(Required=false)]
                public bool? IsPartitioned { get; set; }

                /// <summary>
                /// <para>The last access time of the data in the partition.</para>
                /// <remarks>
                /// <para>The collection of this data has been gradually upgraded since July 2023. The last_access_time cannot be collected if the partition has not been accessed after the upgrade or if it is accessed through ALGO jobs or Hologres direct read.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1694589365</para>
                /// </summary>
                [NameInMap("lastAccessTime")]
                [Validation(Required=false)]
                public long? LastAccessTime { get; set; }

                /// <summary>
                /// <para>The partition name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds=20241201</para>
                /// </summary>
                [NameInMap("partition")]
                [Validation(Required=false)]
                public string Partition { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_project</para>
                /// </summary>
                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The year-over-year comparison of the total storage capacity over the recent {$recentDays} days. This API operation does not return this value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1%</para>
                /// </summary>
                [NameInMap("rate")]
                [Validation(Required=false)]
                public double? Rate { get; set; }

                /// <summary>
                /// <para>The schema name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>schema</para>
                /// </summary>
                [NameInMap("schemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The storage type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>standard: Standard storage.</description></item>
                /// <item><description>lowfrequency: Low-frequency storage.</description></item>
                /// <item><description>longterm: Long-term storage.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("storageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>The table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bank_data</para>
                /// </summary>
                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The access frequency.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Access behaviors include:<remarks>
                /// <list type="bullet">
                /// <item><description>The table is used as an input table in SQL computing tasks.</description></item>
                /// <item><description>The table is downloaded by using Tunnel.</description></item>
                /// <item><description>The table is read by calling the Read operation of StorageAPI (partition-level data for partitioned tables is currently unavailable). The access frequency increases by 1 for each additional access.</description></item>
                /// </list>
                /// </remarks>
                /// </description></item>
                /// <item><description>The statistics for this data have been gradually upgraded since July 2023. Accesses that did not occur after the upgrade or accesses made through ALGO jobs or Hologres direct read cannot be counted in the access frequency.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("totalFrequency")]
                [Validation(Required=false)]
                public long? TotalFrequency { get; set; }

                /// <summary>
                /// <para>The total amount of accessed data.</para>
                /// <remarks>
                /// <para>The amount of data read by all access behaviors.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("totalInputAmount")]
                [Validation(Required=false)]
                public double? TotalInputAmount { get; set; }

                /// <summary>
                /// <para>The unit of the total amount of accessed data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GB</para>
                /// </summary>
                [NameInMap("totalInputAmountUnit")]
                [Validation(Required=false)]
                public string TotalInputAmountUnit { get; set; }

                /// <summary>
                /// <para>The type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PARTITION</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of returned results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>57</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OBJECT_NOT_EXIST</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This object does not exist.</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1xx: Informational response. The request was received and is being processed.</description></item>
        /// <item><description>2xx: Success. The request was successfully received, understood, and accepted by the server.</description></item>
        /// <item><description>3xx: Redirection. The request was redirected, and further action is required to complete it.</description></item>
        /// <item><description>4xx: Client error. The request contains bad syntax, invalid parameters, or cannot be fulfilled.</description></item>
        /// <item><description>5xx: Server error. The server failed to fulfill the request due to other reasons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0be3e0bd16661643917136451ebf55</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
