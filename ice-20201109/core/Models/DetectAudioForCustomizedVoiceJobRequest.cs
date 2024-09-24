// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DetectAudioForCustomizedVoiceJobRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AudioRecordId")]
        [Validation(Required=false)]
        public int? AudioRecordId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://your-bucket.oss-cn-hangzhou.aliyuncs.com/record1.wav">https://your-bucket.oss-cn-hangzhou.aliyuncs.com/record1.wav</a></para>
        /// </summary>
        [NameInMap("RecordUrl")]
        [Validation(Required=false)]
        public string RecordUrl { get; set; }

        /// <summary>
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
