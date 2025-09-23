// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeColdStorageInstanceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c2FpXzIwMjIwNjI5X2Jhay9zYWlfc3VtbWVyX3RyZWFzdXJlX3Bvb2xfbG9nLkNTVg==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TABLE</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OssClusterEnabled")]
        [Validation(Required=false)]
        public string OssClusterEnabled { get; set; }

        [NameInMap("OssClusterInfoList")]
        [Validation(Required=false)]
        public List<DescribeColdStorageInstanceResponseBodyOssClusterInfoList> OssClusterInfoList { get; set; }
        public class DescribeColdStorageInstanceResponseBodyOssClusterInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-05-10T17:01:16Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pc-*****************</para>
            /// </summary>
            [NameInMap("OssClusterId")]
            [Validation(Required=false)]
            public string OssClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C7A8EA8E-A140-5226-90D7-5BCB304D3DB6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportOssCluster")]
        [Validation(Required=false)]
        public string SupportOssCluster { get; set; }

        [NameInMap("Tables")]
        [Validation(Required=false)]
        public List<DescribeColdStorageInstanceResponseBodyTables> Tables { get; set; }
        public class DescribeColdStorageInstanceResponseBodyTables : TeaModel {
            [NameInMap("ChildObjects")]
            [Validation(Required=false)]
            public List<DescribeColdStorageInstanceResponseBodyTablesChildObjects> ChildObjects { get; set; }
            public class DescribeColdStorageInstanceResponseBodyTablesChildObjects : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>img/1728554006462.png</para>
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>File</para>
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("DB")]
            [Validation(Required=false)]
            public string DB { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_db</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pc-*****************</para>
            /// </summary>
            [NameInMap("OssClusterId")]
            [Validation(Required=false)]
            public string OssClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>202509</para>
            /// </summary>
            [NameInMap("Partion")]
            [Validation(Required=false)]
            public string Partion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_table</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecord")]
        [Validation(Required=false)]
        public int? TotalRecord { get; set; }

    }

}
