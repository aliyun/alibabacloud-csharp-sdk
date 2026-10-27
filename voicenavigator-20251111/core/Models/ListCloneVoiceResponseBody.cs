// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListCloneVoiceResponseBody : TeaModel {
        /// <summary>
        /// <para>Internal error code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The paginated list of cloned voices.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCloneVoiceResponseBodyData Data { get; set; }
        public class ListCloneVoiceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of cloned voices for the current page.</para>
            /// </summary>
            [NameInMap("CloneVoices")]
            [Validation(Required=false)]
            public List<ListCloneVoiceResponseBodyDataCloneVoices> CloneVoices { get; set; }
            public class ListCloneVoiceResponseBodyDataCloneVoices : TeaModel {
                /// <summary>
                /// <para>The ID of the cloned voice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>af81a389-91f0-4157-8d82-720edd02b66b</para>
                /// </summary>
                [NameInMap("CloneVoiceId")]
                [Validation(Required=false)]
                public string CloneVoiceId { get; set; }

                /// <summary>
                /// <para>The creation timestamp of the cloned voice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1764900994000</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The cloning model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CosyVoice</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>The name of the cloned voice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试克隆音</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The TTS engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BAILIAN</para>
                /// </summary>
                [NameInMap("NlsEngine")]
                [Validation(Required=false)]
                public string NlsEngine { get; set; }

                /// <summary>
                /// <para>The status of the cloned voice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Published</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1308144684576655</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The last update timestamp of the cloned voice.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1764900994000</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                /// <summary>
                /// <para>The base voice used for cloning.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cosyvoice-v3-plus-voicebot2-3666e4bbb2b94832ac4f4107b5804c34</para>
                /// </summary>
                [NameInMap("Voice")]
                [Validation(Required=false)]
                public string Voice { get; set; }

            }

            /// <summary>
            /// <para>The returned page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of cloned voices that match the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance af81a389-91f0-4157-8d82-720edd02b66a
        ///  does not exist.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7401D698-0AAC-5909-B68E-88C68805FFB8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
