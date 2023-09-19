// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetParameterRequest : TeaModel {
        /// <summary>
        /// The name of the common parameter. The name can be up to 200 characters in length and can contain letters, digits, hyphens (-), and underscores (\_).
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The version number of the common parameter. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("ParameterVersion")]
        [Validation(Required=false)]
        public int? ParameterVersion { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
