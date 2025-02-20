// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class ListVocabResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListVocabResponseBodyData> Data { get; set; }
        public class ListVocabResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>nls</para>
            /// </summary>
            [NameInMap("audioModelCode")]
            [Validation(Required=false)]
            public string AudioModelCode { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dv*****erverve</para>
            /// </summary>
            [NameInMap("vocabularyId")]
            [Validation(Required=false)]
            public string VocabularyId { get; set; }

            [NameInMap("wordWeightList")]
            [Validation(Required=false)]
            public List<ListVocabResponseBodyDataWordWeightList> WordWeightList { get; set; }
            public class ListVocabResponseBodyDataWordWeightList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

                [NameInMap("word")]
                [Validation(Required=false)]
                public string Word { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>968A8634-FA2C-5381-9B3E-*******F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
