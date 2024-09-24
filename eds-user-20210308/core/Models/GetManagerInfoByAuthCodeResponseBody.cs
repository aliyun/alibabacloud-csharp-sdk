// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class GetManagerInfoByAuthCodeResponseBody : TeaModel {
        /// <summary>
        /// The organization ID.
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// The mobile number.
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The team name.
        /// </summary>
        [NameInMap("TeamName")]
        [Validation(Required=false)]
        public string TeamName { get; set; }

        /// <summary>
        /// The tenant name.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The ID of the Elastic Desktop Service account.
        /// </summary>
        [NameInMap("WaId")]
        [Validation(Required=false)]
        public long? WaId { get; set; }

    }

}
