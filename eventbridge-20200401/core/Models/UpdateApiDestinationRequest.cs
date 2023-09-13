// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateApiDestinationRequest : TeaModel {
        /// <summary>
        /// The name of the API destination. The name must be 2 to 127 characters in length.
        /// </summary>
        [NameInMap("ApiDestinationName")]
        [Validation(Required=false)]
        public string ApiDestinationName { get; set; }

        /// <summary>
        /// The name of the connection. The name must be 2 to 127 characters in length.
        /// 
        /// Note: Before you configure this parameter, you must call the CreateConnection operation to create a connection. Then, set this parameter to the name of the connection that you created.
        /// </summary>
        [NameInMap("ConnectionName")]
        [Validation(Required=false)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// The description of the API destination. The description can be up to 255 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The parameters that are configured for the API destination.
        /// </summary>
        [NameInMap("HttpApiParameters")]
        [Validation(Required=false)]
        public UpdateApiDestinationRequestHttpApiParameters HttpApiParameters { get; set; }
        public class UpdateApiDestinationRequestHttpApiParameters : TeaModel {
            /// <summary>
            /// The endpoint of the API destination. The endpoint can be up to 127 characters in length.
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// The HTTP request method. Valid values:
            /// 
            /// - GET
            /// - POST
            /// - HEAD
            /// - DELETE
            /// - PUT
            /// - PATCH
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

        }

    }

}
