// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class AddRuleV4Request : TeaModel {
        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>Specifies whether to copy the rule. Set this to \<c>true\\</c> to copy the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsCopy")]
        [Validation(Required=false)]
        public bool? IsCopy { get; set; }

        /// <summary>
        /// <para>For more information about JsonStrForRule, see <a href="https://help.aliyun.com/document_detail/453053.html"><c>Rule object description</c></a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("JsonStrForRule")]
        [Validation(Required=false)]
        public string JsonStrForRule { get; set; }

    }

}
