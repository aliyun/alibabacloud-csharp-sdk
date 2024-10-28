// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListAuthorizedSoftwareResponseBody : TeaModel {
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

        [NameInMap("Softwares")]
        [Validation(Required=false)]
        public List<ListAuthorizedSoftwareResponseBodySoftwares> Softwares { get; set; }
        public class ListAuthorizedSoftwareResponseBodySoftwares : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://help.aliyun.com/document_detail/257750.html">https://help.aliyun.com/document_detail/257750.html</a></para>
            /// </summary>
            [NameInMap("HelpLink")]
            [Validation(Required=false)]
            public string HelpLink { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yyyy/MM/dd HH:mm:ss</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            [NameInMap("Locations")]
            [Validation(Required=false)]
            public List<string> Locations { get; set; }

            [NameInMap("Promotion")]
            [Validation(Required=false)]
            public string Promotion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>201911</para>
            /// </summary>
            [NameInMap("SoftwareDefaultVersion")]
            [Validation(Required=false)]
            public string SoftwareDefaultVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NGS数据二级分析软件，提供基于CPU的加速方案，可替代BWA，GATK，HaplotypeCaller，Mutect和Mutect2等分析流程。包括DNASeq，DNAScope，TNScope等工具</para>
            /// </summary>
            [NameInMap("SoftwareDescription")]
            [Validation(Required=false)]
            public string SoftwareDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://img.alicdn.com/imgextra/i2/O1CN01mmZovA1UJfeKQAYvF_!!6000000002497-2-tps-256-256.png">https://img.alicdn.com/imgextra/i2/O1CN01mmZovA1UJfeKQAYvF_!!6000000002497-2-tps-256-256.png</a></para>
            /// </summary>
            [NameInMap("SoftwareIcon")]
            [Validation(Required=false)]
            public string SoftwareIcon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.15</para>
            /// </summary>
            [NameInMap("SoftwareLicenseFee")]
            [Validation(Required=false)]
            public float? SoftwareLicenseFee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Sentieon加速软件</para>
            /// </summary>
            [NameInMap("SoftwareLongName")]
            [Validation(Required=false)]
            public string SoftwareLongName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sentieon</para>
            /// </summary>
            [NameInMap("SoftwareName")]
            [Validation(Required=false)]
            public string SoftwareName { get; set; }

            [NameInMap("SoftwareVersions")]
            [Validation(Required=false)]
            public List<string> SoftwareVersions { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
