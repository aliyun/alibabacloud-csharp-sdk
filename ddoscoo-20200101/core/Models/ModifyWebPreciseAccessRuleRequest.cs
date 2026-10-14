// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebPreciseAccessRuleRequest : TeaModel {
        /// <summary>
        /// <para>The domain of the website.</para>
        /// <remarks>
        /// <para>You must configure a forwarding rule for the domain. You can call the <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> operation to query all domains.</para>
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
        /// <para>The validity period of the rule, in seconds. This parameter applies only when <b>action</b> is set to <b>block</b>. Requests that match the rule are blocked for the specified duration. If you do not specify this parameter, the rule is permanently effective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("Expires")]
        [Validation(Required=false)]
        public int? Expires { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Pro instance belongs. If you do not specify this parameter, the instance belongs to the default resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The configuration of the precise access control rule, specified as a JSON-formatted string. The string has the following structure:</para>
        /// <list type="bullet">
        /// <item><description><para><b>action</b>: String. Required. The action to perform on matching requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>accept</b>: Allows the request.</para>
        /// </description></item>
        /// <item><description><para><b>block</b>: Blocks the request.</para>
        /// </description></item>
        /// <item><description><para><b>challenge</b>: Initiates a challenge to verify the request.</para>
        /// </description></item>
        /// <item><description><para><b>watch</b>: Monitors the request.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>name</b>: String. Required. The name of the rule.</para>
        /// </description></item>
        /// <item><description><para><b>condition</b>: Map. Required. The match conditions. The structure is as follows:</para>
        /// <remarks>
        /// <para>If you specify multiple match conditions, they are evaluated with a logical AND.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para><b>field</b>: String. Required. The match field.</para>
        /// </description></item>
        /// <item><description><para><b>match_method</b>: String. Required. The match method.</para>
        /// <remarks>
        /// <para>For information about the valid values for <b>field</b> and <b>match_method</b>, see the &quot;Additional information about request parameters&quot; section.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>content</b>: String. The value to match. You can specify either this parameter or <c>content_list</c>.</para>
        /// </description></item>
        /// <item><description><para><b>content_list</b>: String. A list of values to match. You can specify either this parameter or <c>content</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For information about the valid values for <b>match_method</b> and <b>content/content_list</b>, see the &quot;Additional information about request parameters&quot; section.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>header_name</b>: String. Optional. The name of the request header. This parameter applies only when <b>field</b> is set to <b>header</b>.</para>
        /// </description></item>
        /// <item><description><para><b>case_insensitive</b>: Boolean. Optional. The default value is false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: case-sensitive</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: case-insensitive</para>
        /// </description></item>
        /// </list>
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
