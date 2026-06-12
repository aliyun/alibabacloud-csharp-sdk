// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class RenewServiceInstanceResourcesRequest : TeaModel {
        /// <summary>
        /// <para>A client token to ensure that the request is idempotent. Generate a unique value for this parameter from your client for each request. The token can contain only ASCII characters and must not exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The renewal duration for all subscription resources in the service instance. The unit is specified by \<c>PeriodUnit\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The time unit of the renewal duration for all subscription resources in the service instance. This parameter specifies the unit for \<c>Period\\</c>. Valid values: \<c>Month\\</c> and \<c>Year\\</c>. Default value: \<c>Month\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of resource renewals.</para>
        /// </summary>
        [NameInMap("ResourcePeriod")]
        [Validation(Required=false)]
        public List<RenewServiceInstanceResourcesRequestResourcePeriod> ResourcePeriod { get; set; }
        public class RenewServiceInstanceResourcesRequestResourcePeriod : TeaModel {
            /// <summary>
            /// <para>The renewal duration for the resource. The unit is specified by \<c>PeriodUnit\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The time unit of the renewal duration for the resource. This parameter specifies the unit for \<c>Period\\</c>. Valid values: \<c>Month\\</c> and \<c>Year\\</c>. Default value: \<c>Month\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>The Aliyun Resource Name (ARN) of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ecs:cn-hongkong:1488317743351199:instance/i-j6c6f3lbky38o8rpeqw2</para>
            /// </summary>
            [NameInMap("ResourceArn")]
            [Validation(Required=false)]
            public string ResourceArn { get; set; }

        }

        /// <summary>
        /// <para>The service instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-b58c874912fc4294****</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

    }

}
