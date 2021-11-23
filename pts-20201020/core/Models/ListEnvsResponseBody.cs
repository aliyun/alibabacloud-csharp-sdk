// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class ListEnvsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 环境列表
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public List<ListEnvsResponseBodyEnvs> Envs { get; set; }
        public class ListEnvsResponseBodyEnvs : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 环境ID
            /// </summary>
            [NameInMap("EnvId")]
            [Validation(Required=false)]
            public string EnvId { get; set; }

            /// <summary>
            /// 环境名
            /// </summary>
            [NameInMap("EnvName")]
            [Validation(Required=false)]
            public string EnvName { get; set; }

            /// <summary>
            /// 依赖的jmeter版本
            /// </summary>
            [NameInMap("EnvVersion")]
            [Validation(Required=false)]
            public string EnvVersion { get; set; }

            /// <summary>
            /// 包含的jar包
            /// </summary>
            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<ListEnvsResponseBodyEnvsFiles> Files { get; set; }
            public class ListEnvsResponseBodyEnvsFiles : TeaModel {
                /// <summary>
                /// 文件ID
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// 文件名
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// 文件的oss地址
                /// </summary>
                [NameInMap("FileOssAddress")]
                [Validation(Required=false)]
                public string FileOssAddress { get; set; }

                /// <summary>
                /// 文件大小，单位为Byte
                /// </summary>
                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// jar包的md5值
                /// </summary>
                [NameInMap("Md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

            }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// jmeter属性
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public List<ListEnvsResponseBodyEnvsProperties> Properties { get; set; }
            public class ListEnvsResponseBodyEnvsProperties : TeaModel {
                /// <summary>
                /// 描述
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// 属性名
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 属性值
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// 关联的场景
            /// </summary>
            [NameInMap("RelatedScenes")]
            [Validation(Required=false)]
            public List<string> RelatedScenes { get; set; }

            /// <summary>
            /// 关联的场景id
            /// </summary>
            [NameInMap("RunningScenes")]
            [Validation(Required=false)]
            public List<string> RunningScenes { get; set; }

            /// <summary>
            /// 环境的文件总大小
            /// </summary>
            [NameInMap("UsedCapacity")]
            [Validation(Required=false)]
            public long? UsedCapacity { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
