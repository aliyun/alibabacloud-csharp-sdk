// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UpdateRuleV4Request : TeaModel {
        /// <summary>
        /// <para>baseMeAgentId</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>For details about JsonStrForRule, see the document <a href="https://help.aliyun.com/document_detail/453053.html"><c>Rule Object Description</c></a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("JsonStrForRule")]
        [Validation(Required=false)]
        public string JsonStrForRule { get; set; }

        /// <summary>
        /// <para>Rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
