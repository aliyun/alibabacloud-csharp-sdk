// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class SaveCostCenterShareRuleRequest : TeaModel {
        /// <summary>
        /// <para>The list of allocation rules to create.</para>
        /// </summary>
        [NameInMap("CreateShareRuleList")]
        [Validation(Required=false)]
        public List<SaveCostCenterShareRuleRequestCreateShareRuleList> CreateShareRuleList { get; set; }
        public class SaveCostCenterShareRuleRequestCreateShareRuleList : TeaModel {
            /// <summary>
            /// <para>The list of source financial units.</para>
            /// </summary>
            [NameInMap("FromCostCenterList")]
            [Validation(Required=false)]
            public List<long?> FromCostCenterList { get; set; }

            /// <summary>
            /// <para>The list of allocation ratios.</para>
            /// </summary>
            [NameInMap("ShareRatioList")]
            [Validation(Required=false)]
            public List<double?> ShareRatioList { get; set; }

            /// <summary>
            /// <para>The name of the allocation rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ShareRuleName")]
            [Validation(Required=false)]
            public string ShareRuleName { get; set; }

            /// <summary>
            /// <para>The type of the allocation rule.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RATIO</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>The list of destination financial units.</para>
            /// </summary>
            [NameInMap("ToCostCenterList")]
            [Validation(Required=false)]
            public List<long?> ToCostCenterList { get; set; }

        }

        /// <summary>
        /// <para>The list of allocation rules to update.</para>
        /// </summary>
        [NameInMap("ModifyShareRuleList")]
        [Validation(Required=false)]
        public List<SaveCostCenterShareRuleRequestModifyShareRuleList> ModifyShareRuleList { get; set; }
        public class SaveCostCenterShareRuleRequestModifyShareRuleList : TeaModel {
            /// <summary>
            /// <para>The list of source financial units.</para>
            /// </summary>
            [NameInMap("FromCostCenterList")]
            [Validation(Required=false)]
            public List<long?> FromCostCenterList { get; set; }

            /// <summary>
            /// <para>The list of allocation ratios.</para>
            /// </summary>
            [NameInMap("ShareRatioList")]
            [Validation(Required=false)]
            public List<double?> ShareRatioList { get; set; }

            /// <summary>
            /// <para>The ID of the allocation rule.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1828</para>
            /// </summary>
            [NameInMap("ShareRuleId")]
            [Validation(Required=false)]
            public long? ShareRuleId { get; set; }

            /// <summary>
            /// <para>The name of the allocation rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ShareRuleName")]
            [Validation(Required=false)]
            public string ShareRuleName { get; set; }

            /// <summary>
            /// <para>The type of the allocation rule.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>The list of destination financial units.</para>
            /// </summary>
            [NameInMap("ToCostCenterList")]
            [Validation(Required=false)]
            public List<long?> ToCostCenterList { get; set; }

        }

        /// <summary>
        /// <para>The ID of the level-1 sales channel. If this parameter is left empty, the ID of the sales channel to which the current user belongs is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>The ID of the user who owns the financial unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1977800748053695</para>
        /// </summary>
        [NameInMap("OwnerAccountId")]
        [Validation(Required=false)]
        public long? OwnerAccountId { get; set; }

        /// <summary>
        /// <para>The list of allocation rules to delete.</para>
        /// </summary>
        [NameInMap("RemoveShareRuleList")]
        [Validation(Required=false)]
        public List<long?> RemoveShareRuleList { get; set; }

    }

}
