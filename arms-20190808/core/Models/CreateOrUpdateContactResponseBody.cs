// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateContactResponseBody : TeaModel {
        /// <summary>
        /// <para>The object of the alert contact.</para>
        /// </summary>
        [NameInMap("AlertContact")]
        [Validation(Required=false)]
        public CreateOrUpdateContactResponseBodyAlertContact AlertContact { get; set; }
        public class CreateOrUpdateContactResponseBodyAlertContact : TeaModel {
            /// <summary>
            /// <para>The ID of the alert contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public float? ContactId { get; set; }

            /// <summary>
            /// <para>The name of the alert contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JohnDoe</para>
            /// </summary>
            [NameInMap("ContactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>The webhook URL of the DingTalk chatbot.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://test1.com">https://test1.com</a></para>
            /// </summary>
            [NameInMap("DingRobotUrl")]
            [Validation(Required=false)]
            public string DingRobotUrl { get; set; }

            /// <summary>
            /// <para>The email address of the alert contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:someone@example.com">someone@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Indicates whether the mobile number was verified. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>false</c> (default value): No</description></item>
            /// <item><description><c>true</c>: Yes</description></item>
            /// </list>
            /// <para>You can call the <b>SendTTSVerifyLink</b> operation to verify the mobile number of an alert contact. Only verified mobile numbers can be specified in a notification policy to receive phone calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsVerify")]
            [Validation(Required=false)]
            public bool? IsVerify { get; set; }

            /// <summary>
            /// <para>The mobile number of the alert contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1381111****</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The operation that you want to perform if phone calls fail to be answered. Valid values: 0: No operation is performed. 1: A phone call is made again. 2: A text message is sent. 3 (default value): The global default value is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ReissueSendNotice")]
            [Validation(Required=false)]
            public long? ReissueSendNotice { get; set; }

            /// <summary>
            /// <para>Indicates whether the email address was verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isEmailVerify")]
            [Validation(Required=false)]
            public bool? IsEmailVerify { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9C9DA3D-10FE-472E-9EEF-2D0A3E41****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
