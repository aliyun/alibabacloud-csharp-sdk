// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class RestoreInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Cluster administrator password.</para>
        /// 
        /// <b>Example:</b>
        /// <para>password_example</para>
        /// </summary>
        [NameInMap("AdminPassword")]
        [Validation(Required=false)]
        public string AdminPassword { get; set; }

        /// <summary>
        /// <para>Enable auto-renewal. This parameter applies only when PayType is prePaid. Default: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>Backup job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bk-adskj23hd9s</para>
        /// </summary>
        [NameInMap("BackupTaskId")]
        [Validation(Required=false)]
        public string BackupTaskId { get; set; }

        /// <summary>
        /// <para>Subscription duration. This parameter applies only when PayType is prePaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>Instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Payment type:
        /// prePaid for subscription
        /// postPaid for pay-as-you-go</para>
        /// 
        /// <b>Example:</b>
        /// <para>prePaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>Billing cycle unit. This parameter applies only when PayType is prePaid.
        /// Month for monthly billing
        /// Year for yearly billing</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

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
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzllkih7jqxxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Tag struct.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<RestoreInstanceRequestTags> Tags { get; set; }
        public class RestoreInstanceRequestTags : TeaModel {
            /// <summary>
            /// <para>Tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dukang-chengdu-sgueg</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;reasons\&quot;: [], \&quot;patterns\&quot;: [], \&quot;aggregates\&quot;: [], \&quot;event_statistic\&quot;: {\&quot;statistic\&quot;: {}}}</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>VSwitch and zone information.</para>
        /// </summary>
        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public List<RestoreInstanceRequestVSwitches> VSwitches { get; set; }
        public class RestoreInstanceRequestVSwitches : TeaModel {
            /// <summary>
            /// <para>VSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp19mlh98tm9teyyd****</para>
            /// </summary>
            [NameInMap("VswId")]
            [Validation(Required=false)]
            public string VswId { get; set; }

            /// <summary>
            /// <para>Zone ID of the VSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1fll2mci6d7pw8m****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
