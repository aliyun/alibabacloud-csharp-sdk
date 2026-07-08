// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the protection rule.</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public DescribeDefenseRuleResponseBodyRule Rule { get; set; }
        public class DescribeDefenseRuleResponseBodyRule : TeaModel {
            /// <summary>
            /// <para>The configuration of the protection rule, returned as a JSON string. For more information, see the <b>Protection rule parameters</b> section in <a href="https://help.aliyun.com/document_detail/461421.html">CreateDefenseRule</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;status\&quot;:1,\&quot;policyId\&quot;:1012,\&quot;action\&quot;:\&quot;block\&quot;}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The origin of the protection rule. This parameter indicates whether the rule was created by the user or by the system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>custom</b>: a custom rule.</para>
            /// </description></item>
            /// <item><description><para><b>system</b>: a system-generated rule.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("DefenseOrigin")]
            [Validation(Required=false)]
            public string DefenseOrigin { get; set; }

            /// <summary>
            /// <para>The scenario to which the protection rule applies.</para>
            /// <para>If the <b>DefenseType</b> parameter is set to <b>template</b>, the valid values are:</para>
            /// <list type="bullet">
            /// <item><description><para><b>waf_group</b>: basic protection with regular expression rules.</para>
            /// </description></item>
            /// <item><description><para><b>waf_base</b>: web core protection.</para>
            /// </description></item>
            /// <item><description><para><b>waf_base_compliance</b>: basic protection with protocol compliance rules.</para>
            /// </description></item>
            /// <item><description><para><b>waf_base_sema</b>: basic protection with semantic analysis rules.</para>
            /// </description></item>
            /// <item><description><para><b>cc</b>: HTTP flood protection.</para>
            /// </description></item>
            /// <item><description><para><b>antiscan_dirscan</b>: directory traversal blocking in scan protection.</para>
            /// </description></item>
            /// <item><description><para><b>antiscan_highfreq</b>: high-frequency scan blocking in scan protection.</para>
            /// </description></item>
            /// <item><description><para><b>antiscan_scantools</b>: scanning tool blocking in scan protection.</para>
            /// </description></item>
            /// <item><description><para><b>ip_blacklist</b>: an IP address blacklist.</para>
            /// </description></item>
            /// <item><description><para><b>custom_acl</b>: a custom rule.</para>
            /// </description></item>
            /// <item><description><para><b>region_block</b>: a location blacklist.</para>
            /// </description></item>
            /// <item><description><para><b>tamperproof</b>: webpage tamper protection.</para>
            /// </description></item>
            /// <item><description><para><b>dlp</b>: data leakage prevention.</para>
            /// </description></item>
            /// <item><description><para><b>custom_response_block</b>: a custom response.</para>
            /// </description></item>
            /// <item><description><para><b>spike_throttle</b>: peak traffic throttling.</para>
            /// </description></item>
            /// </list>
            /// <para>If the <b>DefenseType</b> parameter is set to <b>resource</b>, the valid values are:</para>
            /// <list type="bullet">
            /// <item><description><para><b>account_identifier</b>: account identification.</para>
            /// </description></item>
            /// <item><description><para><b>custom_response</b>: a custom response.</para>
            /// </description></item>
            /// <item><description><para><b>waf_codec</b>: data decoding settings.</para>
            /// </description></item>
            /// </list>
            /// <para>If the <b>DefenseType</b> parameter is set to <b>global</b>, the valid values are:</para>
            /// <list type="bullet">
            /// <item><description><para><b>regular_custom</b>: a custom regular expression.</para>
            /// </description></item>
            /// <item><description><para><b>address_book</b>: an IP address book.</para>
            /// </description></item>
            /// <item><description><para><b>custom_response</b>: a custom response.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>waf_group</para>
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// <para>The type of the protection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>template</b> (default): a protection rule template.</para>
            /// </description></item>
            /// <item><description><para><b>resource</b>: a rule for a protected object.</para>
            /// </description></item>
            /// <item><description><para><b>global</b>: a global rule.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>template</para>
            /// </summary>
            [NameInMap("DefenseType")]
            [Validation(Required=false)]
            public string DefenseType { get; set; }

            /// <summary>
            /// <para>The time when the protection rule was modified. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665196746000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The protected object to which the protection rule applies.</para>
            /// <remarks>
            /// <para>This parameter is returned only if the <b>DefenseType</b> parameter is set to <b>resource</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>rencs***-waf</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <para>The ID of the protection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2732975</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The name of the protection rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The status of the protection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: disabled.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The ID of the protection rule template.</para>
            /// <remarks>
            /// <para>This parameter is returned only if the <b>DefenseType</b> parameter is set to <b>template</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>9114</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

    }

}
