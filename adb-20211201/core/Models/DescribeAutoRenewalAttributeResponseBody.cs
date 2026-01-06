// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAutoRenewalAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of auto-renewal details.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeAutoRenewalAttributeResponseBodyItems Items { get; set; }
        public class DescribeAutoRenewalAttributeResponseBodyItems : TeaModel {
            [NameInMap("AutoRenewalAttribute")]
            [Validation(Required=false)]
            public List<DescribeAutoRenewalAttributeResponseBodyItemsAutoRenewalAttribute> AutoRenewalAttribute { get; set; }
            public class DescribeAutoRenewalAttributeResponseBodyItemsAutoRenewalAttribute : TeaModel {
                /// <summary>
                /// <para>Indicates whether auto-renewal is enabled for the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enables.</description></item>
                /// <item><description><b>false</b>: Disables.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoRenewalEnabled")]
                [Validation(Required=false)]
                public bool? AutoRenewalEnabled { get; set; }

                /// <summary>
                /// <para>The auto-renewal duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AutoRenewalPeriod")]
                [Validation(Required=false)]
                public long? AutoRenewalPeriod { get; set; }

                /// <summary>
                /// <para>The unit of auto-renewal duration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Year</b></description></item>
                /// <item><description><b>Month</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Year</para>
                /// </summary>
                [NameInMap("AutoRenewalPeriodUnit")]
                [Validation(Required=false)]
                public string AutoRenewalPeriodUnit { get; set; }

                /// <summary>
                /// <para>The renewal method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>AutoRenewal</b>: The cluster is automatically renewed.</description></item>
                /// <item><description><b>Normal</b>: The cluster is manually renewed. Before the cluster expires, the system sends you a reminder by SMS message.</description></item>
                /// <item><description><b>NotRenewal</b>: The cluster is not renewed. Reminders are only sent three days before cluster expiration.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AutoRenewal</para>
                /// </summary>
                [NameInMap("AutoRenewalStatus")]
                [Validation(Required=false)]
                public string AutoRenewalStatus { get; set; }

                /// <summary>
                /// <para>The cluster ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>amv-uf6485635fz8****</para>
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BA0F6761-7A8C-59F8-9624-FB56788C0EDF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
