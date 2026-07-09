// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class SaveCostCenterShareRuleRequest : TeaModel {
        /// <summary>
        /// <para>The list of sharing rules to create.</para>
        /// </summary>
        [NameInMap("CreateShareRuleList")]
        [Validation(Required=false)]
        public List<SaveCostCenterShareRuleRequestCreateShareRuleList> CreateShareRuleList { get; set; }
        public class SaveCostCenterShareRuleRequestCreateShareRuleList : TeaModel {
            /// <summary>
            /// <para>The list of source cost centers.</para>
            /// </summary>
            [NameInMap("FromCostCenterList")]
            [Validation(Required=false)]
            public List<long?> FromCostCenterList { get; set; }

            /// <summary>
            /// <para>The list of sharing ratios.</para>
            /// </summary>
            [NameInMap("ShareRatioList")]
            [Validation(Required=false)]
            public List<double?> ShareRatioList { get; set; }

            /// <summary>
            /// <para>The name of the sharing rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ShareRuleName")]
            [Validation(Required=false)]
            public string ShareRuleName { get; set; }

            /// <summary>
            /// <para>The type of the sharing rule.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RATIO</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>The list of target cost centers.</para>
            /// </summary>
            [NameInMap("ToCostCenterList")]
            [Validation(Required=false)]
            public List<long?> ToCostCenterList { get; set; }

        }

        /// <summary>
        /// <para>The list of sharing rules to modify.</para>
        /// </summary>
        [NameInMap("ModifyShareRuleList")]
        [Validation(Required=false)]
        public List<SaveCostCenterShareRuleRequestModifyShareRuleList> ModifyShareRuleList { get; set; }
        public class SaveCostCenterShareRuleRequestModifyShareRuleList : TeaModel {
            /// <summary>
            /// <para>The list of source cost centers.</para>
            /// </summary>
            [NameInMap("FromCostCenterList")]
            [Validation(Required=false)]
            public List<long?> FromCostCenterList { get; set; }

            /// <summary>
            /// <para>The list of sharing ratios.</para>
            /// </summary>
            [NameInMap("ShareRatioList")]
            [Validation(Required=false)]
            public List<double?> ShareRatioList { get; set; }

            /// <summary>
            /// <para>The ID of the sharing rule.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1828</para>
            /// </summary>
            [NameInMap("ShareRuleId")]
            [Validation(Required=false)]
            public long? ShareRuleId { get; set; }

            /// <summary>
            /// <para>The name of the sharing rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ShareRuleName")]
            [Validation(Required=false)]
            public string ShareRuleName { get; set; }

            /// <summary>
            /// <para>The type of the sharing rule.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>The list of target cost centers.</para>
            /// </summary>
            [NameInMap("ToCostCenterList")]
            [Validation(Required=false)]
            public List<long?> ToCostCenterList { get; set; }

        }

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
        public List<long?> RemoveShareRuleList { get; set; }

    }

}
