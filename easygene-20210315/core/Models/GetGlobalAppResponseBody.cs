// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class GetGlobalAppResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [NameInMap("LastModified")]
        [Validation(Required=false)]
        public string LastModified { get; set; }

        /// <summary>
        /// 命名空间名称
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// 应用权限
        /// </summary>
        [NameInMap("AppScope")]
        [Validation(Required=false)]
        public string AppScope { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// 应用支持的区域
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// 应用版本
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// 应用计费说明
        /// </summary>
        [NameInMap("AppFee")]
        [Validation(Required=false)]
        public string AppFee { get; set; }

        /// <summary>
        /// 应用描述
        /// </summary>
        [NameInMap("AppDescription")]
        [Validation(Required=false)]
        public string AppDescription { get; set; }

        /// <summary>
        /// 应用所属分类
        /// </summary>
        [NameInMap("Categories")]
        [Validation(Required=false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// 应用所属工具合集
        /// </summary>
        [NameInMap("Toolkit")]
        [Validation(Required=false)]
        public string Toolkit { get; set; }

        /// <summary>
        /// 应用联系人信息
        /// </summary>
        [NameInMap("Contact")]
        [Validation(Required=false)]
        public string Contact { get; set; }

        /// <summary>
        /// 应用主页信息
        /// </summary>
        [NameInMap("Links")]
        [Validation(Required=false)]
        public List<string> Links { get; set; }

        /// <summary>
        /// 应用的所有版本列表
        /// </summary>
        [NameInMap("AppVersions")]
        [Validation(Required=false)]
        public List<GetGlobalAppResponseBodyAppVersions> AppVersions { get; set; }
        public class GetGlobalAppResponseBodyAppVersions : TeaModel {
            /// <summary>
            /// 应用版本
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// 版本描述
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// 更新时间
            /// </summary>
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

        }

        /// <summary>
        /// 默认版本
        /// </summary>
        [NameInMap("AppDefaultVersion")]
        [Validation(Required=false)]
        public string AppDefaultVersion { get; set; }

        /// <summary>
        /// 应用描述语言标准(WDL/CWL)
        /// </summary>
        [NameInMap("AppDescriptorType")]
        [Validation(Required=false)]
        public string AppDescriptorType { get; set; }

        /// <summary>
        /// 应用的描述文件内容
        /// </summary>
        [NameInMap("AppDescriptorFiles")]
        [Validation(Required=false)]
        public List<GetGlobalAppResponseBodyAppDescriptorFiles> AppDescriptorFiles { get; set; }
        public class GetGlobalAppResponseBodyAppDescriptorFiles : TeaModel {
            /// <summary>
            /// 应用文件的类型
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            /// <summary>
            /// 应用文件的路径，除PRIMARY_DESCRIPTOR外，其他均为相对于PRIMARY_DESCRIPTOR的相对路径
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// 应用文件内容
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 应用文件链接
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// 应用文件内容的完整性校验码，如MD5值
            /// </summary>
            [NameInMap("Checksum")]
            [Validation(Required=false)]
            public string Checksum { get; set; }

        }

        /// <summary>
        /// 应用的帮助文档
        /// </summary>
        [NameInMap("Document")]
        [Validation(Required=false)]
        public string Document { get; set; }

        /// <summary>
        /// 应用的备注信息
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// 应用的DAG信息
        /// </summary>
        [NameInMap("DAG")]
        [Validation(Required=false)]
        public string DAG { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        /// <summary>
        /// 应用收藏置顶标记
        /// </summary>
        [NameInMap("Pinned")]
        [Validation(Required=false)]
        public bool? Pinned { get; set; }

    }

}
