// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceRequest : TeaModel {
        [NameInMap("FilterAliUid")]
        [Validation(Required=false)]
        public bool? FilterAliUid { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        [NameInMap("SharedAccountType")]
        [Validation(Required=false)]
        public string SharedAccountType { get; set; }

        [NameInMap("ShowDetail")]
        [Validation(Required=false)]
        public List<string> ShowDetail { get; set; }

    }

}
