// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UpdateRenderingInstanceConfigurationRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public List<UpdateRenderingInstanceConfigurationRequestConfiguration> Configuration { get; set; }
        public class UpdateRenderingInstanceConfigurationRequestConfiguration : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<UpdateRenderingInstanceConfigurationRequestConfigurationAttributes> Attributes { get; set; }
            public class UpdateRenderingInstanceConfigurationRequestConfigurationAttributes : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

    }

}
