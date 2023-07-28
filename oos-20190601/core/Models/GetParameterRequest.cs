// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetParameterRequest : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to GetParameter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The time when the common parameter was updated.
        /// </summary>
        [NameInMap("ParameterVersion")]
        [Validation(Required=false)]
        public int? ParameterVersion { get; set; }

        /// <summary>
        /// The name of the common parameter.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The user who created the common parameter.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
