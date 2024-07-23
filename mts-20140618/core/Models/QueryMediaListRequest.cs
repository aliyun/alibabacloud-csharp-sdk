// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaListRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to include media information in the returned result.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: true and false.</description></item>
        /// <item><description>Default value: <b>false</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeMediaInfo")]
        [Validation(Required=false)]
        public bool? IncludeMediaInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to include playback information in the returned result.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: true and false.</description></item>
        /// <item><description>Default value: <b>false</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludePlayList")]
        [Validation(Required=false)]
        public bool? IncludePlayList { get; set; }

        /// <summary>
        /// <para>Specifies whether to include snapshot information in the returned result.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: true and false.</description></item>
        /// <item><description>Default value: <b>false</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeSnapshotList")]
        [Validation(Required=false)]
        public bool? IncludeSnapshotList { get; set; }

        /// <summary>
        /// <para>Specifies whether to include summaries in the returned result.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: true and false.</description></item>
        /// <item><description>Default value: <b>false</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeSummaryList")]
        [Validation(Required=false)]
        public bool? IncludeSummaryList { get; set; }

        /// <summary>
        /// <para>The IDs of the media files. To obtain the ID of a media file, you can perform the following operations in the ApsaraVideo Media Processing (MPS) console: In the left-side navigation pane, choose <b>Media Management</b> &gt; <b>Media List</b>. Find the required video and click Manage. The ID of the video is displayed on the Basics tab. Separate multiple IDs with commas (,). You can query up to 10 media files at a time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3e1cd21131a94525be55acf65888****,e26cfa29e784402388463f61dbec****</para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
