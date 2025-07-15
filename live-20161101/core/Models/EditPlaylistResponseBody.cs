// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class EditPlaylistResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio. You can use the ID as a request parameter in the API operation that is used to configure callbacks or add a virtual studio layout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e94d1f4-1a65-445c-9dcf-de8b3b8d****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The information about the episodes.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public EditPlaylistResponseBodyItems Items { get; set; }
        public class EditPlaylistResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The episodes that failed to be added.</para>
            /// </summary>
            [NameInMap("FailedItems")]
            [Validation(Required=false)]
            public List<EditPlaylistResponseBodyItemsFailedItems> FailedItems { get; set; }
            public class EditPlaylistResponseBodyItemsFailedItems : TeaModel {
                /// <summary>
                /// <para>The ID of the episode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c09f3d63-eacf-4fbf-bd48-a07a6ba7****</para>
                /// </summary>
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// <para>The name of the episode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>item2</para>
                /// </summary>
                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

            }

            /// <summary>
            /// <para>The episodes that were added.</para>
            /// </summary>
            [NameInMap("SuccessItems")]
            [Validation(Required=false)]
            public List<EditPlaylistResponseBodyItemsSuccessItems> SuccessItems { get; set; }
            public class EditPlaylistResponseBodyItemsSuccessItems : TeaModel {
                /// <summary>
                /// <para>The ID of the episode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c09f3d63-eacf-4fbf-bd48-a07a6ba7****</para>
                /// </summary>
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// <para>The name of the episode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>item1</para>
                /// </summary>
                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the episode list. You can use the ID as a request parameter in the API operation that is used to delete the episode list, query the information about the episode list, start the episode list, or stop the episode list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c6a2a0d-f228-4a64-af62-20e91b96****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
