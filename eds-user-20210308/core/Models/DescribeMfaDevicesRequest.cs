// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeMfaDevicesRequest : TeaModel {
        [NameInMap("AdDomain")]
        [Validation(Required=false)]
        public string AdDomain { get; set; }

        /// <summary>
        /// The list of username of convenience users.
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        /// <summary>
        /// The maximum number of entries to return. Valid values: 1 to 500.
        /// 
        /// Default value: 100.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// The query token. Set the value to the NextToken value returned in the last call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The list of serial numbers of the virtual MFA devices.
        /// </summary>
        [NameInMap("SerialNumbers")]
        [Validation(Required=false)]
        public List<string> SerialNumbers { get; set; }

    }

}
