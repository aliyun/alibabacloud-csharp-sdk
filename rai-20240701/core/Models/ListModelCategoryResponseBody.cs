// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class ListModelCategoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>00000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ModelCategoryInfoList")]
        [Validation(Required=false)]
        public List<ListModelCategoryResponseBodyModelCategoryInfoList> ModelCategoryInfoList { get; set; }
        public class ListModelCategoryResponseBodyModelCategoryInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("ContentSafeImageSupported")]
            [Validation(Required=false)]
            public int? ContentSafeImageSupported { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("ContentSafeTextSupported")]
            [Validation(Required=false)]
            public int? ContentSafeTextSupported { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ModelCategoryId")]
            [Validation(Required=false)]
            public long? ModelCategoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Qwen2.5-3B-Intruct-PAI-Guard</para>
            /// </summary>
            [NameInMap("ModelCategoryName")]
            [Validation(Required=false)]
            public string ModelCategoryName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ModelSource")]
            [Validation(Required=false)]
            public int? ModelSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("PromptAttackTextSupported")]
            [Validation(Required=false)]
            public int? PromptAttackTextSupported { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("SensitiveTopicTextSupported")]
            [Validation(Required=false)]
            public int? SensitiveTopicTextSupported { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
