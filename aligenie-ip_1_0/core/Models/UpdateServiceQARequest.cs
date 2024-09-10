// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class UpdateServiceQARequest : TeaModel {
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("ServiceQAId")]
        [Validation(Required=false)]
        public long? ServiceQAId { get; set; }

        [NameInMap("isActive")]
        [Validation(Required=false)]
        public bool? IsActive { get; set; }

    }

}
