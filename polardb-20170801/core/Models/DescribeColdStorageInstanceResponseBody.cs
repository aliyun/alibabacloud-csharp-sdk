// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeColdStorageInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. If this parameter is not returned, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2FpXzIwMjIwNjI5X2Jhay9zYWlfc3VtbWVyX3RyZWFzdXJlX3Bvb2xfbG9nLkNTVg==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The object type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TABLE</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>Indicates whether the OSS bucket is enabled.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OssClusterEnabled")]
        [Validation(Required=false)]
        public string OssClusterEnabled { get; set; }

        /// <summary>
        /// <para>The list of OSS addresses for the cold storage instances.</para>
        /// </summary>
        [NameInMap("OssClusterInfoList")]
        [Validation(Required=false)]
        public List<DescribeColdStorageInstanceResponseBodyOssClusterInfoList> OssClusterInfoList { get; set; }
        public class DescribeColdStorageInstanceResponseBodyOssClusterInfoList : TeaModel {
            /// <summary>
            /// <para>The time when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-10T17:01:16Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The ID of the cold storage instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-*****************</para>
            /// </summary>
            [NameInMap("OssClusterId")]
            [Validation(Required=false)]
            public string OssClusterId { get; set; }

            /// <summary>
            /// <para>The ID of the region where the task is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The size of the cold storage table. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C7A8EA8E-A140-5226-90D7-5BCB304D3DB6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the cluster supports cold storage. If the cluster does not support cold storage, the switch is not displayed on the console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportOssCluster")]
        [Validation(Required=false)]
        public string SupportOssCluster { get; set; }

        /// <summary>
        /// <para>The list of cold storage instances.</para>
        /// </summary>
        [NameInMap("Tables")]
        [Validation(Required=false)]
        public List<DescribeColdStorageInstanceResponseBodyTables> Tables { get; set; }
        public class DescribeColdStorageInstanceResponseBodyTables : TeaModel {
            /// <summary>
            /// <para>The list of child objects.</para>
            /// </summary>
            [NameInMap("ChildObjects")]
            [Validation(Required=false)]
            public List<DescribeColdStorageInstanceResponseBodyTablesChildObjects> ChildObjects { get; set; }
            public class DescribeColdStorageInstanceResponseBodyTablesChildObjects : TeaModel {
                /// <summary>
                /// <para>The object name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>img/1728554006462.png</para>
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// <para>The object type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>File</para>
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <para>The disk size. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                /// <summary>
                /// <para>The status of the task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Scheduled</b>: The task is waiting to be executed.</para>
                /// </description></item>
                /// <item><description><para><b>Running</b>: The task is in progress.</para>
                /// </description></item>
                /// <item><description><para><b>Succeed</b>: The task is successful.</para>
                /// </description></item>
                /// <item><description><para><b>Cancelling</b>: The task is being stopped.</para>
                /// </description></item>
                /// <item><description><para><b>Canceled</b>: The task is stopped.</para>
                /// </description></item>
                /// <item><description><para><b>Waiting</b>: The task is waiting for a preset time.</para>
                /// </description></item>
                /// </list>
                /// <para>To query multiple statuses, separate them with commas (,). If you do not specify this parameter, all statuses are queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("DB")]
            [Validation(Required=false)]
            public string DB { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// <para>The name of the large object (LOB) field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The ID of the OSS-based cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-*****************</para>
            /// </summary>
            [NameInMap("OssClusterId")]
            [Validation(Required=false)]
            public string OssClusterId { get; set; }

            /// <summary>
            /// <para>The partition of the cold storage instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202509</para>
            /// </summary>
            [NameInMap("Partion")]
            [Validation(Required=false)]
            public string Partion { get; set; }

            /// <summary>
            /// <para>The disk size of the cold storage instance. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <para>The status of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            /// <summary>
            /// <para>The table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_table</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecord")]
        [Validation(Required=false)]
        public int? TotalRecord { get; set; }

    }

}
