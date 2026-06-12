// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceInstanceResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on each page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAc3HCuYhJi/wvpk4xOr0VLbAx7BkQzyYC+ONO+WudHGKEdB0uWSY7AGnM3qCgm/Ynge7zU6NWdbj0Tegyajyqyc=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<ListServiceInstanceResourcesResponseBodyResources> Resources { get; set; }
        public class ListServiceInstanceResourcesResponseBodyResources : TeaModel {
            /// <summary>
            /// <para>The time when the resource was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-01T12:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the resource expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-01T12:00:00</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Subscription: subscription.</para>
            /// </description></item>
            /// <item><description><para>PayAsYouGo: pay-as-you-go.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Subscription</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The product code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The product type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The renewal status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>AutoRenewal: auto-renewal.</para>
            /// </description></item>
            /// <item><description><para>ManualRenewal: manual renewal.</para>
            /// </description></item>
            /// <item><description><para>NotRenewal: no renewal.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AutoRenewal</para>
            /// </summary>
            [NameInMap("RenewStatus")]
            [Validation(Required=false)]
            public string RenewStatus { get; set; }

            /// <summary>
            /// <para>The renewal period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RenewalPeriod")]
            [Validation(Required=false)]
            public int? RenewalPeriod { get; set; }

            /// <summary>
            /// <para>The unit of the renewal period. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Month: month.</para>
            /// </description></item>
            /// <item><description><para>Year: year.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("RenewalPeriodUnit")]
            [Validation(Required=false)]
            public string RenewalPeriodUnit { get; set; }

            /// <summary>
            /// <para>The ARN of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arn:acs:sag:cn-hangzhou:130920852836****:ccn/ccn-b3qf0q439sq2de****</para>
            /// </summary>
            [NameInMap("ResourceARN")]
            [Validation(Required=false)]
            public string ResourceARN { get; set; }

            /// <summary>
            /// <para>The status of the resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>running: The resource is running.</para>
            /// </description></item>
            /// <item><description><para>waiting: The resource is pending.</para>
            /// </description></item>
            /// <item><description><para>terminated: The resource is terminated.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is returned only for container resources.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
