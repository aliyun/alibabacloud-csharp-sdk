// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceInstanceResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token.</para>
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
            /// <para>The time when the service instance was created.</para>
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
            /// <item><description>Subscription</description></item>
            /// <item><description>PayAsYouGo</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Subscription</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The code of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rds</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The type of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>The renewal state. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AutoRenewal</description></item>
            /// <item><description>ManualRenewal</description></item>
            /// <item><description>NotRenewal</description></item>
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
            /// <item><description>Month</description></item>
            /// <item><description>Year</description></item>
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
            /// <para>The status of the service instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Created</description></item>
            /// <item><description>Deploying</description></item>
            /// <item><description>DeployedFailed</description></item>
            /// <item><description>Deployed</description></item>
            /// <item><description>Upgrading</description></item>
            /// <item><description>Deleting</description></item>
            /// <item><description>Deleted</description></item>
            /// <item><description>DeletedFailed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CREATE_COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
