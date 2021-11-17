// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class Image : TeaModel {
        /// <summary>
        /// 资源类型
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// 镜像作者
        /// </summary>
        [NameInMap("Author")]
        [Validation(Required=false)]
        public string Author { get; set; }

        /// <summary>
        /// Cuda版本
        /// </summary>
        [NameInMap("CudaVersion")]
        [Validation(Required=false)]
        public string CudaVersion { get; set; }

        /// <summary>
        /// 镜像描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Ecs镜像key
        /// </summary>
        [NameInMap("EcsImageKey")]
        [Validation(Required=false)]
        public string EcsImageKey { get; set; }

        /// <summary>
        /// 算法框架
        /// </summary>
        [NameInMap("Framework")]
        [Validation(Required=false)]
        public string Framework { get; set; }

        /// <summary>
        /// 算法框架版本
        /// </summary>
        [NameInMap("FrameworkVersion")]
        [Validation(Required=false)]
        public string FrameworkVersion { get; set; }

        /// <summary>
        /// 镜像父镜像
        /// </summary>
        [NameInMap("FromImageId")]
        [Validation(Required=false)]
        public string FromImageId { get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [NameInMap("FromImageName")]
        [Validation(Required=false)]
        public string FromImageName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// 镜像ID
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// 镜像url
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 镜像命名空间
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// 镜像操作系统分发版
        /// </summary>
        [NameInMap("OS")]
        [Validation(Required=false)]
        public string OS { get; set; }

        /// <summary>
        /// 分发版版本
        /// </summary>
        [NameInMap("OSVersion")]
        [Validation(Required=false)]
        public string OSVersion { get; set; }

        /// <summary>
        /// python版本
        /// </summary>
        [NameInMap("PythonVersion")]
        [Validation(Required=false)]
        public string PythonVersion { get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// 镜像仓库
        /// </summary>
        [NameInMap("Repository")]
        [Validation(Required=false)]
        public string Repository { get; set; }

        /// <summary>
        /// 跳转的镜像站点页面
        /// </summary>
        [NameInMap("RepositoryPage")]
        [Validation(Required=false)]
        public string RepositoryPage { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public long? ResourceType { get; set; }

        /// <summary>
        /// 镜像的根镜像
        /// </summary>
        [NameInMap("RootImageId")]
        [Validation(Required=false)]
        public string RootImageId { get; set; }

        /// <summary>
        /// 镜像是否被其他实例共享
        /// </summary>
        [NameInMap("Shared")]
        [Validation(Required=false)]
        public bool? Shared { get; set; }

        /// <summary>
        /// 镜像短url
        /// </summary>
        [NameInMap("ShortImageUrl")]
        [Validation(Required=false)]
        public string ShortImageUrl { get; set; }

        /// <summary>
        /// 镜像仓库短名称
        /// </summary>
        [NameInMap("ShortRepository")]
        [Validation(Required=false)]
        public string ShortRepository { get; set; }

        /// <summary>
        /// 镜像状态
        /// </summary>
        [NameInMap("Stage")]
        [Validation(Required=false)]
        public string Stage { get; set; }

        /// <summary>
        /// 镜像状态代码
        /// </summary>
        [NameInMap("StageCode")]
        [Validation(Required=false)]
        public long? StageCode { get; set; }

        /// <summary>
        /// 保存镜像建议的名称
        /// </summary>
        [NameInMap("SuggestedName")]
        [Validation(Required=false)]
        public string SuggestedName { get; set; }

        /// <summary>
        /// Tag
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// 镜像类型
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// 工作空间镜像id
        /// </summary>
        [NameInMap("WorkspaceImageId")]
        [Validation(Required=false)]
        public string WorkspaceImageId { get; set; }

    }

}
