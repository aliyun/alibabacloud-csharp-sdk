// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class CreateFpShotDBResponseBody : TeaModel {
        /// <summary>
        /// The details of the media fingerprint library.
        /// </summary>
        [NameInMap("FpShotDB")]
        [Validation(Required=false)]
        public CreateFpShotDBResponseBodyFpShotDB FpShotDB { get; set; }
        public class CreateFpShotDBResponseBodyFpShotDB : TeaModel {
            /// <summary>
            /// The configurations of the media fingerprint library.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// The description of the media fingerprint library.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the media fingerprint library. We recommend that you keep this ID for subsequent operation calls.
            /// </summary>
            [NameInMap("FpDBId")]
            [Validation(Required=false)]
            public string FpDBId { get; set; }

            /// <summary>
            /// The model ID of the media fingerprint library.
            /// </summary>
            [NameInMap("ModelId")]
            [Validation(Required=false)]
            public int? ModelId { get; set; }

            /// <summary>
            /// The name of the media fingerprint library.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The status of the media fingerprint library. After the media fingerprint library is created, it enters the **offline** state. After the media fingerprint library is processed at the backend, it enters the **active** state.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
