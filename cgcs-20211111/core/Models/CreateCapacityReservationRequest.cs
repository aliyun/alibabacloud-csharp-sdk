// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class CreateCapacityReservationRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DistrictId")]
        [Validation(Required=false)]
        public string DistrictId { get; set; }

        [NameInMap("ExpectResourceReadyTime")]
        [Validation(Required=false)]
        [Obsolete]
        public string ExpectResourceReadyTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExpectSessionCapacity")]
        [Validation(Required=false)]
        public int? ExpectSessionCapacity { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
