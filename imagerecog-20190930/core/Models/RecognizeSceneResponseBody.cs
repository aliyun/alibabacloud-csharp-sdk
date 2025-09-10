// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class RecognizeSceneResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeSceneResponseBodyData Data { get; set; }
        public class RecognizeSceneResponseBodyData : TeaModel {
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<RecognizeSceneResponseBodyDataTags> Tags { get; set; }
            public class RecognizeSceneResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>79</para>
                /// </summary>
                [NameInMap("Confidence")]
                [Validation(Required=false)]
                public float? Confidence { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AC79F887-5CCB-42BE-8AC3-4D455EFEDB94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
