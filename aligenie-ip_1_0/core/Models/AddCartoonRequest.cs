// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class AddCartoonRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartVideoMd5")]
        [Validation(Required=false)]
        public string StartVideoMd5 { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartVideoUrl")]
        [Validation(Required=false)]
        public string StartVideoUrl { get; set; }

    }

}
