// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeLoghubDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried log collection information.</para>
        /// </summary>
        [NameInMap("LoghubInfo")]
        [Validation(Required=false)]
        public DescribeLoghubDetailResponseBodyLoghubInfo LoghubInfo { get; set; }
        public class DescribeLoghubDetailResponseBodyLoghubInfo : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>am-8vbs48m7553du1gz2</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The database type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <para>The name of the log shipping job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hub-pay-callback-ykt</para>
            /// </summary>
            [NameInMap("DeliverName")]
            [Validation(Required=false)]
            public string DeliverName { get; set; }

            /// <summary>
            /// <para>The log shipping time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-06\&quot;T\&quot;10:15\&quot;Z\&quot;</para>
            /// </summary>
            [NameInMap("DeliverTime")]
            [Validation(Required=false)]
            public string DeliverTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>am-bp1p38m2c26s7hpk690650.ads.aliyuncs.com</para>
            /// </summary>
            [NameInMap("DomainUrl")]
            [Validation(Required=false)]
            public string DomainUrl { get; set; }

            /// <summary>
            /// <para>Indicates whether dirty data is filtered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FilterDirtyData")]
            [Validation(Required=false)]
            public bool? FilterDirtyData { get; set; }

            /// <summary>
            /// <para>The log keywords.</para>
            /// </summary>
            [NameInMap("LogHubStores")]
            [Validation(Required=false)]
            public DescribeLoghubDetailResponseBodyLoghubInfoLogHubStores LogHubStores { get; set; }
            public class DescribeLoghubDetailResponseBodyLoghubInfoLogHubStores : TeaModel {
                [NameInMap("LogHubStore")]
                [Validation(Required=false)]
                public List<DescribeLoghubDetailResponseBodyLoghubInfoLogHubStoresLogHubStore> LogHubStore { get; set; }
                public class DescribeLoghubDetailResponseBodyLoghubInfoLogHubStoresLogHubStore : TeaModel {
                    /// <summary>
                    /// <para>The value of the log keyword.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>channel_id</para>
                    /// </summary>
                    [NameInMap("FieldKey")]
                    [Validation(Required=false)]
                    public string FieldKey { get; set; }

                    /// <summary>
                    /// <para>The log keyword.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>put_request</para>
                    /// </summary>
                    [NameInMap("LogKey")]
                    [Validation(Required=false)]
                    public string LogKey { get; set; }

                }

            }

            /// <summary>
            /// <para>The name of the Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>device_login</para>
            /// </summary>
            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            /// <summary>
            /// <para>The name of the Simple Log Service project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-adb</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbd_bi</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test2</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The name of the database account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-k</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
