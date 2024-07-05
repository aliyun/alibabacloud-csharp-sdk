// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeRenderingInstanceConfigurationRequest : TeaModel {
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public List<DescribeRenderingInstanceConfigurationRequestConfiguration> Configuration { get; set; }
        public class DescribeRenderingInstanceConfigurationRequestConfiguration : TeaModel {
            [NameInMap("AttributeNames")]
            [Validation(Required=false)]
            public List<string> AttributeNames { get; set; }

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
