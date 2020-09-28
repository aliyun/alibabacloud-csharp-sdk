// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeKubernetesVersionMetadataResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public List<DescribeKubernetesVersionMetadataResponseBody> Body { get; set; }
        public class DescribeKubernetesVersionMetadataResponseBody : TeaModel {
            /// <summary>
            /// Kubernetes版本特性。	
            /// </summary>
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public Dictionary<string, object> Capabilities { get; set; }

            /// <summary>
            /// ECS系统镜像列表。	
            /// </summary>
            [NameInMap("images")]
            [Validation(Required=false)]
            public List<DescribeKubernetesVersionMetadataResponseBodyImages> Images { get; set; }
            public class DescribeKubernetesVersionMetadataResponseBodyImages : TeaModel {
                /// <summary>
                /// 镜像ID。	
                /// </summary>
                [NameInMap("image_id")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// 镜像名称。	
                /// </summary>
                [NameInMap("image_name")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// 镜像类型。	
                /// </summary>
                [NameInMap("image_type")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                /// <summary>
                /// 操作系统发行版本号。	
                /// </summary>
                [NameInMap("os_type")]
                [Validation(Required=false)]
                public string OsType { get; set; }

                /// <summary>
                /// 操作系统平台类型。取值范围： Windows, Linux（默认）	
                /// </summary>
                [NameInMap("os_version")]
                [Validation(Required=false)]
                public string OsVersion { get; set; }

                /// <summary>
                /// 操作系统发行版。取值范围： CentOS,AliyunLinux,Windows,WindowsCore。	
                /// </summary>
                [NameInMap("platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

            }

            /// <summary>
            /// Kubernetes版本元数据信息。	
            /// </summary>
            [NameInMap("meta_data")]
            [Validation(Required=false)]
            public Dictionary<string, object> MetaData { get; set; }

            /// <summary>
            /// 是否为多可用区。	
            /// </summary>
            [NameInMap("multi_az")]
            [Validation(Required=false)]
            public string MultiAz { get; set; }

            /// <summary>
            /// 容器运行时详情。	
            /// </summary>
            [NameInMap("runtimes")]
            [Validation(Required=false)]
            public List<DescribeKubernetesVersionMetadataResponseBodyRuntimes> Runtimes { get; set; }
            public class DescribeKubernetesVersionMetadataResponseBodyRuntimes : TeaModel {
                /// <summary>
                /// 运行时名称。	
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 运行时版本。	
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// Kubernetes版本。	
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
