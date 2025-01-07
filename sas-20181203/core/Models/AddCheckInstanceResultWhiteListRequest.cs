// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddCheckInstanceResultWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the group to which the check item belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cQFq20UzZ49K6gRSJD1301****</para>
        /// </summary>
        [NameInMap("CheckGroupId")]
        [Validation(Required=false)]
        public string CheckGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the check item.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListCheckResult~~">ListCheckResult</a> operation to query the IDs of check items.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>The instance IDs of the assets.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The asset instances.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<AddCheckInstanceResultWhiteListRequestInstanceList> InstanceList { get; set; }
        public class AddCheckInstanceResultWhiteListRequestInstanceList : TeaModel {
            /// <summary>
            /// <para>The instance ID of the asset.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~ListCheckInstanceResult~~">ListCheckInstanceResult</a> operation to query the instance IDs of assets.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9fdluqx20mp2x7****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region ID of the asset.</para>
            /// <remarks>
            /// <para> You can call the <a href="~~ListCheckInstanceResult~~">ListCheckInstanceResult</a> operation to query the region ID of the asset.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hongkong</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The description. The value of this parameter can be up to 65,535 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The type of the rule. Default value: <b>WHITE</b>. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>WHITE: adds check items to the whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WHITE</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}
