// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeContainerFieldStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistical information about containers.</para>
        /// </summary>
        [NameInMap("ContainerGroupedFields")]
        [Validation(Required=false)]
        public DescribeContainerFieldStatisticsResponseBodyContainerGroupedFields ContainerGroupedFields { get; set; }
        public class DescribeContainerFieldStatisticsResponseBodyContainerGroupedFields : TeaModel {
            /// <summary>
            /// <para>The number of applications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AppCount")]
            [Validation(Required=false)]
            public int? AppCount { get; set; }

            /// <summary>
            /// <para>The number of clusters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ClusterCount")]
            [Validation(Required=false)]
            public int? ClusterCount { get; set; }

            /// <summary>
            /// <para>The number of containers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ContainerCount")]
            [Validation(Required=false)]
            public int? ContainerCount { get; set; }

            /// <summary>
            /// <para>The number of images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ImageCount")]
            [Validation(Required=false)]
            public int? ImageCount { get; set; }

            /// <summary>
            /// <para>The number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public int? InstanceCount { get; set; }

            /// <summary>
            /// <para>The number of namespaces.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("NamespaceCount")]
            [Validation(Required=false)]
            public int? NamespaceCount { get; set; }

            /// <summary>
            /// <para>The number of pods.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PodCount")]
            [Validation(Required=false)]
            public int? PodCount { get; set; }

            /// <summary>
            /// <para>The number of the applications on which risks are detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskAppCount")]
            [Validation(Required=false)]
            public int? RiskAppCount { get; set; }

            /// <summary>
            /// <para>The number of the clusters on which risks are detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskClusterCount")]
            [Validation(Required=false)]
            public int? RiskClusterCount { get; set; }

            /// <summary>
            /// <para>The number of the containers on which risks are detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskContainerCount")]
            [Validation(Required=false)]
            public int? RiskContainerCount { get; set; }

            /// <summary>
            /// <para>The number of the images on which risks are detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskImageCount")]
            [Validation(Required=false)]
            public int? RiskImageCount { get; set; }

            /// <summary>
            /// <para>The number of the instances on which risks are detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RiskInstanceCount")]
            [Validation(Required=false)]
            public int? RiskInstanceCount { get; set; }

            /// <summary>
            /// <para>The number of the pods on which risks are detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RiskPodCount")]
            [Validation(Required=false)]
            public int? RiskPodCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8B6F758-BCD4-597A-8A2C-DA5A552C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
