// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateEdgeContainerAppVersionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;Name&quot;: &quot;container1&quot;,
        ///             &quot;Image&quot;: &quot;image1&quot;,
        ///             &quot;Spec&quot;: &quot;1C2G&quot;,
        ///             &quot;Command&quot;: &quot;/bin/sh&quot;,
        ///             &quot;Args&quot;: &quot;-c hello&quot;,
        ///             &quot;ProbeType&quot;: &quot;tcpSocket&quot;,
        ///             &quot;ProbeContent&quot;: &quot;{\&quot;Port\&quot;:8080}&quot;
        ///       },
        ///       {
        ///             &quot;Name&quot;: &quot;container2&quot;,
        ///             &quot;Image&quot;: &quot;image2&quot;,
        ///             &quot;Spec&quot;: &quot;2C4G&quot;,
        ///             &quot;ProbeType&quot;: &quot;httpGet&quot;,
        ///             &quot;ProbeContent&quot;: &quot;{\&quot;Path\&quot;:\&quot;/\&quot;,\&quot;Port\&quot;:80,\&quot;InitialDelaySeconds\&quot;:10}&quot;
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("Containers")]
        [Validation(Required=false)]
        public List<CreateEdgeContainerAppVersionRequestContainers> Containers { get; set; }
        public class CreateEdgeContainerAppVersionRequestContainers : TeaModel {
            [NameInMap("ACRImageInfo")]
            [Validation(Required=false)]
            public CreateEdgeContainerAppVersionRequestContainersACRImageInfo ACRImageInfo { get; set; }
            public class CreateEdgeContainerAppVersionRequestContainersACRImageInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1500.***.net</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xcdn-9axbo****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsEnterpriseRegistry")]
                [Validation(Required=false)]
                public bool? IsEnterpriseRegistry { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>crr-h1ghghu60ct****</para>
                /// </summary>
                [NameInMap("RepoId")]
                [Validation(Required=false)]
                public string RepoId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_71</para>
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>safeline</para>
                /// </summary>
                [NameInMap("RepoNamespace")]
                [Validation(Required=false)]
                public string RepoNamespace { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3.40.2</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("TagUrl")]
                [Validation(Required=false)]
                public string TagUrl { get; set; }

            }

            [NameInMap("Args")]
            [Validation(Required=false)]
            public string Args { get; set; }

            [NameInMap("Command")]
            [Validation(Required=false)]
            public string Command { get; set; }

            [NameInMap("EnvVariables")]
            [Validation(Required=false)]
            public string EnvVariables { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-shenzhen.aliyuncs.com/lihe<b><b>h/ea</b></b>ts_serv**<b>am:3.</b></para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsACRImage")]
            [Validation(Required=false)]
            public bool? IsACRImage { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lxg-demo-er</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PostStart")]
            [Validation(Required=false)]
            public string PostStart { get; set; }

            [NameInMap("PreStop")]
            [Validation(Required=false)]
            public string PreStop { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ProbeContent")]
            [Validation(Required=false)]
            public CreateEdgeContainerAppVersionRequestContainersProbeContent ProbeContent { get; set; }
            public class CreateEdgeContainerAppVersionRequestContainersProbeContent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>echo ok</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("FailureThreshold")]
                [Validation(Required=false)]
                public int? FailureThreshold { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.rewrite.com">www.rewrite.com</a></para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{\&quot;Content-Type\&quot;:\&quot;application/json\&quot;}]</para>
                /// </summary>
                [NameInMap("HttpHeaders")]
                [Validation(Required=false)]
                public string HttpHeaders { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InitialDelaySeconds")]
                [Validation(Required=false)]
                public int? InitialDelaySeconds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PeriodSeconds")]
                [Validation(Required=false)]
                public int? PeriodSeconds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9991</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("Scheme")]
                [Validation(Required=false)]
                public string Scheme { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SuccessThreshold")]
                [Validation(Required=false)]
                public int? SuccessThreshold { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TimeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ProbeType")]
            [Validation(Required=false)]
            public string ProbeType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Storage")]
            [Validation(Required=false)]
            public string Storage { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>verson1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test app</para>
        /// </summary>
        [NameInMap("Remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

    }

}
