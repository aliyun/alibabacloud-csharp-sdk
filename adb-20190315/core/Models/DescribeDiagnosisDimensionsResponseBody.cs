// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDiagnosisDimensionsResponseBody : TeaModel {
        /// <summary>
        /// The source IP addresses.
        /// </summary>
        [NameInMap("ClientIps")]
        [Validation(Required=false)]
        public List<string> ClientIps { get; set; }

        /// <summary>
        /// The databases.
        /// </summary>
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<string> Databases { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resource groups.
        /// </summary>
        [NameInMap("ResourceGroups")]
        [Validation(Required=false)]
        public List<string> ResourceGroups { get; set; }

        /// <summary>
        /// The usernames.
        /// </summary>
        [NameInMap("UserNames")]
        [Validation(Required=false)]
        public List<string> UserNames { get; set; }

    }

}
