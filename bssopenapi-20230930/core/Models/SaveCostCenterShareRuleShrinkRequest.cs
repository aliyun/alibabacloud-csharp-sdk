// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class SaveCostCenterShareRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of sharing rules to create.</para>
        /// </summary>
        [NameInMap("CreateShareRuleList")]
        [Validation(Required=false)]
        public string CreateShareRuleListShrink { get; set; }

        /// <summary>
        /// <para>The list of sharing rules to modify.</para>
        /// </summary>
        [NameInMap("ModifyShareRuleList")]
        [Validation(Required=false)]
        public string ModifyShareRuleListShrink { get; set; }

        /// <summary>
        /// <para>The primary marketplace ID. If left empty, the marketplace ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>The user ID of the cost center owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1977800748053695</para>
        /// </summary>
        [NameInMap("OwnerAccountId")]
        [Validation(Required=false)]
        public long? OwnerAccountId { get; set; }

        /// <summary>
        /// <para>The list of sharing rules to delete.</para>
        /// </summary>
        [NameInMap("RemoveShareRuleList")]
        [Validation(Required=false)]
        public string RemoveShareRuleListShrink { get; set; }

    }

}
