// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UpdateRuleByIdRequest : TeaModel {
        /// <summary>
        /// <para>Workspace ID</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>Whether to copy. Setting to true is equivalent to copying the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsCopy")]
        [Validation(Required=false)]
        public bool? IsCopy { get; set; }

        /// <summary>
        /// <para>For more information about the format of JsonStrForlRule, see <a href="https://help.aliyun.com/document_detail/453053.html"><c>Rule object description</c></a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("JsonStrForRule")]
        [Validation(Required=false)]
        public string JsonStrForRule { get; set; }

        /// <summary>
        /// <para>Returns the IDs and names of quality inspection schemes associated with this rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ReturnRelatedSchemes")]
        [Validation(Required=false)]
        public bool? ReturnRelatedSchemes { get; set; }

        /// <summary>
        /// <para>Rule ID. Not required when creating, required when modifying.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
