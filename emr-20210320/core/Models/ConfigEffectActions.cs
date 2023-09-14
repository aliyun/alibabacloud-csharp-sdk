// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ConfigEffectActions : TeaModel {
        /// <summary>
        /// 配置生效动作。
        /// </summary>
        [NameInMap("ConfigEffectAction")]
        [Validation(Required=false)]
        public string ConfigEffectAction { get; set; }

        /// <summary>
        /// 配置生效配置文件。
        /// </summary>
        [NameInMap("ConfigFiles")]
        [Validation(Required=false)]
        public List<string> ConfigFiles { get; set; }

    }

}
