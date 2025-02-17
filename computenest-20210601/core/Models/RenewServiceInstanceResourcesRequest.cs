// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class RenewServiceInstanceResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The renewal duration for all prepaid resources in the service instance. The unit is specified by PeriodUnit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The time unit for the renewal duration of all prepaid resources in the service instance, which is the unit for the Period parameter. Valid values: Month, Year. Default value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>List of resource renewals.</para>
        /// </summary>
        [NameInMap("ResourcePeriod")]
        [Validation(Required=false)]
        public List<RenewServiceInstanceResourcesRequestResourcePeriod> ResourcePeriod { get; set; }
        public class RenewServiceInstanceResourcesRequestResourcePeriod : TeaModel {
            /// <summary>
            /// <para>The renewal duration for the resource. The unit is specified by PeriodUnit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The time unit for the renewal duration of the resource, which is the unit for the Period parameter. Valid values: Month, Year. Default value: Month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("PeriodUnit")]
            [Validation(Required=false)]
            public string PeriodUnit { get; set; }

            /// <summary>
            /// <para>Resource ARN (Aliyun Resource Name).</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ecs:cn-hongkong:1488317743351199:instance/i-j6c6f3lbky38o8rpeqw2</para>
            /// </summary>
            [NameInMap("ResourceArn")]
            [Validation(Required=false)]
            public string ResourceArn { get; set; }

        }

        /// <summary>
        /// <para>Service instance ID.</para>
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
