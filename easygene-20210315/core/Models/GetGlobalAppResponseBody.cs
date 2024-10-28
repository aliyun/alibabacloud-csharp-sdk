// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class GetGlobalAppResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("AppDefaultVersion")]
        [Validation(Required=false)]
        public string AppDefaultVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>This is app description.</para>
        /// </summary>
        [NameInMap("AppDescription")]
        [Validation(Required=false)]
        public string AppDescription { get; set; }

        [NameInMap("AppDescriptorFiles")]
        [Validation(Required=false)]
        public List<GetGlobalAppResponseBodyAppDescriptorFiles> AppDescriptorFiles { get; set; }
        public class GetGlobalAppResponseBodyAppDescriptorFiles : TeaModel {
            [NameInMap("Checksum")]
            [Validation(Required=false)]
            public string Checksum { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PRIMARY_DESCRIPTOR（主WDL） SECONDARY_DESCRIPTOR（依赖WDL）  CONFIG（推荐的输入参数）  CONTAINERFILE（镜像制作文件）  DATA（输入参数中引用的参考文件）  OTHER（其他）</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>./main.wdl</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WDL / CWL</para>
        /// </summary>
        [NameInMap("AppDescriptorType")]
        [Validation(Required=false)]
        public string AppDescriptorType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>实际使用时，计算该应用消耗的资源费用</para>
        /// </summary>
        [NameInMap("AppFee")]
        [Validation(Required=false)]
        public string AppFee { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>joint-calling</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OpenAccess / Protected</para>
        /// </summary>
        [NameInMap("AppScope")]
        [Validation(Required=false)]
        public string AppScope { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>workflow</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.2a-3</para>
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("AppVersions")]
        [Validation(Required=false)]
        public List<GetGlobalAppResponseBodyAppVersions> AppVersions { get; set; }
        public class GetGlobalAppResponseBodyAppVersions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>初始版本</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yyyy/MM/dd HH:mm:ss</para>
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

        }

        [NameInMap("Categories")]
        [Validation(Required=false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>初始版本</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:support@sentieon.com">support@sentieon.com</a></para>
        /// </summary>
        [NameInMap("Contact")]
        [Validation(Required=false)]
        public string Contact { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DAG</para>
        /// </summary>
        [NameInMap("DAG")]
        [Validation(Required=false)]
        public string DAG { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The app details.</para>
        /// </summary>
        [NameInMap("Document")]
        [Validation(Required=false)]
        public string Document { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DA980AD0-158F-44F3-847D-5EAB96C0EB6B</para>
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>yyyy/MM/dd HH:mm:ss</para>
        /// </summary>
        [NameInMap("LastModified")]
        [Validation(Required=false)]
        public string LastModified { get; set; }

        [NameInMap("Links")]
        [Validation(Required=false)]
        public List<string> Links { get; set; }

        [NameInMap("Locations")]
        [Validation(Required=false)]
        public List<string> Locations { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sentieon</para>
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Pinned")]
        [Validation(Required=false)]
        public bool? Pinned { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>easygene.cn-beijing.aliyuncs.com</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Sentieon</para>
        /// </summary>
        [NameInMap("Toolkit")]
        [Validation(Required=false)]
        public string Toolkit { get; set; }

    }

}
