// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListPrometheusViewsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of records returned.</para>
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
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2-ba4d-4b9f-aa24-dcb067a30f1c</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of Prometheus view instances.</para>
        /// </summary>
        [NameInMap("prometheusViews")]
        [Validation(Required=false)]
        public List<ListPrometheusViewsResponseBodyPrometheusViews> PrometheusViews { get; set; }
        public class ListPrometheusViewsResponseBodyPrometheusViews : TeaModel {
            /// <summary>
            /// <para>The time when the instance was created. The time is in UTC and in the \<c>yyyy-MM-ddTHH:mmZ\\</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-12T02:18:36Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The instance type. Valid values are \<c>prom-view\\</c> for a new-version aggregation view and \<c>global-view\\</c> for an old-version aggregation view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prom-view</para>
            /// </summary>
            [NameInMap("instanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The billing method. The value is fixed to \<c>FREE\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FREE</para>
            /// </summary>
            [NameInMap("paymentType")]
            [Validation(Required=false)]
            public string PaymentType { get; set; }

            /// <summary>
            /// <para>The product to which the Prometheus instance belongs. Valid values: \<c>arms\\</c> and \<c>cms\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cms</para>
            /// </summary>
            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The number of Prometheus instances in the view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("prometheusInstanceCount")]
            [Validation(Required=false)]
            public int? PrometheusInstanceCount { get; set; }

            /// <summary>
            /// <para>The Prometheus view ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>view-xxx</para>
            /// </summary>
            [NameInMap("prometheusViewId")]
            [Validation(Required=false)]
            public string PrometheusViewId { get; set; }

            /// <summary>
            /// <para>The name of the Prometheus view.</para>
            /// 
            /// <b>Example:</b>
            /// <para>view1</para>
            /// </summary>
            [NameInMap("prometheusViewName")]
            [Validation(Required=false)]
            public string PrometheusViewName { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource type. The value is fixed to \<c>PrometheusView\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrometheusView</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The status of the backend data storage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxx</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>V2</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The workspace to which the Prometheus instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default-cms-1490404746278495-cn-hangzhou</para>
            /// </summary>
            [NameInMap("workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CEC5375-C554-562B-A65F-9A629907C1F0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
