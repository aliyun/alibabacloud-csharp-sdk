// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListStorageTablesInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListStorageTablesInfoResponseBodyData Data { get; set; }
        public class ListStorageTablesInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The date on which the statistics are collected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20241205</para>
            /// </summary>
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <para>The page number.</para>
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
            /// <para>The table storage information.</para>
            /// </summary>
            [NameInMap("storageTableInfoList")]
            [Validation(Required=false)]
            public List<ListStorageTablesInfoResponseBodyDataStorageTableInfoList> StorageTableInfoList { get; set; }
            public class ListStorageTablesInfoResponseBodyDataStorageTableInfoList : TeaModel {
                /// <summary>
                /// <para>The date on which the statistics are collected. This value is not returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20241205</para>
                /// </summary>
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>Indicates whether the table is a partitioned table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isPartitioned")]
                [Validation(Required=false)]
                public bool? IsPartitioned { get; set; }

                /// <summary>
                /// <para>The time when the table was last accessed. This value is returned when the table is a non-partitioned table.</para>
                /// <remarks>
                /// <para> The data collection method is upgraded from July 2023. If the data is not accessed after the upgrade or is accessed by using ALGO jobs or the direct read method of Hologres, the last access time cannot be collected.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1694589365</para>
                /// </summary>
                [NameInMap("lastAccessTime")]
                [Validation(Required=false)]
                public long? LastAccessTime { get; set; }

                /// <summary>
                /// <para>The storage usage at the long-term storage tier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("longTermStorage")]
                [Validation(Required=false)]
                public double? LongTermStorage { get; set; }

                /// <summary>
                /// <para>The number of long-term storage files.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("longTermStorageFileCount")]
                [Validation(Required=false)]
                public long? LongTermStorageFileCount { get; set; }

                /// <summary>
                /// <para>The unit of the storage usage at the long-term storage tier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>B</para>
                /// </summary>
                [NameInMap("longTermStorageUnit")]
                [Validation(Required=false)]
                public string LongTermStorageUnit { get; set; }

                /// <summary>
                /// <para>The storage usage at the low-frequency tier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("lowFreqStorage")]
                [Validation(Required=false)]
                public double? LowFreqStorage { get; set; }

                /// <summary>
                /// <para>The number of low-frequency storage files.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("lowFreqStorageFileCount")]
                [Validation(Required=false)]
                public long? LowFreqStorageFileCount { get; set; }

                /// <summary>
                /// <para>The unit of the storage usage at the low-frequency storage tier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>B</para>
                /// </summary>
                [NameInMap("lowFreqStorageUnit")]
                [Validation(Required=false)]
                public string LowFreqStorageUnit { get; set; }

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
                /// <para>The change rate of the total storage usage compared with that of the recent {$recentDays} days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
                /// <para>The storage usage at the standard storage tier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("standardStorage")]
                [Validation(Required=false)]
                public double? StandardStorage { get; set; }

                /// <summary>
                /// <para>The number of standard storage files.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("standardStorageFileCount")]
                [Validation(Required=false)]
                public long? StandardStorageFileCount { get; set; }

                /// <summary>
                /// <para>The unit of the storage usage at the standard storage tier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KB</para>
                /// </summary>
                [NameInMap("standardStorageUnit")]
                [Validation(Required=false)]
                public string StandardStorageUnit { get; set; }

                /// <summary>
                /// <para>The table storage type.</para>
                /// <list type="bullet">
                /// <item><description>standard</description></item>
                /// <item><description>lowfrequency</description></item>
                /// <item><description>longterm</description></item>
                /// <item><description>unknown: This value is returned when the table is a partitioned table. You can call the ListStoragePartitionsInfo operation to query the storage type of each partition.</description></item>
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
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>Access behaviors include:</para>
                /// </description></item>
                /// <item><description><para>The table is used as the input table of an SQL task.</para>
                /// </description></item>
                /// <item><description><para>The table is downloaded by Tunnel.</para>
                /// </description></item>
                /// <item><description><para>The table is read by calling the Storage API. The partition granularity of the partitioned table is not available. Each time an access operation is performed, the access frequency is incremented by 1.</para>
                /// </description></item>
                /// <item><description><para>The data collection method is upgraded from July 2023. If the data is not accessed after the upgrade or is accessed by using ALGO jobs or the direct read method of Hologres, the access frequency cannot be collected.</para>
                /// </description></item>
                /// </list>
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
                /// <para> The amount of data that is read by all access behaviors.</para>
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
                /// <para>The total storage usage. For a partitioned table, this parameter indicates the sum of the storage usage of all partitions. If the storage types of partitions are different, the value is the sum of the storage usage of each storage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("totalStorage")]
                [Validation(Required=false)]
                public double? TotalStorage { get; set; }

                /// <summary>
                /// <para>The total number of files.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("totalStorageFileCount")]
                [Validation(Required=false)]
                public long? TotalStorageFileCount { get; set; }

                /// <summary>
                /// <para>The unit of storage usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>KB</para>
                /// </summary>
                [NameInMap("totalStorageUnit")]
                [Validation(Required=false)]
                public string TotalStorageUnit { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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
        /// <item><description>1xx: informational response. The request is received and is being processed.</description></item>
        /// <item><description>2xx: success. The request is successfully received, understood, and accepted by the server.</description></item>
        /// <item><description>3xx: redirection. The request is redirected, and further actions are required to complete the request.</description></item>
        /// <item><description>4xx: client error. The request contains invalid request parameters and syntaxes, or specific request conditions cannot be met.</description></item>
        /// <item><description>5xx: server error. The server cannot meet requirements due to other reasons.</description></item>
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
        /// <para>0bc12e6a16679892465424670db3eb</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
