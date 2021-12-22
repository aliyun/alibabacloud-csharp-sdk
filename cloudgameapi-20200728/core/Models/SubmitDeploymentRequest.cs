// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class SubmitDeploymentRequest : TeaModel {
        /// <summary>
        /// 实例ID列表
        /// </summary>
        [NameInMap("CloudGameInstanceIds")]
        [Validation(Required=false)]
        public string CloudGameInstanceIds { get; set; }

        /// <summary>
        /// 游戏iD
        /// </summary>
        [NameInMap("GameId")]
        [Validation(Required=false)]
        public string GameId { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 游戏版本ID
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
