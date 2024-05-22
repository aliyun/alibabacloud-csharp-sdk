// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DetectAudioForCustomizedVoiceJobRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AudioRecordId")]
        [Validation(Required=false)]
        public int? AudioRecordId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RecordUrl")]
        [Validation(Required=false)]
        public string RecordUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("VoiceId")]
        [Validation(Required=false)]
        public string VoiceId { get; set; }

    }

}
