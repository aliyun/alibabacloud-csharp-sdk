// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DeepCopyRuleRequest : TeaModel {
        /// <summary>
        /// <para>Creation type</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("CreateType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        /// <summary>
        /// <para>Newly added cumulative variable</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;id&quot;:&quot;1288&quot;,&quot;title&quot;:&quot;新标题&quot;}]</para>
        /// </summary>
        [NameInMap("CustInsertInfo")]
        [Validation(Required=false)]
        public string CustInsertInfo { get; set; }

        /// <summary>
        /// <para>Read cumulative variable</para>
        /// 
        /// <b>Example:</b>
        /// <para>[1234，2345]</para>
        /// </summary>
        [NameInMap("CustWriteInfo")]
        [Validation(Required=false)]
        public string CustWriteInfo { get; set; }

        /// <summary>
        /// <para>Custom variables to be added</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;id&quot;:&quot;ex_2wxZPcxg3a03&quot;,&quot;title&quot;:&quot;新标题&quot;}]</para>
        /// </summary>
        [NameInMap("ExpressionVariableInfo")]
        [Validation(Required=false)]
        public string ExpressionVariableInfo { get; set; }

        /// <summary>
        /// <para>Sets the language type for requests and received messages, with a default value of <b>zh</b>. Values: </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Custom query variables to be added</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;id&quot;:&quot;ex_2wxZPcxg3a03&quot;,&quot;title&quot;:&quot;新标题&quot;}]</para>
        /// </summary>
        [NameInMap("QueryExpressionVariableInfo")]
        [Validation(Required=false)]
        public string QueryExpressionVariableInfo { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Source policy ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>102125</para>
        /// </summary>
        [NameInMap("SourceRuleId")]
        [Validation(Required=false)]
        public string SourceRuleId { get; set; }

        /// <summary>
        /// <para>Target policy ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>102125,102129</para>
        /// </summary>
        [NameInMap("SourceRuleIds")]
        [Validation(Required=false)]
        public string SourceRuleIds { get; set; }

        /// <summary>
        /// <para>Target event</para>
        /// 
        /// <b>Example:</b>
        /// <para>de_ajtshf1581</para>
        /// </summary>
        [NameInMap("TargetEventCode")]
        [Validation(Required=false)]
        public string TargetEventCode { get; set; }

        /// <summary>
        /// <para>Target event name</para>
        /// 
        /// <b>Example:</b>
        /// <para>目标事件名称</para>
        /// </summary>
        [NameInMap("TargetEventName")]
        [Validation(Required=false)]
        public string TargetEventName { get; set; }

    }

}
