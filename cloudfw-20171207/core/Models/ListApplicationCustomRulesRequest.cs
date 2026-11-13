// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ListApplicationCustomRulesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>acr-7d2e4f6a8b0c1d3e</para>
        /// </summary>
        [NameInMap("ApplicationCustomRuleId")]
        [Validation(Required=false)]
        public string ApplicationCustomRuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>自定义规则</para>
        /// </summary>
        [NameInMap("ApplicationCustomRuleName")]
        [Validation(Required=false)]
        public string ApplicationCustomRuleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10012150000</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ati-4f0691c56b8d4f06</para>
        /// </summary>
        [NameInMap("ApplicationTemplateId")]
        [Validation(Required=false)]
        public string ApplicationTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Deny</para>
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public string RuleAction { get; set; }

    }

}
