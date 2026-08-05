// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class StartPlaylistRequest : TeaModel {
        /// <summary>
        /// <para>The start offset for the video file. This parameter is valid only for video files. Unit: milliseconds.</para>
        /// <para>A value greater than 0 specifies the start time relative to the first frame.</para>
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
        /// <para>The ID of the playlist. If you add items to the playlist by calling the <a href="https://help.aliyun.com/document_detail/2848078.html">AddPlaylistItems</a> operation, use the value of the ProgramId parameter that is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The restart mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Restart</b>: Starts from the beginning.</para>
        /// </description></item>
        /// <item><description><para><b>Continue</b>: Resumes playback from where it was stopped. The <b>StartItemId</b> parameter is required only when you set the <b>ResumeMode</b> parameter to <b>Custom</b>.</para>
        /// </description></item>
        /// <item><description><para><b>Custom</b>: Custom start point.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("ResumeMode")]
        [Validation(Required=false)]
        public string ResumeMode { get; set; }

        /// <summary>
        /// <para>The ID of the item to play first. When the carousel starts, this item is played.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is required only when you set <b>ResumeMode</b> to <b>Custom</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asdfasdfasdf****</para>
        /// </summary>
        [NameInMap("StartItemId")]
        [Validation(Required=false)]
        public string StartItemId { get; set; }

    }

}
