// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("DatasetList")]
        [Validation(Required=false)]
        public List<Dataset> DatasetList { get; set; }

        /// <summary>
        /// 实例规格
        /// </summary>
        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        /// <summary>
        /// 环境参数
        /// </summary>
        [NameInMap("Environments")]
        [Validation(Required=false)]
        public Dictionary<string, object> Environments { get; set; }

        /// <summary>
        /// 镜像id
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// 镜像地址
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("IsPublic")]
        [Validation(Required=false)]
        public long? IsPublic { get; set; }

        /// <summary>
        /// nas文件系统id
        /// </summary>
        [NameInMap("NasFileSystemId")]
        [Validation(Required=false)]
        public string NasFileSystemId { get; set; }

        /// <summary>
        /// 实例的真实用户名称
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// 打通的vpc网络配置
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UserVpc UserVpc { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
