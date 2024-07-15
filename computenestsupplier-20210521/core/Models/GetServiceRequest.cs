// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetServiceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to filter information based on Alibaba Cloud account IDs.
        /// </summary>
        [NameInMap("FilterAliUid")]
        [Validation(Required=false)]
        public bool? FilterAliUid { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The service ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The service version.
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// The share type of the service. Default value: SharedAccount. Valid values:
        /// 
        /// *   SharedAccount: The service is shared by multiple accounts.
        /// *   Resell: The service is distributed.
        /// </summary>
        [NameInMap("SharedAccountType")]
        [Validation(Required=false)]
        public string SharedAccountType { get; set; }

        /// <summary>
        /// The information that you want to query.
        /// </summary>
        [NameInMap("ShowDetail")]
        [Validation(Required=false)]
        public List<string> ShowDetail { get; set; }

    }

}
