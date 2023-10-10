// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetJavaStartUpConfigResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The configuration of Java startup parameters.
        /// </summary>
        [NameInMap("JavaStartUpConfig")]
        [Validation(Required=false)]
        public GetJavaStartUpConfigResponseBodyJavaStartUpConfig JavaStartUpConfig { get; set; }
        public class GetJavaStartUpConfigResponseBodyJavaStartUpConfig : TeaModel {
            /// <summary>
            /// The displayed startup parameter configuration.
            /// </summary>
            [NameInMap("OriginalConfigs")]
            [Validation(Required=false)]
            public string OriginalConfigs { get; set; }

            /// <summary>
            /// The effective startup parameter configuration.
            /// </summary>
            [NameInMap("StartUpArgs")]
            [Validation(Required=false)]
            public string StartUpArgs { get; set; }

        }

        /// <summary>
        /// The message that is returned.
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
