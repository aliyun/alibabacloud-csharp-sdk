// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceApplicationResponseBody : TeaModel {
        /// <summary>
        /// The details of the application.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataServiceApplicationResponseBodyData Data { get; set; }
        public class GetDataServiceApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// The AppCode for simple authentication. You can select simple authentication or signature authentication when you call an API operation.
            /// </summary>
            [NameInMap("ApplicationCode")]
            [Validation(Required=false)]
            public string ApplicationCode { get; set; }

            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public long? ApplicationId { get; set; }

            /// <summary>
            /// The AppKey for signature authentication. You can select simple authentication or signature authentication when you call an API operation.
            /// </summary>
            [NameInMap("ApplicationKey")]
            [Validation(Required=false)]
            public string ApplicationKey { get; set; }

            /// <summary>
            /// The name of the application.
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// The AppSecret for signature authentication. You can select simple authentication or signature authentication when you call an API operation.
            /// </summary>
            [NameInMap("ApplicationSecret")]
            [Validation(Required=false)]
            public string ApplicationSecret { get; set; }

            /// <summary>
            /// The ID of the workspace.
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
