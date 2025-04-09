// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SubmitRecordingRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;contactId&quot;:&quot;3d35c0487cc041abb7ad0ce61752601f&quot;,&quot;duration&quot;:27,&quot;fileName&quot;:&quot;ce2659e5-a20b-4f8e-91b5-5cd909c6b96e_3d35c0487cc041abb7ad0ce61752601f.wav&quot;,&quot;filePath&quot;:&quot;oss://ForCompatibility/waveforms/&quot;,&quot;startTime&quot;:1579057583670,&quot;type&quot;:&quot;Merged&quot;}</para>
        /// </summary>
        [NameInMap("MergedRecording")]
        [Validation(Required=false)]
        public string MergedRecording { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;contactId&quot;:&quot;3d35c0487cc041abb7ad0ce61752601f&quot;,&quot;duration&quot;:27,&quot;fileName&quot;:&quot;ce2659e5-a20b-4f8e-91b5-5cd909c6b96e_3d35c0487cc041abb7ad0ce61752601f.wav&quot;,&quot;filePath&quot;:&quot;oss://ForCompatibility/waveforms/&quot;,&quot;startTime&quot;:1579057583670,&quot;type&quot;:&quot;Source&quot;}</para>
        /// </summary>
        [NameInMap("ResourceRecording")]
        [Validation(Required=false)]
        public string ResourceRecording { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e4e2a770-b97b-465a-80d8-06dca008c503</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
