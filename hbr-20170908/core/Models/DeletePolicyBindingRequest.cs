// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DeletePolicyBindingRequest : TeaModel {
        /// <summary>
        /// The IDs of the data sources that you want to disassociate from the backup policy.
        /// </summary>
        [NameInMap("DataSourceIds")]
        [Validation(Required=false)]
        public List<string> DataSourceIds { get; set; }

        /// <summary>
        /// The ID of the backup policy.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// The type of the data source. Valid values:
        /// 
        /// *   **UDM_ECS**: ECS instance backup
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
