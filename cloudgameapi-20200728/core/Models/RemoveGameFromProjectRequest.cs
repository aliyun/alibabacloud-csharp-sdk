// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class RemoveGameFromProjectRequest : TeaModel {
        /// <summary>
        /// 游戏iD
        /// </summary>
        [NameInMap("GameId")]
        [Validation(Required=false)]
        public string GameId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
