// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCheckRuleRequest : TeaModel {
        /// <summary>
        /// <para>The list of instances to be added in this rule update. This parameter does not need to be passed if there are no instances to add.</para>
        /// </summary>
        [NameInMap("AddInstanceList")]
        [Validation(Required=false)]
        public List<ModifyCheckRuleRequestAddInstanceList> AddInstanceList { get; set; }
        public class ModifyCheckRuleRequestAddInstanceList : TeaModel {
            /// <summary>
            /// <para>The instance ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9g8ljygfqs1ez3****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The list of instances to be removed in this rule update. This parameter does not need to be passed if there are no instances to remove.</para>
        /// </summary>
        [NameInMap("DeleteInstanceList")]
        [Validation(Required=false)]
        public List<ModifyCheckRuleRequestDeleteInstanceList> DeleteInstanceList { get; set; }
        public class ModifyCheckRuleRequestDeleteInstanceList : TeaModel {
            /// <summary>
            /// <para>The instance ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vb0e8qdaj0yyxjo****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>Remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRemark</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>Rule ID.</para>
        /// <remarks>
        /// <para>You can obtain this parameter by calling the <a href="https://help.aliyun.com/document_detail/2590599.html">ListCheckRule</a> API.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9000**</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>Rule type. Default is <b>WHITE</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>WHITE</b>: Add to whitelist</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WHITE</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>The scope of effect for modifying the rule:</para>
        /// <list type="bullet">
        /// <item><description><b>INSTANCE</b>: Instance</description></item>
        /// <item><description><b>ITEM</b>: Check item</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
