// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListThingModelVersionResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListThingModelVersionResponseBodyData Data { get; set; }
        public class ListThingModelVersionResponseBodyData : TeaModel {
            /// <summary>
            /// The list of TSL model versions. The versions are displayed in descending order based on the release time. The first version is the current version.
            /// </summary>
            [NameInMap("ModelVersions")]
            [Validation(Required=false)]
            public List<ListThingModelVersionResponseBodyDataModelVersions> ModelVersions { get; set; }
            public class ListThingModelVersionResponseBodyDataModelVersions : TeaModel {
                /// <summary>
                /// The description of the TSL model version.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The timestamp when the TSL model version was published. The time is displayed in UTC. Unit: milliseconds.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// The version number of the TSL model.
                /// </summary>
                [NameInMap("ModelVersion")]
                [Validation(Required=false)]
                public string ModelVersion { get; set; }

            }

        }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
