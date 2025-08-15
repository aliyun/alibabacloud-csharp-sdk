// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class SaveCostCenterShareRuleRequest : TeaModel {
        [NameInMap("CreateShareRuleList")]
        [Validation(Required=false)]
        public List<SaveCostCenterShareRuleRequestCreateShareRuleList> CreateShareRuleList { get; set; }
        public class SaveCostCenterShareRuleRequestCreateShareRuleList : TeaModel {
            [NameInMap("FromCostCenterList")]
            [Validation(Required=false)]
            public List<long?> FromCostCenterList { get; set; }

            [NameInMap("ShareRatioList")]
            [Validation(Required=false)]
            public List<double?> ShareRatioList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ShareRuleName")]
            [Validation(Required=false)]
            public string ShareRuleName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RATIO</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            [NameInMap("ToCostCenterList")]
            [Validation(Required=false)]
            public List<long?> ToCostCenterList { get; set; }

        }

        [NameInMap("ModifyShareRuleList")]
        [Validation(Required=false)]
        public List<SaveCostCenterShareRuleRequestModifyShareRuleList> ModifyShareRuleList { get; set; }
        public class SaveCostCenterShareRuleRequestModifyShareRuleList : TeaModel {
            [NameInMap("FromCostCenterList")]
            [Validation(Required=false)]
            public List<long?> FromCostCenterList { get; set; }

            [NameInMap("ShareRatioList")]
            [Validation(Required=false)]
            public List<double?> ShareRatioList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1828</para>
            /// </summary>
            [NameInMap("ShareRuleId")]
            [Validation(Required=false)]
            public long? ShareRuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ShareRuleName")]
            [Validation(Required=false)]
            public string ShareRuleName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            [NameInMap("ToCostCenterList")]
            [Validation(Required=false)]
            public List<long?> ToCostCenterList { get; set; }

        }

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
        public List<long?> RemoveShareRuleList { get; set; }

    }

}
