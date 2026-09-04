// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Notifications20241225.Models
{
    public class ReadAllCommonContactsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ReadAllCommonContactsResponseBodyData> Data { get; set; }
        public class ReadAllCommonContactsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The email address of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t*@qq.*</para>
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
            /// <para>130**123</para>
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
            /// <para>Indicates whether the email address is verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EmailConfirmed")]
            [Validation(Required=false)]
            public bool? EmailConfirmed { get; set; }

            /// <summary>
            /// <para>Indicates whether the mobile phone number of the contact in the Account Center is verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MobileConfirmed")]
            [Validation(Required=false)]
            public bool? MobileConfirmed { get; set; }

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
        /// <para>The result message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>73FD6AE8-898F-5D09-9763-69B8A875488A</para>
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
