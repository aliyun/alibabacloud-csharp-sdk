// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class BeeBotAssociateResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// If OK is returned, the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BeeBotAssociateResponseBodyData Data { get; set; }
        public class BeeBotAssociateResponseBodyData : TeaModel {
            /// <summary>
            /// The list of associated recommendations.
            /// </summary>
            [NameInMap("Associate")]
            [Validation(Required=false)]
            public List<BeeBotAssociateResponseBodyDataAssociate> Associate { get; set; }
            public class BeeBotAssociateResponseBodyDataAssociate : TeaModel {
                /// <summary>
                /// The additional information.
                /// </summary>
                [NameInMap("Meta")]
                [Validation(Required=false)]
                public string Meta { get; set; }

                /// <summary>
                /// The title of the associated question.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// The ID of the response message.
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// The ID of the session.
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
