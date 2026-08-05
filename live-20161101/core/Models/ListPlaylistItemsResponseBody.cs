// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListPlaylistItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of playlist items.</para>
        /// </summary>
        [NameInMap("ProgramItems")]
        [Validation(Required=false)]
        public List<ListPlaylistItemsResponseBodyProgramItems> ProgramItems { get; set; }
        public class ListPlaylistItemsResponseBodyProgramItems : TeaModel {
            /// <summary>
            /// <para>The orchestration index.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>The ID of the playlist. You can use this ID as a request parameter when you edit, delete, query, start, or stop the playlist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
            /// </summary>
            [NameInMap("ProgramId")]
            [Validation(Required=false)]
            public string ProgramId { get; set; }

            /// <summary>
            /// <para>The ID of the playlist item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c10f3d63-eacf-4fbf-bd48-a07a6ba7****</para>
            /// </summary>
            [NameInMap("ProgramItemId")]
            [Validation(Required=false)]
            public string ProgramItemId { get; set; }

            /// <summary>
            /// <para>The name of the playlist item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>playlistItem1</para>
            /// </summary>
            [NameInMap("ProgramItemName")]
            [Validation(Required=false)]
            public string ProgramItemName { get; set; }

            /// <summary>
            /// <para>The type of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vod</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asdfasdf8as9df8sa9df89****</para>
            /// </summary>
            [NameInMap("ResourceValue")]
            [Validation(Required=false)]
            public string ResourceValue { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0d-f228-4a64-af62-20e91b9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of playlist items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
