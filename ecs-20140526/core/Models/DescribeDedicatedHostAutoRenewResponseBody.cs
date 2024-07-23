// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDedicatedHostAutoRenewResponseBody : TeaModel {
        /// <summary>
        /// <para>The array that consists of dedicated host auto-renewal attributes.</para>
        /// </summary>
        [NameInMap("DedicatedHostRenewAttributes")]
        [Validation(Required=false)]
        public DescribeDedicatedHostAutoRenewResponseBodyDedicatedHostRenewAttributes DedicatedHostRenewAttributes { get; set; }
        public class DescribeDedicatedHostAutoRenewResponseBodyDedicatedHostRenewAttributes : TeaModel {
            [NameInMap("DedicatedHostRenewAttribute")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostAutoRenewResponseBodyDedicatedHostRenewAttributesDedicatedHostRenewAttribute> DedicatedHostRenewAttribute { get; set; }
            public class DescribeDedicatedHostAutoRenewResponseBodyDedicatedHostRenewAttributesDedicatedHostRenewAttribute : TeaModel {
                /// <summary>
                /// <para>Indicates whether auto-renewal is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AutoRenewEnabled")]
                [Validation(Required=false)]
                public bool? AutoRenewEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the dedicated host is automatically renewed if a subscription ECS instance it hosts, after being automatically renewed, has a new expiration time that is later than that of the dedicated host. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AutoRenewWithEcs: The dedicated host is automatically renewed along with the ECS instance.</description></item>
                /// <item><description>StopRenewWithEcs: The dedicated host is not automatically renewed along with the ECS instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>StopRenewWithEcs</para>
                /// </summary>
                [NameInMap("AutoRenewWithEcs")]
                [Validation(Required=false)]
                public string AutoRenewWithEcs { get; set; }

                /// <summary>
                /// <para>The ID of the dedicated host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dh-bp165p6xk2tlw61e****</para>
                /// </summary>
                [NameInMap("DedicatedHostId")]
                [Validation(Required=false)]
                public string DedicatedHostId { get; set; }

                /// <summary>
                /// <para>The auto-renewal period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The unit of the auto-renewal duration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Week</description></item>
                /// <item><description>Month</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Month</para>
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <para>Indicates whether the subscription dedicated host is automatically renewed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AutoRenewal: The dedicated host is automatically renewed.</description></item>
                /// <item><description>Normal: The dedicated host is not automatically renewed, but renewal notifications are sent.</description></item>
                /// <item><description>NotRenewal: The dedicated host is not automatically renewed, and no expiration notification is sent. Alibaba Cloud sends only a non-renewal notice three days before the host expires. If the renewal status of a dedicated host is NotRenewal, you can change the value to Normal and then call <a href="https://help.aliyun.com/document_detail/93287.html">RenewDedicatedHosts</a> to manually renew the dedicated host, or directly change the value to AutoRenewal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("RenewalStatus")]
                [Validation(Required=false)]
                public string RenewalStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
