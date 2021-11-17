// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class Dataset : TeaModel {
        /// <summary>
        /// 数据集id
        /// </summary>
        [NameInMap("DatasetId")]
        [Validation(Required=false)]
        public string DatasetId { get; set; }

        /// <summary>
        /// 默认挂载路径
        /// </summary>
        [NameInMap("DefaultMountPath")]
        [Validation(Required=false)]
        public string DefaultMountPath { get; set; }

        /// <summary>
        /// 文件系统Id
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// 挂载路径
        /// </summary>
        [NameInMap("MountPath")]
        [Validation(Required=false)]
        public string MountPath { get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 文件系统被挂载路径
        /// </summary>
        [NameInMap("NasPath")]
        [Validation(Required=false)]
        public string NasPath { get; set; }

    }

}
