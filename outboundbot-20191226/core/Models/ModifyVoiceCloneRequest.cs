// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyVoiceCloneRequest : TeaModel {
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
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cosyvoice-v2-067dc4b2e9d34dbeb5de20b5b093d1e3</para>
        /// </summary>
        [NameInMap("VoiceId")]
        [Validation(Required=false)]
        public string VoiceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>克隆音色1</para>
        /// </summary>
        [NameInMap("VoiceName")]
        [Validation(Required=false)]
        public string VoiceName { get; set; }

    }

}
