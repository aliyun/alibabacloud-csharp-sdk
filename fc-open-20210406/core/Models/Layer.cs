// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class Layer : TeaModel {
        /// <summary>
        /// 层访问类型
        /// </summary>
        [NameInMap("acl")]
        [Validation(Required=false)]
        public int? Acl { get; set; }

        /// <summary>
        /// arn
        /// </summary>
        [NameInMap("arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// 层代码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public LayerCode Code { get; set; }

        /// <summary>
        /// 层Checksum
        /// </summary>
        [NameInMap("codeChecksum")]
        [Validation(Required=false)]
        public string CodeChecksum { get; set; }

        /// <summary>
        /// 层代码大小
        /// </summary>
        [NameInMap("codeSize")]
        [Validation(Required=false)]
        public long? CodeSize { get; set; }

        /// <summary>
        /// compatibleRuntime
        /// </summary>
        [NameInMap("compatibleRuntime")]
        [Validation(Required=false)]
        public List<string> CompatibleRuntime { get; set; }

        /// <summary>
        /// 层创建时间
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 层描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 层名称
        /// </summary>
        [NameInMap("layerName")]
        [Validation(Required=false)]
        public string LayerName { get; set; }

        /// <summary>
        /// 层版本
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

    }

}
