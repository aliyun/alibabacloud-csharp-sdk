// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateCustomizedVoiceRequest : TeaModel {
        /// <summary>
        /// <para>The media asset ID of the sample audio file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>4d5e829d498aaf966b119348</b></b></para>
        /// </summary>
        [NameInMap("DemoAudioMediaId")]
        [Validation(Required=false)]
        public string DemoAudioMediaId { get; set; }

        /// <summary>
        /// <para>The voice ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xiaozhuan</para>
        /// </summary>
        [NameInMap("VoiceId")]
        [Validation(Required=false)]
        public string VoiceId { get; set; }

    }

}
