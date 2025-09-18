// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class ListMmAppResponseBody : TeaModel {
        [NameInMap("AppInfoList")]
        [Validation(Required=false)]
        public List<ListMmAppResponseBodyAppInfoList> AppInfoList { get; set; }
        public class ListMmAppResponseBodyAppInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>mm_xxxx</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>多模态</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("ConversationConfig")]
            [Validation(Required=false)]
            public ListMmAppResponseBodyAppInfoListConversationConfig ConversationConfig { get; set; }
            public class ListMmAppResponseBodyAppInfoListConversationConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("AsrModel")]
                [Validation(Required=false)]
                public string AsrModel { get; set; }

                [NameInMap("OpenAsr")]
                [Validation(Required=false)]
                public bool? OpenAsr { get; set; }

                [NameInMap("OpenTts")]
                [Validation(Required=false)]
                public bool? OpenTts { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("TtsModel")]
                [Validation(Required=false)]
                public string TtsModel { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>454564</para>
            /// </summary>
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public string CreateUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("ModelConfig")]
            [Validation(Required=false)]
            public ListMmAppResponseBodyAppInfoListModelConfig ModelConfig { get; set; }
            public class ListMmAppResponseBodyAppInfoListModelConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("HistoryLimit")]
                [Validation(Required=false)]
                public string HistoryLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MMH</para>
                /// </summary>
                [NameInMap("ModelType")]
                [Validation(Required=false)]
                public string ModelType { get; set; }

                [NameInMap("OpenWebSearch")]
                [Validation(Required=false)]
                public bool? OpenWebSearch { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("TextModal")]
                [Validation(Required=false)]
                public string TextModal { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>56445</para>
            /// </summary>
            [NameInMap("ModifyUserId")]
            [Validation(Required=false)]
            public string ModifyUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ModifyUserName")]
            [Validation(Required=false)]
            public string ModifyUserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>提示词</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PublishVersion")]
            [Validation(Required=false)]
            public long? PublishVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
