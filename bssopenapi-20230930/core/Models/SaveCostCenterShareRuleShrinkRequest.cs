// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class SaveCostCenterShareRuleShrinkRequest : TeaModel {
        [NameInMap("CreateShareRuleList")]
        [Validation(Required=false)]
        public string CreateShareRuleListShrink { get; set; }

        [NameInMap("ModifyShareRuleList")]
        [Validation(Required=false)]
        public string ModifyShareRuleListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1977800748053695</para>
        /// </summary>
        [NameInMap("OwnerAccountId")]
        [Validation(Required=false)]
        public long? OwnerAccountId { get; set; }

        [NameInMap("RemoveShareRuleList")]
        [Validation(Required=false)]
        public string RemoveShareRuleListShrink { get; set; }

    }

}
