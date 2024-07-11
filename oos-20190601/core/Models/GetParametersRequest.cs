// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetParametersRequest : TeaModel {
        /// <summary>
        /// The names of the common parameters.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Names")]
        [Validation(Required=false)]
        public string Names { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
