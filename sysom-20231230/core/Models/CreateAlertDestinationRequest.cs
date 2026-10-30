// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CreateAlertDestinationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the IM bot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ab724ba952448eab4b5ed7ebe1d51ab</para>
        /// </summary>
        [NameInMap("app_id")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The secret key of the IM bot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cmxjamd2a2MwbzAweHgqZ2U4TH55RjNOP0RUOy8tVVo</para>
        /// </summary>
        [NameInMap("app_secret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

        /// <summary>
        /// <para>The ID of the group.</para>
        /// </summary>
        [NameInMap("group_id")]
        [Validation(Required=false)]
        public List<string> GroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether the IM bot is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("imbot")]
        [Validation(Required=false)]
        public bool? Imbot { get; set; }

        /// <summary>
        /// <para>The name of the alert contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configuration parameters of the alert contact.</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public CreateAlertDestinationRequestParams Params { get; set; }
        public class CreateAlertDestinationRequestParams : TeaModel {
            /// <summary>
            /// <para>The email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:xxx@email.com">xxx@email.com</a></para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1xxx</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The secret key of the bot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SECxxx</para>
            /// </summary>
            [NameInMap("sec")]
            [Validation(Required=false)]
            public string Sec { get; set; }

            /// <summary>
            /// <para>The webhook URL of the bot.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=xxx">https://oapi.dingtalk.com/robot/send?access_token=xxx</a></para>
            /// </summary>
            [NameInMap("webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        /// <summary>
        /// <para>The configuration source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>console</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The push target. Currently, only DingTalk bots are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}
