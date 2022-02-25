// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateJenkinsImageScanTaskRequest : TeaModel {
        /// <summary>
        /// 镜像 digest
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// 创建时间，timestamp
        /// </summary>
        [NameInMap("ImageCreate")]
        [Validation(Required=false)]
        public long? ImageCreate { get; set; }

        /// <summary>
        /// imageId
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// 镜像大小，字节
        /// </summary>
        [NameInMap("ImageSize")]
        [Validation(Required=false)]
        public long? ImageSize { get; set; }

        /// <summary>
        /// 修改时间，timestamp
        /// </summary>
        [NameInMap("ImageUpdate")]
        [Validation(Required=false)]
        public long? ImageUpdate { get; set; }

        [NameInMap("JenkinsEnv")]
        [Validation(Required=false)]
        public string JenkinsEnv { get; set; }

        /// <summary>
        /// 镜像命名空间，可选
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// repo名称
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// 镜像标签
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// jenkins 镜像仓库 token，必填
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// 资产 uuid
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
