// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class InspectImageResponseBody : TeaModel {
        /// <summary>
        /// The status of the image.
        /// </summary>
        [NameInMap("ImageStatus")]
        [Validation(Required=false)]
        public InspectImageResponseBodyImageStatus ImageStatus { get; set; }
        public class InspectImageResponseBodyImageStatus : TeaModel {
            /// <summary>
            /// The list of Inspect information about the image.
            /// </summary>
            [NameInMap("ImageInspectInfo")]
            [Validation(Required=false)]
            public InspectImageResponseBodyImageStatusImageInspectInfo ImageInspectInfo { get; set; }
            public class InspectImageResponseBodyImageStatusImageInspectInfo : TeaModel {
                /// <summary>
                /// The version of the bootstrapper used by the container image.
                /// </summary>
                [NameInMap("BootStrap")]
                [Validation(Required=false)]
                public string BootStrap { get; set; }

                /// <summary>
                /// The architecture used to build the image.
                /// </summary>
                [NameInMap("BuildArch")]
                [Validation(Required=false)]
                public string BuildArch { get; set; }

                /// <summary>
                /// The date on which the image was built.
                /// </summary>
                [NameInMap("BuildDate")]
                [Validation(Required=false)]
                public string BuildDate { get; set; }

                /// <summary>
                /// The container version of the image.
                /// </summary>
                [NameInMap("ContainerVersion")]
                [Validation(Required=false)]
                public string ContainerVersion { get; set; }

                /// <summary>
                /// The mode in which the image was built.
                /// </summary>
                [NameInMap("DefFrom")]
                [Validation(Required=false)]
                public string DefFrom { get; set; }

                /// <summary>
                /// The singularity version and kernel version of the image.
                /// </summary>
                [NameInMap("SchemaVersion")]
                [Validation(Required=false)]
                public string SchemaVersion { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
