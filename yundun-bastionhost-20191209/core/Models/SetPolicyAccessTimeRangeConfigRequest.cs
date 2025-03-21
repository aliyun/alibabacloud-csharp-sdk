// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class SetPolicyAccessTimeRangeConfigRequest : TeaModel {
        /// <summary>
        /// <para>The logon period limits.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AccessTimeRangeConfig")]
        [Validation(Required=false)]
        public SetPolicyAccessTimeRangeConfigRequestAccessTimeRangeConfig AccessTimeRangeConfig { get; set; }
        public class SetPolicyAccessTimeRangeConfigRequestAccessTimeRangeConfig : TeaModel {
            /// <summary>
            /// <para>The details about the periods during which users can log on to the assets.</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public List<SetPolicyAccessTimeRangeConfigRequestAccessTimeRangeConfigEffectiveTime> EffectiveTime { get; set; }
            public class SetPolicyAccessTimeRangeConfigRequestAccessTimeRangeConfigEffectiveTime : TeaModel {
                /// <summary>
                /// <para>The days of the week during which users can log on to the assets.</para>
                /// </summary>
                [NameInMap("Days")]
                [Validation(Required=false)]
                public List<int?> Days { get; set; }

                /// <summary>
                /// <para>The time periods of the day during which users can log on to the assets.</para>
                /// </summary>
                [NameInMap("Hours")]
                [Validation(Required=false)]
                public List<int?> Hours { get; set; }

            }

        }

        /// <summary>
        /// <para>The bastion host ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query the bastion host ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-st220aw****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The control policy ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2758876.html">ListPolicies</a> operation to query the control policy ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The region ID of the bastion host.</para>
        /// <remarks>
        /// <para>For more information about the mapping between region IDs and region names, see <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
