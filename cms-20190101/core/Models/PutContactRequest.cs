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
            /// <para>旺旺联系人。</para>
            /// <para>&lt;props=&quot;china&quot;&gt;手机号码、邮箱、钉钉机器人和旺旺最少添加一种联系方式。
            /// &lt;props=&quot;intl&quot;&gt;邮箱和钉钉机器人最少添加一种联系方式。
            /// &lt;props=&quot;partner&quot;&gt;邮箱和钉钉机器人最少添加一种联系方式。</para>
            /// 
            /// <b>Example:</b>
            /// <para>Jim</para>
            /// </summary>
            [NameInMap("AliIM")]
            [Validation(Required=false)]
            public string AliIM { get; set; }

            /// <summary>
            /// <para>钉钉机器人。</para>
            /// <para>&lt;props=&quot;china&quot;&gt;手机号码、邮箱、钉钉机器人和旺旺最少添加一种联系方式。
            /// &lt;props=&quot;intl&quot;&gt;邮箱和钉钉机器人最少添加一种联系方式。
            /// &lt;props=&quot;partner&quot;&gt;邮箱和钉钉机器人最少添加一种联系方式。</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=7d49515e8ebf21106a80a9cc4bb3d247771305d52fb15d6201234565">https://oapi.dingtalk.com/robot/send?access_token=7d49515e8ebf21106a80a9cc4bb3d247771305d52fb15d6201234565</a>****</para>
            /// </summary>
            [NameInMap("DingWebHook")]
            [Validation(Required=false)]
            public string DingWebHook { get; set; }

            /// <summary>
            /// <para>Email地址。Email会收到一个激活链接， 激活之后您才会被加入到联系人中。</para>
            /// <para>&lt;props=&quot;china&quot;&gt;手机号码、邮箱、钉钉机器人和旺旺最少添加一种联系方式。
            /// &lt;props=&quot;intl&quot;&gt;邮箱和钉钉机器人最少添加一种联系方式。
            /// &lt;props=&quot;partner&quot;&gt;邮箱和钉钉机器人最少添加一种联系方式。</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
            /// </summary>
            [NameInMap("Mail")]
            [Validation(Required=false)]
            public string Mail { get; set; }

            /// <summary>
            /// <para>手机号码。手机号码会收到一个激活链接， 激活之后您才会被加入到联系人中。</para>
            /// <para>&lt;props=&quot;china&quot;&gt;手机号码、邮箱、钉钉机器人和旺旺最少添加一种联系方式。
            /// &lt;props=&quot;intl&quot;&gt;邮箱和钉钉机器人最少添加一种联系方式。
            /// &lt;props=&quot;partner&quot;&gt;邮箱和钉钉机器人最少添加一种联系方式。</para>
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
        /// <para>The language in which alert notifications are sent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-cn: simplified Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, the language is automatically determined based on the region of the account.</para>
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
