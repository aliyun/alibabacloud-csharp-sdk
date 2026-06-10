// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CreateAlertDestinationRequest : TeaModel {
        /// <summary>
        /// <para>Alert contact name</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_name</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Configuration parameters for the alert contact</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public CreateAlertDestinationRequestParams Params { get; set; }
        public class CreateAlertDestinationRequestParams : TeaModel {
            /// <summary>
            /// <para>Email</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:xxx@email.com">xxx@email.com</a></para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Phone number</para>
            /// 
            /// <b>Example:</b>
            /// <para>1xxx</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>Robot key</para>
            /// 
            /// <b>Example:</b>
            /// <para>SECxxx</para>
            /// </summary>
            [NameInMap("sec")]
            [Validation(Required=false)]
            public string Sec { get; set; }

            /// <summary>
            /// <para>Robot link</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oapi.dingtalk.com/robot/send?access_token=xxx">https://oapi.dingtalk.com/robot/send?access_token=xxx</a></para>
            /// </summary>
            [NameInMap("webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        /// <summary>
        /// <para>Configuration source</para>
        /// 
        /// <b>Example:</b>
        /// <para>console</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>Push Target. Currently, only DingTalk Robot is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}
