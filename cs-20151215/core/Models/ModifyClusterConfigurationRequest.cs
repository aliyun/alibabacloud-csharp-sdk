// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterConfigurationRequest : TeaModel {
        /// <summary>
        /// The custom configuration.
        /// </summary>
        [NameInMap("customize_config")]
        [Validation(Required=false)]
        public List<ModifyClusterConfigurationRequestCustomizeConfig> CustomizeConfig { get; set; }
        public class ModifyClusterConfigurationRequestCustomizeConfig : TeaModel {
            /// <summary>
            /// The custom configuration.
            /// </summary>
            [NameInMap("configs")]
            [Validation(Required=false)]
            public List<ModifyClusterConfigurationRequestCustomizeConfigConfigs> Configs { get; set; }
            public class ModifyClusterConfigurationRequestCustomizeConfigConfigs : TeaModel {
                /// <summary>
                /// The name of the configuration item.
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the configuration item.
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The name of the component.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
