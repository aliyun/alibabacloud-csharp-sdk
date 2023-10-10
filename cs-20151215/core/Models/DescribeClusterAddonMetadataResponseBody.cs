// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterAddonMetadataResponseBody : TeaModel {
        /// <summary>
        /// The component schema parameters.
        /// </summary>
        [NameInMap("config_schema")]
        [Validation(Required=false)]
        public string ConfigSchema { get; set; }

        /// <summary>
        /// The component name.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The component version.
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
