// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ListApplicationCustomRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application custom rule. Exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acr-7d2e4f6a8b0c1d3e</para>
        /// </summary>
        [NameInMap("ApplicationCustomRuleId")]
        [Validation(Required=false)]
        public string ApplicationCustomRuleId { get; set; }

        /// <summary>
        /// <para>The name of the custom rule. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Custom rule</para>
        /// </summary>
        [NameInMap("ApplicationCustomRuleName")]
        [Validation(Required=false)]
        public string ApplicationCustomRuleName { get; set; }

        /// <summary>
        /// <para>The ID of the application. This parameter is used to filter custom rules associated with the application. The application must exist in the built-in application signature library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10012150000</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// <para>The ID of the application template to query. This parameter is required. The template must exist within the current Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ati-4f0691c56b8d4f06</para>
        /// </summary>
        [NameInMap("ApplicationTemplateId")]
        [Validation(Required=false)]
        public string ApplicationTemplateId { get; set; }

        /// <summary>
        /// <para>The language of the returned information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese. This is the default value.</description></item>
        /// <item><description><b>en</b>: English.
        /// This parameter determines whether the returned application names are in Chinese or English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: integers greater than or equal to 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: integers greater than or equal to 1. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The priority of the rule. Exact match is supported. Valid values: integers from 1 to 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// <para>The action of the rule. Exact match is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Allow</b>: allows the traffic.</description></item>
        /// <item><description><b>Alert</b>: monitors the traffic.</description></item>
        /// <item><description><b>Deny</b>: blocks the traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Deny</para>
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public string RuleAction { get; set; }

    }

}
