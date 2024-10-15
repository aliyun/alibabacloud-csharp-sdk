// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ExternalUserQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public ExternalUserQueryResponseBodyModule Module { get; set; }
        public class ExternalUserQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2000-01-02</para>
            /// </summary>
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>btrip123456</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:zhangsan@alibaba-inc.com">zhangsan@alibaba-inc.com</a></para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>000001</para>
            /// </summary>
            [NameInMap("external_user_id")]
            [Validation(Required=false)]
            public string ExternalUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13438009765</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("real_name")]
            [Validation(Required=false)]
            public string RealName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zhang/san</para>
            /// </summary>
            [NameInMap("real_name_en")]
            [Validation(Required=false)]
            public string RealNameEn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e1$12345678</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("user_nick")]
            [Validation(Required=false)]
            public string UserNick { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("user_type")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>210e847f16611516748613869de4f6</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
