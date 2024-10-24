// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebPreciseAccessRuleRequest : TeaModel {
        /// <summary>
        /// <para>The domain name of the website.</para>
        /// <remarks>
        /// <para>A forwarding rule must be configured for the domain name. You can call the <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> operation to query all domain names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The validity period of the rule. Unit: seconds. This parameter takes effect only when <b>action</b> of a rule is <b>block</b>. Access requests that match the rule are blocked within the specified validity period of the rule. If you do not specify this parameter, this rule takes effect all the time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("Expires")]
        [Validation(Required=false)]
        public int? Expires { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The settings of the accurate access control rule. This parameter is a JSON string. The following list describes the fields in the value of the parameter:</para>
        /// <list type="bullet">
        /// <item><description><para><b>action</b>: the action that is performed if the rule is matched. This field is required and must be of the string type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: allows the requests that match the rule.</description></item>
        /// <item><description><b>block</b>: blocks the requests that match the rule.</description></item>
        /// <item><description><b>challenge</b>: implements a CAPTCHA for the requests that match the rule.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>name</b>: the name of the rule. This field is required and must be of the string type.</para>
        /// </description></item>
        /// <item><description><para><b>condition</b>: the match conditions. This field is required and must be of the map type. A match condition contains the following parameters.</para>
        /// <para>**</para>
        /// <para><b>Note</b>The AND logical operator is used to define the relationship among multiple match conditions.</para>
        /// <list type="bullet">
        /// <item><description><para><b>field</b>: the match field. This parameter is required and must be of the string type.</para>
        /// </description></item>
        /// <item><description><para><b>match_method</b>: the logical relation. This parameter is required and must be of the string type.</para>
        /// <para>**</para>
        /// <para><b>Note</b>For information about the mappings between the <b>field</b> and <b>match_method</b> parameters, see the Mappings between the field and match_method parameters table in this topic.</para>
        /// </description></item>
        /// <item><description><para><b>content</b>: the match content. This parameter is required and must be of the string type.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>header_name</b>: the HTTP header. This parameter is optional and must be of the string type. This parameter takes effect only when <b>field</b> is <b>header</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;action&quot;:&quot;block&quot;,&quot;name&quot;:&quot;testrule&quot;,&quot;condition&quot;:[{&quot;field&quot;:&quot;uri&quot;,&quot;match_method&quot;:&quot;contain&quot;,&quot;content&quot;:&quot;/test/123&quot;}]}]</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

    }

}
