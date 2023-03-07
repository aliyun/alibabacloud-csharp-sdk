// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeContainerAppResponseBody : TeaModel {
        /// <summary>
        /// The information of the containerized application.
        /// </summary>
        [NameInMap("ContainerAppInfo")]
        [Validation(Required=false)]
        public DescribeContainerAppResponseBodyContainerAppInfo ContainerAppInfo { get; set; }
        public class DescribeContainerAppResponseBodyContainerAppInfo : TeaModel {
            /// <summary>
            /// The time when the containerized application was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the containerized application.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the containerized application.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The tags of the image.
            /// </summary>
            [NameInMap("ImageTag")]
            [Validation(Required=false)]
            public string ImageTag { get; set; }

            /// <summary>
            /// The name of the containerized application.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The name of the repository.
            /// </summary>
            [NameInMap("Repository")]
            [Validation(Required=false)]
            public string Repository { get; set; }

            /// <summary>
            /// The type of the container. Set the value to singularity.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
