// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ModifyClusterConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The custom configurations.</para>
        /// </summary>
        [NameInMap("customize_config")]
        [Validation(Required=false)]
        public List<ModifyClusterConfigurationRequestCustomizeConfig> CustomizeConfig { get; set; }
        public class ModifyClusterConfigurationRequestCustomizeConfig : TeaModel {
            /// <summary>
            /// <para>The custom configurations.</para>
            /// </summary>
            [NameInMap("configs")]
            [Validation(Required=false)]
            public List<ModifyClusterConfigurationRequestCustomizeConfigConfigs> Configs { get; set; }
            public class ModifyClusterConfigurationRequestCustomizeConfigConfigs : TeaModel {
                /// <summary>
                /// <para>The name of the configuration item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MaxRequestsInflight</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the configuration item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The name of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kube-apiserver</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
