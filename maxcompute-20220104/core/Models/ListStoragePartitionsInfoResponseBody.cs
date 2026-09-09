// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListStoragePartitionsInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListStoragePartitionsInfoResponseBodyData Data { get; set; }
        public class ListStoragePartitionsInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The date to which the statistics apply.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20241205</para>
            /// </summary>
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <para>The page number of the returned data.</para>
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
            /// <para>The storage information for the partitions.</para>
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
                /// <para>Indicates whether the table is a partitioned table. You can ignore this parameter because this operation returns data only for partitions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isPartitioned")]
                [Validation(Required=false)]
                public bool? IsPartitioned { get; set; }

                /// <summary>
                /// <para>The last access time of the partition.</para>
                /// <remarks>
                /// <para>Data collection for this metric began a gradual rollout in July 2023. Consequently, the lastAccessTime may not be recorded for a partition that has not been accessed since then or is accessed only by ALGO jobs or direct reads from Hologres.</para>
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
                /// <para>The period-over-period change in the total storage usage over the last {$recentDays} days. This API operation does not return this parameter.</para>
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
                /// <item><description><para><c>standard</c>: Standard storage</para>
                /// </description></item>
                /// <item><description><para><c>lowfrequency</c>: Infrequent-access storage</para>
                /// </description></item>
                /// <item><description><para><c>longterm</c>: Archive storage</para>
                /// </description></item>
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
                /// <item><description>Access activities include:</description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>The table is used as input in a SQL compute task.</para>
                /// </description></item>
                /// <item><description><para>The table is downloaded via Tunnel.</para>
                /// </description></item>
                /// <item><description><para>The table data is read by calling the <c>Read</c> operation of the StorageAPI. Partition-level data for partitioned tables is not available. Each access activity increases the access frequency by 1.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description>Data collection for this metric began a gradual rollout in July 2023. Consequently, the access frequency may not be recorded for tables that have not been accessed since then or are accessed only by ALGO jobs or direct reads from Hologres.</description></item>
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
                /// <para>The total data accessed.</para>
                /// <remarks>
                /// <para>The cumulative amount of data read from all access operations.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("totalInputAmount")]
                [Validation(Required=false)]
                public double? TotalInputAmount { get; set; }

                /// <summary>
                /// <para>The unit of the total data accessed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GB</para>
                /// </summary>
                [NameInMap("totalInputAmountUnit")]
                [Validation(Required=false)]
                public string TotalInputAmountUnit { get; set; }

                /// <summary>
                /// <para>The type of the object. The value is always PARTITION.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PARTITION</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
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
        /// <para>The HTTP status code.</para>
        /// <list type="bullet">
        /// <item><description><para>1xx: Informational response - The request has been received and is being processed.</para>
        /// </description></item>
        /// <item><description><para>2xx: Success - The request was successfully received, understood, and accepted.</para>
        /// </description></item>
        /// <item><description><para>3xx: Redirection - Further action must be taken to complete the request.</para>
        /// </description></item>
        /// <item><description><para>4xx: Client error - The request contains invalid parameters or syntax, or cannot be fulfilled.</para>
        /// </description></item>
        /// <item><description><para>5xx: Server error - The server failed to fulfill a valid request.</para>
        /// </description></item>
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
