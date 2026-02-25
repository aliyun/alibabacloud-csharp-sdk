// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class RestoreInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>password_example</para>
        /// </summary>
        [NameInMap("AdminPassword")]
        [Validation(Required=false)]
        public string AdminPassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bk-adskj23hd9s</para>
        /// </summary>
        [NameInMap("BackupTaskId")]
        [Validation(Required=false)]
        public string BackupTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c1</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>prePaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-aekzllkih7jqxxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<RestoreInstanceRequestTags> Tags { get; set; }
        public class RestoreInstanceRequestTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dukang-chengdu-sgueg</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;reasons\&quot;: [], \&quot;patterns\&quot;: [], \&quot;aggregates\&quot;: [], \&quot;event_statistic\&quot;: {\&quot;statistic\&quot;: {}}}</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("VSwitches")]
        [Validation(Required=false)]
        public List<RestoreInstanceRequestVSwitches> VSwitches { get; set; }
        public class RestoreInstanceRequestVSwitches : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-bp19mlh98tm9teyyd****</para>
            /// </summary>
            [NameInMap("VswId")]
            [Validation(Required=false)]
            public string VswId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>vpc ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1fll2mci6d7pw8m****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
