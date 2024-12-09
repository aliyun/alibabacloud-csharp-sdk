// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeLoghubDetailResponseBody : TeaModel {
        [NameInMap("LoghubInfo")]
        [Validation(Required=false)]
        public DescribeLoghubDetailResponseBodyLoghubInfo LoghubInfo { get; set; }
        public class DescribeLoghubDetailResponseBodyLoghubInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>am-8vbs48m7553du1gz2</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rds</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hub-pay-callback-ykt</para>
            /// </summary>
            [NameInMap("DeliverName")]
            [Validation(Required=false)]
            public string DeliverName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-12-06\&quot;T\&quot;10:15\&quot;Z\&quot;</para>
            /// </summary>
            [NameInMap("DeliverTime")]
            [Validation(Required=false)]
            public string DeliverTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>am-bp1p38m2c26s7hpk690650.ads.aliyuncs.com</para>
            /// </summary>
            [NameInMap("DomainUrl")]
            [Validation(Required=false)]
            public string DomainUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FilterDirtyData")]
            [Validation(Required=false)]
            public bool? FilterDirtyData { get; set; }

            [NameInMap("LogHubStores")]
            [Validation(Required=false)]
            public DescribeLoghubDetailResponseBodyLoghubInfoLogHubStores LogHubStores { get; set; }
            public class DescribeLoghubDetailResponseBodyLoghubInfoLogHubStores : TeaModel {
                [NameInMap("LogHubStore")]
                [Validation(Required=false)]
                public List<DescribeLoghubDetailResponseBodyLoghubInfoLogHubStoresLogHubStore> LogHubStore { get; set; }
                public class DescribeLoghubDetailResponseBodyLoghubInfoLogHubStoresLogHubStore : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>channel_id</para>
                    /// </summary>
                    [NameInMap("FieldKey")]
                    [Validation(Required=false)]
                    public string FieldKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>put_request</para>
                    /// </summary>
                    [NameInMap("LogKey")]
                    [Validation(Required=false)]
                    public string LogKey { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>device_login</para>
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-adb</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cbd_bi</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test2</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-k</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
