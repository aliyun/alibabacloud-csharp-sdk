// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianVoiceBot20250101.Models
{
    public class CreateCloneVoiceRequest : TeaModel {
        /// <summary>
        /// <para>The Bailian workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xdne77rxe14ziszr</para>
        /// </summary>
        [NameInMap("BusinessUnitId")]
        [Validation(Required=false)]
        public string BusinessUnitId { get; set; }

        /// <summary>
        /// <para>The path of the uploaded file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>voice_clone/voice_clone_unit_test.wav</para>
        /// </summary>
        [NameInMap("FileKey")]
        [Validation(Required=false)]
        public string FileKey { get; set; }

        /// <summary>
        /// <para>The clone model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CosyVoice</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

    }

}
