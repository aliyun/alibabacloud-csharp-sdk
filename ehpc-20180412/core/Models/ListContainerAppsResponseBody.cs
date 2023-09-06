// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListContainerAppsResponseBody : TeaModel {
        /// <summary>
        /// The array of containerized applications.
        /// </summary>
        [NameInMap("ContainerApps")]
        [Validation(Required=false)]
        public ListContainerAppsResponseBodyContainerApps ContainerApps { get; set; }
        public class ListContainerAppsResponseBodyContainerApps : TeaModel {
            [NameInMap("ContainerApps")]
            [Validation(Required=false)]
            public List<ListContainerAppsResponseBodyContainerAppsContainerApps> ContainerApps { get; set; }
            public class ListContainerAppsResponseBodyContainerAppsContainerApps : TeaModel {
                /// <summary>
                /// The time at which the containerized application was created.
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
                /// The ID of the container application.
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

        }

        /// <summary>
        /// The page number returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of containerized applications.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
