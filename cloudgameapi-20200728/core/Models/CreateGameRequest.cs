// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class CreateGameRequest : TeaModel {
        /// <summary>
        /// 幂等参数，1-64位建议使用uuid
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 游戏名称
        /// </summary>
        [NameInMap("GameName")]
        [Validation(Required=false)]
        public string GameName { get; set; }

        /// <summary>
        /// 平台类型
        /// </summary>
        [NameInMap("PlatformType")]
        [Validation(Required=false)]
        public long? PlatformType { get; set; }

    }

}
