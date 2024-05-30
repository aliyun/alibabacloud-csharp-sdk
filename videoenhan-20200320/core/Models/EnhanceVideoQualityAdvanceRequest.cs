// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class EnhanceVideoQualityAdvanceRequest : TeaModel {
        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public int? Bitrate { get; set; }

        [NameInMap("FrameRate")]
        [Validation(Required=false)]
        public int? FrameRate { get; set; }

        [NameInMap("HDRFormat")]
        [Validation(Required=false)]
        public string HDRFormat { get; set; }

        [NameInMap("MaxIlluminance")]
        [Validation(Required=false)]
        public int? MaxIlluminance { get; set; }

        [NameInMap("OutPutHeight")]
        [Validation(Required=false)]
        public int? OutPutHeight { get; set; }

        [NameInMap("OutPutWidth")]
        [Validation(Required=false)]
        public int? OutPutWidth { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("VideoURL")]
        [Validation(Required=false)]
        public Stream VideoURLObject { get; set; }

    }

}
