// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterConfigurationRequest : TeaModel {
        /// <summary>
        /// 自定义配置。
        /// </summary>
        [NameInMap("customize_config")]
        [Validation(Required=false)]
        public List<ModifyClusterConfigurationRequestCustomizeConfig> CustomizeConfig { get; set; }
        public class ModifyClusterConfigurationRequestCustomizeConfig : TeaModel {
            /// <summary>
            /// 组件配置。
            /// </summary>
            [NameInMap("configs")]
            [Validation(Required=false)]
            public List<ModifyClusterConfigurationRequestCustomizeConfigConfigs> Configs { get; set; }
            public class ModifyClusterConfigurationRequestCustomizeConfigConfigs : TeaModel {
                /// <summary>
                /// key值。
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// value值。
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// 组件名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
