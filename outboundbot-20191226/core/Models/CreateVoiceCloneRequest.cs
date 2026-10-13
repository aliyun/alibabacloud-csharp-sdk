// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateVoiceCloneRequest : TeaModel {
        /// <summary>
        /// <para>The Folder field returned after a file is uploaded by calling the GetJobDataUploadParams operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>voiceclone/recordings/demo.mp3</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The model used for voice cloning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cosyvoice-v3.5-flash</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The name of the cloned voice. The names of enabled voices within the same instance must be unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cloned voice 1</para>
        /// </summary>
        [NameInMap("VoiceName")]
        [Validation(Required=false)]
        public string VoiceName { get; set; }

    }

}
