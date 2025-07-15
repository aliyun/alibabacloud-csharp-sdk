// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class EditPlaylistRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The configurations of the episode list. For more information, see the <b>ProgramConfig</b> section of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;RepeatNumber&quot;:&quot;0&quot;,&quot;ProgramName&quot;:&quot;my program&quot;}]</para>
        /// </summary>
        [NameInMap("ProgramConfig")]
        [Validation(Required=false)]
        public string ProgramConfig { get; set; }

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

        /// <summary>
        /// <para>The episodes that you want to add to the production studio. The value is a JSON string. For more information, see the <b>InputProgramItem</b> section of this topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ItemName&quot;:&quot;item1&quot;,&quot;ResourceType&quot;:&quot;vod&quot;,&quot;ResourceValue&quot;:&quot;5f8809f2-3352-4d1f-a8f7-86f9429f****&quot;}, {&quot;ItemName&quot;: &quot;item2&quot;,&quot;ResourceType&quot;: &quot;vod&quot;,&quot;ResourceValue&quot;: &quot;e7411c0b-dd98-4c61-a545-f8bfba6c****&quot;}]</para>
        /// </summary>
        [NameInMap("ProgramItems")]
        [Validation(Required=false)]
        public string ProgramItems { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
