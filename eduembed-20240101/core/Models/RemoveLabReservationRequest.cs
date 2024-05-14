// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EduEmbed20240101.Models
{
    public class RemoveLabReservationRequest : TeaModel {
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LabReservationId")]
        [Validation(Required=false)]
        public string LabReservationId { get; set; }

    }

}
