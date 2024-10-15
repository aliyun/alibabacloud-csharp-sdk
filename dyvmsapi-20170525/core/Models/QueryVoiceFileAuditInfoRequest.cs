// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryVoiceFileAuditInfoRequest : TeaModel {
        /// <summary>
        /// <para>The type of the voice file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): the voice notification file.</description></item>
        /// <item><description><b>2</b>: the recording file.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public int? BusinessType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the voice file. You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a>, choose <b>Voice Messages</b> &gt; <b>Voice Notifications</b> or <b>Voice File Management</b>, and then click the <b>Voice Notification Files</b> tab to view the <b>voice ID</b>.</para>
        /// <remarks>
        /// <para>You can query up to 10 voice files each time. Separate the voice file names with commas (,).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8501d2eb-efbb-471f-xxx8-****.wav</para>
        /// </summary>
        [NameInMap("VoiceCodes")]
        [Validation(Required=false)]
        public string VoiceCodes { get; set; }

    }

}
