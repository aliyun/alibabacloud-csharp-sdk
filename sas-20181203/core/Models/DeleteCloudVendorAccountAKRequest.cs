// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteCloudVendorAccountAKRequest : TeaModel {
        /// <summary>
        /// The unique ID of the AccessKey pair.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AuthId")]
        [Validation(Required=false)]
        public long? AuthId { get; set; }

        /// <summary>
        /// The modules that are associated with the AccessKey pair.
        /// </summary>
        [NameInMap("AuthModules")]
        [Validation(Required=false)]
        public List<string> AuthModules { get; set; }

    }

}
