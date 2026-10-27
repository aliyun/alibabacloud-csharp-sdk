// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListCloneVoiceModelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request. A value of &quot;OK&quot; indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The paginated data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCloneVoiceModelsResponseBodyData Data { get; set; }
        public class ListCloneVoiceModelsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of clone voice models.</para>
            /// </summary>
            [NameInMap("CloneVoiceModels")]
            [Validation(Required=false)]
            public List<ListCloneVoiceModelsResponseBodyDataCloneVoiceModels> CloneVoiceModels { get; set; }
            public class ListCloneVoiceModelsResponseBodyDataCloneVoiceModels : TeaModel {
                /// <summary>
                /// <para>The description of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>口音还原相似度高、韵律流畅</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CosyVoice</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The model name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CosyVoice</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The detailed message returned for the request. It provides more context about the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance af81a389-91f0-4157-8d82-720edd02b66a
        ///  does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>A list of dynamic error parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The unique ID generated for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DB8BA95-4513-54B9-9C67-A28909CFB4AD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
