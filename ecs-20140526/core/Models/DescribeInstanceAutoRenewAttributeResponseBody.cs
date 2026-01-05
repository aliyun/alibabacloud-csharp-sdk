// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceAutoRenewAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The renewal attributes of instances.</para>
        /// </summary>
        [NameInMap("InstanceRenewAttributes")]
        [Validation(Required=false)]
        public DescribeInstanceAutoRenewAttributeResponseBodyInstanceRenewAttributes InstanceRenewAttributes { get; set; }
        public class DescribeInstanceAutoRenewAttributeResponseBodyInstanceRenewAttributes : TeaModel {
            [NameInMap("InstanceRenewAttribute")]
            [Validation(Required=false)]
            public List<DescribeInstanceAutoRenewAttributeResponseBodyInstanceRenewAttributesInstanceRenewAttribute> InstanceRenewAttribute { get; set; }
            public class DescribeInstanceAutoRenewAttributeResponseBodyInstanceRenewAttributesInstanceRenewAttribute : TeaModel {
                /// <summary>
                /// <para>Indicates whether auto-renewal is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("AutoRenewEnabled")]
                [Validation(Required=false)]
                public bool? AutoRenewEnabled { get; set; }

                /// <summary>
                /// <para>The auto-renewal duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("EnableExpectedRenewDay")]
                [Validation(Required=false)]
                public bool? EnableExpectedRenewDay { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp18x3z4hc7bixhx****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The unit of the auto-renewal duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>week</para>
                /// </summary>
                [NameInMap("PeriodUnit")]
                [Validation(Required=false)]
                public string PeriodUnit { get; set; }

                /// <summary>
                /// <para>The auto-renewal state of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AutoRenewal: Auto-renewal is enabled for the instance.</description></item>
                /// <item><description>Normal: Auto-renewal is disabled for the instance.</description></item>
                /// <item><description>NotRenewal: The instance is not to be renewed. The system sends no more expiration reminders, but sends only a non-renewal reminder three days before the expiration date. For an instance that is not to be renewed, you can call the <a href="https://help.aliyun.com/document_detail/52843.html">ModifyInstanceAutoRenewAttribute</a> operation to change its auto-renewal status to <c>Normal</c>. Then, you can manually renew the instance or enable auto-renewal for the instance.</description></item>
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of queried instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
