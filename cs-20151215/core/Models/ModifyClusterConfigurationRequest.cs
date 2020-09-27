// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterConfigurationRequest : TeaModel {
        /// <summary>
        /// 配置集合。
        /// </summary>
        [NameInMap("configs")]
        [Validation(Required=false)]
        public ModifyClusterConfigurationRequestConfigs Configs { get; set; }
        public class ModifyClusterConfigurationRequestConfigs : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }
        };

        /// <summary>
        /// 配置名称。
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
