// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetServiceInstanceSubscriptionEstimateCostRequest : TeaModel {
        /// <summary>
        /// <para>Ensures idempotence of the request. Generate a parameter value from your client to ensure its uniqueness across different requests. <b>ClientToken</b> supports only ASCII characters and cannot exceed 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Order type. Possible value: Renewal.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Renewal</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The renewal duration for all prepaid resources of the service instance. The unit is specified by PeriodUnit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The time unit for the renewal duration of all prepaid resources of the service instance, which is the unit of the Period parameter. Valid values: Month, Year. Default value: Month.</para>
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
        /// <para>Resource renewal configuration.</para>
        /// </summary>
        [NameInMap("ResourcePeriod")]
        [Validation(Required=false)]
        public List<GetServiceInstanceSubscriptionEstimateCostRequestResourcePeriod> ResourcePeriod { get; set; }
        public class GetServiceInstanceSubscriptionEstimateCostRequestResourcePeriod : TeaModel {
            /// <summary>
            /// <para>Renewal duration. The unit is specified by PeriodUnit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The time unit for the resource renewal duration, which is the unit of the Period parameter. Valid values: Month, Year. Default value: Month.</para>
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
            /// <para>acs:ecs:cn-guangzhou:1361753504587228:instance/i-7xv9pgeqvhxg10jji3vd</para>
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
        /// <para>si-d6ab3a63ccbb4b17****</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

    }

}
