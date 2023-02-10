// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class QueryPhoneBusinessProfileResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// 
        /// *   A value of OK indicates that the call is successful.
        /// *   Other values indicate that the call fails. For more information, see [Error codes](~~196974~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPhoneBusinessProfileResponseBodyData Data { get; set; }
        public class QueryPhoneBusinessProfileResponseBodyData : TeaModel {
            /// <summary>
            /// The address.
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The email address.
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// The URL of the profile picture.
            /// </summary>
            [NameInMap("ProfilePictureUrl")]
            [Validation(Required=false)]
            public string ProfilePictureUrl { get; set; }

            /// <summary>
            /// The industry.
            /// </summary>
            [NameInMap("Vertical")]
            [Validation(Required=false)]
            public string Vertical { get; set; }

            /// <summary>
            /// The websites.
            /// </summary>
            [NameInMap("Websites")]
            [Validation(Required=false)]
            public List<string> Websites { get; set; }

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
