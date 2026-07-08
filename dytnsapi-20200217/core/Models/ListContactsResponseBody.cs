// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class ListContactsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. <c>OK</c> indicates a successful request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>An array of contact information objects.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListContactsResponseBodyData> Data { get; set; }
        public class ListContactsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The contact email.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx @alibaba-inc.com</para>
            /// </summary>
            [NameInMap("ContactEmail")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            /// <summary>
            /// <para>The contact ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public long? ContactId { get; set; }

            /// <summary>
            /// <para>The contact name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>黄勇</para>
            /// </summary>
            [NameInMap("ContactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <para>The contact mobile number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19211111111</para>
            /// </summary>
            [NameInMap("ContactPhone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

            /// <summary>
            /// <para>The email status.</para>
            /// <list type="bullet">
            /// <item><description><para>1: Normal</para>
            /// </description></item>
            /// <item><description><para>0: Abnormal</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MailStatus")]
            [Validation(Required=false)]
            public int? MailStatus { get; set; }

            /// <summary>
            /// <para>The calling number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Main")]
            [Validation(Required=false)]
            public int? Main { get; set; }

            /// <summary>
            /// <para>Specifies whether the number status warning is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OpenStatusWarning")]
            [Validation(Required=false)]
            public bool? OpenStatusWarning { get; set; }

            /// <summary>
            /// <para>Specifies whether the number attribution query warning is enabled.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OpentAttributionWarning")]
            [Validation(Required=false)]
            public bool? OpentAttributionWarning { get; set; }

            /// <summary>
            /// <para>The number status.</para>
            /// <list type="bullet">
            /// <item><description><para>1: Normal</para>
            /// </description></item>
            /// <item><description><para>0: Abnormal</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PhoneStatus")]
            [Validation(Required=false)]
            public int? PhoneStatus { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC3BB6D2-2FDF-4321-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
