// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartPlaylistRequest : TeaModel {
        /// <summary>
        /// <para>The offset of the position where the system starts the playback. This parameter takes effect only if the input source is a video file. Unit: milliseconds.</para>
        /// <para>A value greater than 0 indicates an offset from the first frame.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the episode list. If the episode list was created by calling the <a href="https://help.aliyun.com/document_detail/2848078.html">AddPlaylistItems</a> operation, check the value of the response parameter ProgramId to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The method to resume the playback of the episode list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Restart</b>: resumes the playback from the beginning.</description></item>
        /// <item><description><b>Continue</b>: resumes the playback from the position where the previous playback stops. The <b>StartItemId</b> parameter is required only if you set <b>ResumeMode</b> to <b>Custom</b>.</description></item>
        /// <item><description><b>Custom</b>: resumes the playback from a custom position.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("ResumeMode")]
        [Validation(Required=false)]
        public string ResumeMode { get; set; }

        /// <summary>
        /// <para>The ID of the first episode to play. This episode is the first to play in carousel playback.</para>
        /// <remarks>
        /// <para> This parameter is required only if you set ResumeMode to Custom.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>asdfasdfasdf****</para>
        /// </summary>
        [NameInMap("StartItemId")]
        [Validation(Required=false)]
        public string StartItemId { get; set; }

    }

}
