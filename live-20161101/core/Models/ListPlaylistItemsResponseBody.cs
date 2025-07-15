// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListPlaylistItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The episodes.</para>
        /// </summary>
        [NameInMap("ProgramItems")]
        [Validation(Required=false)]
        public List<ListPlaylistItemsResponseBodyProgramItems> ProgramItems { get; set; }
        public class ListPlaylistItemsResponseBodyProgramItems : TeaModel {
            /// <summary>
            /// <para>The sequence number of the episode in the query result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>The ID of the episode list. You can use the ID as a request parameter in the API operation that is used to edit the episode list, delete the episode list, query the information about the episode list, start the episode list, or stop the episode list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
            /// </summary>
            [NameInMap("ProgramId")]
            [Validation(Required=false)]
            public string ProgramId { get; set; }

            /// <summary>
            /// <para>The ID of the episode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c10f3d63-eacf-4fbf-bd48-a07a6ba7****</para>
            /// </summary>
            [NameInMap("ProgramItemId")]
            [Validation(Required=false)]
            public string ProgramItemId { get; set; }

            /// <summary>
            /// <para>The name of the episode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>playlistItem1</para>
            /// </summary>
            [NameInMap("ProgramItemName")]
            [Validation(Required=false)]
            public string ProgramItemName { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vod</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asdfasdf8as9df8sa9df89****</para>
            /// </summary>
            [NameInMap("ResourceValue")]
            [Validation(Required=false)]
            public string ResourceValue { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0d-f228-4a64-af62-20e91b9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of episodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
