// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutContactRequest : TeaModel {
        [NameInMap("Channels")]
        [Validation(Required=false)]
        public PutContactRequestChannels Channels { get; set; }
        public class PutContactRequestChannels : TeaModel {
            /// <summary>
            /// <para>The TradeManager contact.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;You must specify at least one of the following contact methods: mobile phone number, email address, DingTalk chatbot, and TradeManager.
            /// &lt;props=&quot;intl&quot;&gt;You must specify at least one of the following contact methods: email address and DingTalk chatbot.
            /// &lt;props=&quot;partner&quot;&gt;You must specify at least one of the following contact methods: email address and DingTalk chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Jim</para>
            /// </summary>
            [NameInMap("AliIM")]
            [Validation(Required=false)]
            public string AliIM { get; set; }

            /// <summary>
            /// <para>The DingTalk chatbot.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;You must specify at least one of the following contact methods: mobile phone number, email address, DingTalk chatbot, and TradeManager.
            /// &lt;props=&quot;intl&quot;&gt;You must specify at least one of the following contact methods: email address and DingTalk chatbot.
            /// &lt;props=&quot;partner&quot;&gt;You must specify at least one of the following contact methods: email address and DingTalk chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=7d49515e8ebf21106a80a9cc4bb3d247771305d52fb15d6201234565">https://oapi.dingtalk.com/robot/send?access_token=7d49515e8ebf21106a80a9cc4bb3d247771305d52fb15d6201234565</a>****</para>
            /// </summary>
            [NameInMap("DingWebHook")]
            [Validation(Required=false)]
            public string DingWebHook { get; set; }

            /// <summary>
            /// <para>The email address. The email address receives an activation link. The contact is added only after the link is activated.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;You must specify at least one of the following contact methods: mobile phone number, email address, DingTalk chatbot, and TradeManager.
            /// &lt;props=&quot;intl&quot;&gt;You must specify at least one of the following contact methods: email address and DingTalk chatbot.
            /// &lt;props=&quot;partner&quot;&gt;You must specify at least one of the following contact methods: email address and DingTalk chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
            /// </summary>
            [NameInMap("Mail")]
            [Validation(Required=false)]
            public string Mail { get; set; }

            /// <summary>
            /// <para>The mobile phone number. The mobile phone number receives an activation link. The contact is added only after the link is activated.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;You must specify at least one of the following contact methods: mobile phone number, email address, DingTalk chatbot, and TradeManager.
            /// &lt;props=&quot;intl&quot;&gt;You must specify at least one of the following contact methods: email address and DingTalk chatbot.
            /// &lt;props=&quot;partner&quot;&gt;You must specify at least one of the following contact methods: email address and DingTalk chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1333333****</para>
            /// </summary>
            [NameInMap("SMS")]
            [Validation(Required=false)]
            public string SMS { get; set; }

        }

        /// <summary>
        /// <para>The name of the alert contact.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>The description of the alert contact.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Instance</para>
        /// </summary>
        [NameInMap("Describe")]
        [Validation(Required=false)]
        public string Describe { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The language of the alert notification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-cn: Simplified Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically determines the language based on the region of the account.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>zh-cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
