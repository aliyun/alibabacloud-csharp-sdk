// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateCustomizedVoiceRequest : TeaModel {
        [NameInMap("DemoAudioMediaId")]
        [Validation(Required=false)]
        public string DemoAudioMediaId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("VoiceId")]
        [Validation(Required=false)]
        public string VoiceId { get; set; }

    }

}
