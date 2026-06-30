// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListAsrVocabResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates that the request was successful. Other values indicate that the request failed. You can use this field to determine the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAsrVocabResponseBodyData Data { get; set; }
        public class ListAsrVocabResponseBodyData : TeaModel {
            [NameInMap("AsrVocab")]
            [Validation(Required=false)]
            public List<ListAsrVocabResponseBodyDataAsrVocab> AsrVocab { get; set; }
            public class ListAsrVocabResponseBodyDataAsrVocab : TeaModel {
                [NameInMap("AsrVersion")]
                [Validation(Required=false)]
                public int? AsrVersion { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("ModelCustomizationId")]
                [Validation(Required=false)]
                public string ModelCustomizationId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("VocabularyId")]
                [Validation(Required=false)]
                public string VocabularyId { get; set; }

            }

        }

        /// <summary>
        /// <para>The error details if the request fails. If the request is successful, the value is <b>successful</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66E1ACB8-17B2-4BE8-8581-954A8EE1324B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Use this field to determine if the request was successful. A value of true indicates success. A value of <b>false</b> or <b>null</b> indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
