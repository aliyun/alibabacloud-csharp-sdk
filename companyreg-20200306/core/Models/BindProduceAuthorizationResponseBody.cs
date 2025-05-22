// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class BindProduceAuthorizationResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BindProduceAuthorizationResponseBodyData Data { get; set; }
        public class BindProduceAuthorizationResponseBodyData : TeaModel {
            [NameInMap("AuthorizedUserList")]
            [Validation(Required=false)]
            public List<BindProduceAuthorizationResponseBodyDataAuthorizedUserList> AuthorizedUserList { get; set; }
            public class BindProduceAuthorizationResponseBodyDataAuthorizedUserList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("AccountValidType")]
                [Validation(Required=false)]
                public int? AccountValidType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1219541161213058</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:test@alibaba-inc.com">test@alibaba-inc.com</a></para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AC492C5D-29D0-5103-9271-2C3A9D99F5CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
