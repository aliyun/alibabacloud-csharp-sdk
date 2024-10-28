// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListContainerImagesResponseBody : TeaModel {
        [NameInMap("ContainerImages")]
        [Validation(Required=false)]
        public List<ListContainerImagesResponseBodyContainerImages> ContainerImages { get; set; }
        public class ListContainerImagesResponseBodyContainerImages : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>a suite of programs for interacting with high-throughput sequencing data.</para>
            /// </summary>
            [NameInMap("ContainerImageDescription")]
            [Validation(Required=false)]
            public string ContainerImageDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>samtools</para>
            /// </summary>
            [NameInMap("ContainerImageName")]
            [Validation(Required=false)]
            public string ContainerImageName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>samtools</para>
            /// </summary>
            [NameInMap("ContainerImageNamespace")]
            [Validation(Required=false)]
            public string ContainerImageNamespace { get; set; }

            [NameInMap("ContainerImageVersions")]
            [Validation(Required=false)]
            public List<string> ContainerImageVersions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-shenzhen.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ContainerRegistry")]
            [Validation(Required=false)]
            public string ContainerRegistry { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yyyy/MM/dd HH:mm:ss</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>easygene.cn-beijing.aliyuncs.com</para>
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ba6d88e2-a6f2-4d2c-a2ae-68b76b078445</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DA980AD0-158F-44F3-847D-5EAB96C0EB6B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
