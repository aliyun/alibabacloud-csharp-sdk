// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateOrUpdateAutoTagRuleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to check the rule on the backend. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CheckAll")]
        [Validation(Required=false)]
        public bool? CheckAll { get; set; }

        /// <summary>
        /// <para>The expression of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;groups&quot;:&quot;0&quot;,&quot;fieldValueType&quot;:&quot;string&quot;,&quot;field&quot;:&quot;internetIp&quot;,&quot;operator&quot;:&quot;equals&quot;,&quot;value&quot;:&quot;12.0.0.1&quot;}]</para>
        /// </summary>
        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// <para>The description of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>describe</para>
        /// </summary>
        [NameInMap("RuleDesc")]
        [Validation(Required=false)]
        public string RuleDesc { get; set; }

        /// <summary>
        /// <para>The ID of the rule.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListAutoTagRules~~">ListAutoTagRules</a> operation to query the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>300566</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text-001</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The tag specified by the operation type of the rule.</para>
        /// <list type="bullet">
        /// <item><description>If TagType is set to group, set this parameter to {&quot;groupId&quot;:XXX}. XXX specifies the ID of the group. You can call the <a href="~~DescribeGroupStruct~~">DescribeGroupStruct</a> operation to query the ID.</description></item>
        /// <item><description>If TagType is set to tag, set this parameter to {&quot;tagId&quot;:XXX}. XXX specifies the ID of the tag. You can call the <a href="~~DescribeGroupedTags~~">DescribeGroupedTags</a> operation to query the ID.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;tagId&quot;:7804789}</para>
        /// </summary>
        [NameInMap("TagContext")]
        [Validation(Required=false)]
        public string TagContext { get; set; }

        /// <summary>
        /// <para>The operation type of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>group</b></description></item>
        /// <item><description><b>tag</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tag</para>
        /// </summary>
        [NameInMap("TagType")]
        [Validation(Required=false)]
        public string TagType { get; set; }

    }

}
