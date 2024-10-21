// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class ListEmailVerificationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEmailVerificationResponseBodyData> Data { get; set; }
        public class ListEmailVerificationResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("ConfirmIp")]
            [Validation(Required=false)]
            public string ConfirmIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>00000a21fd374da99d9c95b48500000</para>
            /// </summary>
            [NameInMap("EmailVerificationNo")]
            [Validation(Required=false)]
            public string EmailVerificationNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-12-25 03:38:46</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-12-25 03:41:11</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("SendIp")]
            [Validation(Required=false)]
            public string SendIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-12-25 03:38:46</para>
            /// </summary>
            [NameInMap("TokenSendTime")]
            [Validation(Required=false)]
            public string TokenSendTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0000</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VerificationStatus")]
            [Validation(Required=false)]
            public int? VerificationStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2017-12-25 03:41:11</para>
            /// </summary>
            [NameInMap("VerificationTime")]
            [Validation(Required=false)]
            public string VerificationTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public bool? NextPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrePage")]
        [Validation(Required=false)]
        public bool? PrePage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>78C60CC3-FF0A-44E2-989A-DDE0597791C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
