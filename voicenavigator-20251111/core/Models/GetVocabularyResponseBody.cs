// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class GetVocabularyResponseBody : TeaModel {
        /// <summary>
        /// <para>The internal error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The vocabulary object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetVocabularyResponseBodyData Data { get; set; }
        public class GetVocabularyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1773453676000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The vocabulary description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>包含金融场景专业术语</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

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
            /// <para>The vocabulary name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>金融场景热词</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1773453676000</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            /// <summary>
            /// <para>The vocabulary ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>af81a389-91f0-4157-8d82-720edd02b66b</para>
            /// </summary>
            [NameInMap("VocabularyId")]
            [Validation(Required=false)]
            public string VocabularyId { get; set; }

            /// <summary>
            /// <para>The word count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("WordCount")]
            [Validation(Required=false)]
            public string WordCount { get; set; }

            /// <summary>
            /// <para>A JSON string that contains the words and their weights.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;苹果\&quot;:\&quot;2\&quot;,\&quot;香蕉\&quot;:\&quot;3\&quot;}</para>
            /// </summary>
            [NameInMap("Words")]
            [Validation(Required=false)]
            public string Words { get; set; }

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
        /// <para>The error message.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>97E7ED13-6884-52D7-B97E-C780D7870680</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
