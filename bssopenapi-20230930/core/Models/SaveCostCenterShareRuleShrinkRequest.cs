// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class SaveCostCenterShareRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of allocation rules to create.</para>
        /// </summary>
        [NameInMap("CreateShareRuleList")]
        [Validation(Required=false)]
        public string CreateShareRuleListShrink { get; set; }

        /// <summary>
        /// <para>The list of allocation rules to update.</para>
        /// </summary>
        [NameInMap("ModifyShareRuleList")]
        [Validation(Required=false)]
        public string ModifyShareRuleListShrink { get; set; }

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
        public string RemoveShareRuleListShrink { get; set; }

    }

}
