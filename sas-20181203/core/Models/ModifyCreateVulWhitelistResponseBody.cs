// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCreateVulWhitelistResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the information about the whitelist.
        /// </summary>
        [NameInMap("VulWhitelistList")]
        [Validation(Required=false)]
        public List<ModifyCreateVulWhitelistResponseBodyVulWhitelistList> VulWhitelistList { get; set; }
        public class ModifyCreateVulWhitelistResponseBodyVulWhitelistList : TeaModel {
            /// <summary>
            /// The ID of the whitelist.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
