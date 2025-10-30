// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListPrometheusInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Maximum number of records to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>List of Prometheus instances.</para>
        /// </summary>
        [NameInMap("prometheusInstances")]
        [Validation(Required=false)]
        public List<ListPrometheusInstancesResponseBodyPrometheusInstances> PrometheusInstances { get; set; }
        public class ListPrometheusInstancesResponseBodyPrometheusInstances : TeaModel {
            /// <summary>
            /// <para>Access type:
            /// readWrite, readOnly, httpReadOnly</para>
            /// 
            /// <b>Example:</b>
            /// <para>readWrite</para>
            /// </summary>
            [NameInMap("accessType")]
            [Validation(Required=false)]
            public string AccessType { get; set; }

            /// <summary>
            /// <para>Instance creation time, using UTC+0 time, formatted as yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-10T02:07:53Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>remote-write</para>
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>POSTPAY: Postpaid by metric.
            /// POSTPAY_GB: Postpaid by write volume.
            /// PREPAY: Prepaid.
            /// FREE: Free.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY_GB</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>Product to which the prom instance belongs</para>
            /// 
            /// <b>Example:</b>
            /// <para>arms</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rw-63549e054ff596a4149927961dff</para>
            /// </summary>
            [NameInMap("prometheusInstanceId")]
            [Validation(Required=false)]
            public string PrometheusInstanceId { get; set; }

            /// <summary>
            /// <para>Instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-prom-name</para>
            /// </summary>
            [NameInMap("prometheusInstanceName")]
            [Validation(Required=false)]
            public string PrometheusInstanceName { get; set; }

            /// <summary>
            /// <para>Region ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-nanjing</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aek2bhocin5e2na</para>
            /// </summary>
            [NameInMap("resourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Prometheus</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>Backend data storage status</para>
            /// 
            /// <b>Example:</b>
            /// <para>Pending2Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Supported authentication types.</para>
            /// </summary>
            [NameInMap("supportAuthTypes")]
            [Validation(Required=false)]
            public List<string> SupportAuthTypes { get; set; }

            /// <summary>
            /// <para>Tags key.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<ListPrometheusInstancesResponseBodyPrometheusInstancesTags> Tags { get; set; }
            public class ListPrometheusInstancesResponseBodyPrometheusInstancesTags : TeaModel {
                /// <summary>
                /// <para>Tag key</para>
                /// 
                /// <b>Example:</b>
                /// <para>testKey</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testValue</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17073812345</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>Version</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>Workspace to which the Prometheus instance belongs</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-cms-115214006-cn-hangzhou</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>264C3E89-XXXX-XXXX-XXXX-CE9C2196C7DC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of instances</para>
        /// 
        /// <b>Example:</b>
        /// <para>66</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
