// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateEventRequest : TeaModel {
        /// <summary>
        /// <para>Sets the language type for requests and received messages, default value is <b>zh</b>. Values:</para>
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
        /// <para>Creation type</para>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("createType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        /// <summary>
        /// <para>Event name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>登录事件</para>
        /// </summary>
        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>Input parameters, JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;fieldCode&quot;:&quot;accountId&quot;,&quot;description&quot;:&quot;用户的账户ID，唯一标识一个账户的id&quot;,&quot;fieldRank&quot;:1,&quot;title&quot;:&quot;账户ID&quot;,&quot;fieldType&quot;:&quot;STRING&quot;,&quot;fieldSource&quot;:&quot;DEFAULT&quot;},{&quot;fieldCode&quot;:&quot;hitRules&quot;,&quot;fieldRank&quot;:2,&quot;title&quot;:&quot;命中策略&quot;,&quot;fieldType&quot;:&quot;STRING&quot;,&quot;fieldSource&quot;:&quot;DEFAULT&quot;},{&quot;fieldCode&quot;:&quot;age&quot;,&quot;description&quot;:&quot;&quot;,&quot;fieldRank&quot;:3,&quot;title&quot;:&quot;年龄&quot;,&quot;fieldType&quot;:&quot;INT&quot;,&quot;fieldSource&quot;:&quot;DEFAULT&quot;},{&quot;fieldCode&quot;:&quot;ip&quot;,&quot;description&quot;:&quot;IP地址&quot;,&quot;fieldRank&quot;:4,&quot;title&quot;:&quot;IP地址&quot;,&quot;fieldType&quot;:&quot;STRING&quot;,&quot;fieldSource&quot;:&quot;DEFAULT&quot;},{&quot;fieldCode&quot;:&quot;tags&quot;,&quot;fieldRank&quot;:5,&quot;title&quot;:&quot;风险标签&quot;,&quot;fieldType&quot;:&quot;STRING&quot;,&quot;fieldSource&quot;:&quot;DEFAULT&quot;},{&quot;fieldCode&quot;:&quot;score&quot;,&quot;fieldRank&quot;:6,&quot;title&quot;:&quot;风险分值&quot;,&quot;fieldType&quot;:&quot;DOUBLE&quot;,&quot;fieldSource&quot;:&quot;DEFAULT&quot;},{&quot;fieldCode&quot;:&quot;hitList&quot;,&quot;fieldRank&quot;:7}]</para>
        /// </summary>
        [NameInMap("inputFieldsStr")]
        [Validation(Required=false)]
        public string InputFieldsStr { get; set; }

        /// <summary>
        /// <para>Memo information</para>
        /// 
        /// <b>Example:</b>
        /// <para>登录事件描述</para>
        /// </summary>
        [NameInMap("memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Input field template type</para>
        /// 
        /// <b>Example:</b>
        /// <para>register</para>
        /// </summary>
        [NameInMap("templateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        /// <summary>
        /// <para>Published template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>注册事件模版</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>Template type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TASK</para>
        /// </summary>
        [NameInMap("templateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
