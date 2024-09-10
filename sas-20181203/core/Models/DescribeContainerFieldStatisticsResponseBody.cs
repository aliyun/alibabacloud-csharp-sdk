// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerFieldStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The statistical information about containers.
        /// </summary>
        [NameInMap("ContainerGroupedFields")]
        [Validation(Required=false)]
        public DescribeContainerFieldStatisticsResponseBodyContainerGroupedFields ContainerGroupedFields { get; set; }
        public class DescribeContainerFieldStatisticsResponseBodyContainerGroupedFields : TeaModel {
            /// <summary>
            /// The number of applications.
            /// </summary>
            [NameInMap("AppCount")]
            [Validation(Required=false)]
            public int? AppCount { get; set; }

            /// <summary>
            /// The number of clusters.
            /// </summary>
            [NameInMap("ClusterCount")]
            [Validation(Required=false)]
            public int? ClusterCount { get; set; }

            /// <summary>
            /// The number of containers.
            /// </summary>
            [NameInMap("ContainerCount")]
            [Validation(Required=false)]
            public int? ContainerCount { get; set; }

            /// <summary>
            /// The number of images.
            /// </summary>
            [NameInMap("ImageCount")]
            [Validation(Required=false)]
            public int? ImageCount { get; set; }

            /// <summary>
            /// The number of instances.
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// The number of namespaces.
            /// </summary>
            [NameInMap("NamespaceCount")]
            [Validation(Required=false)]
            public int? NamespaceCount { get; set; }

            /// <summary>
            /// The number of pods.
            /// </summary>
            [NameInMap("PodCount")]
            [Validation(Required=false)]
            public int? PodCount { get; set; }

            /// <summary>
            /// The number of the applications on which risks are detected.
            /// </summary>
            [NameInMap("RiskAppCount")]
            [Validation(Required=false)]
            public int? RiskAppCount { get; set; }

            /// <summary>
            /// The number of the clusters on which risks are detected.
            /// </summary>
            [NameInMap("RiskClusterCount")]
            [Validation(Required=false)]
            public int? RiskClusterCount { get; set; }

            /// <summary>
            /// The number of the containers on which risks are detected.
            /// </summary>
            [NameInMap("RiskContainerCount")]
            [Validation(Required=false)]
            public int? RiskContainerCount { get; set; }

            /// <summary>
            /// The number of the images on which risks are detected.
            /// </summary>
            [NameInMap("RiskImageCount")]
            [Validation(Required=false)]
            public int? RiskImageCount { get; set; }

            /// <summary>
            /// The number of the instances on which risks are detected.
            /// </summary>
            [NameInMap("RiskInstanceCount")]
            [Validation(Required=false)]
            public int? RiskInstanceCount { get; set; }

            /// <summary>
            /// The number of the pods on which risks are detected.
            /// </summary>
            [NameInMap("RiskPodCount")]
            [Validation(Required=false)]
            public int? RiskPodCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
