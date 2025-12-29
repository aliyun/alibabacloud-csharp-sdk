// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class ListContactsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListContactsResponseBodyData> Data { get; set; }
        public class ListContactsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx @alibaba-inc.com</para>
            /// </summary>
            [NameInMap("ContactEmail")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public long? ContactId { get; set; }

            [NameInMap("ContactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19211111111</para>
            /// </summary>
            [NameInMap("ContactPhone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MailStatus")]
            [Validation(Required=false)]
            public int? MailStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Main")]
            [Validation(Required=false)]
            public int? Main { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OpenStatusWarning")]
            [Validation(Required=false)]
            public bool? OpenStatusWarning { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OpentAttributionWarning")]
            [Validation(Required=false)]
            public bool? OpentAttributionWarning { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PhoneStatus")]
            [Validation(Required=false)]
            public int? PhoneStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CC3BB6D2-2FDF-4321-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
