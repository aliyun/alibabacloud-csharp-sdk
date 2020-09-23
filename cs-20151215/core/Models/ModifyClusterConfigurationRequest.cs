// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterConfigurationRequest : TeaModel {
        /// <summary>
        /// 集群ID。
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 自定配置。
        /// </summary>
        [NameInMap("customize_config")]
        [Validation(Required=false)]
        public ModifyClusterConfigurationRequestCustomizeConfig CustomizeConfig { get; set; }
        public class ModifyClusterConfigurationRequestCustomizeConfig : TeaModel {
            [NameInMap("configs")]
            [Validation(Required=false)]
            public ModifyClusterConfigurationRequestCustomizeConfigConfigs Configs { get; set; }
            public class ModifyClusterConfigurationRequestCustomizeConfigConfigs : TeaModel {
                /// <summary>
                /// key。
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// value。
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }
        };

    }

}
