// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class ReadAllMarketingPreferencesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned by the system. For more information about error codes, see error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The execution result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ReadAllMarketingPreferencesResponseBodyData> Data { get; set; }
        public class ReadAllMarketingPreferencesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether notifications are allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowMarketing")]
            [Validation(Required=false)]
            public bool? AllowMarketing { get; set; }

            /// <summary>
            /// <para>The email address of the contact in the Account Center (masked).</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@aliyun.com">test@aliyun.com</a></para>
            /// </summary>
            [NameInMap("ContactEmail")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            /// <summary>
            /// <para>The contact ID in the Account Center. A value of 0 indicates the account contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public long? ContactId { get; set; }

            /// <summary>
            /// <para>The mobile phone number of the contact in the Account Center (masked).</para>
            /// 
            /// <b>Example:</b>
            /// <para>130*123</para>
            /// </summary>
            [NameInMap("ContactMobile")]
            [Validation(Required=false)]
            public string ContactMobile { get; set; }

            /// <summary>
            /// <para>The contact name in the Account Center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ContactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>The position of the contact in the Account Center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CEO</para>
            /// </summary>
            [NameInMap("Position")]
            [Validation(Required=false)]
            public string Position { get; set; }

        }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5F62766-1C2F-1F56-A39D-63E3D30F0633</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
