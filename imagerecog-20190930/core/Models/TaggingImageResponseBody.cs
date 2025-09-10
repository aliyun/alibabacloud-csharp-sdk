// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class TaggingImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TaggingImageResponseBodyData Data { get; set; }
        public class TaggingImageResponseBodyData : TeaModel {
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<TaggingImageResponseBodyDataTags> Tags { get; set; }
            public class TaggingImageResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>65</para>
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
        /// <para>70ED13B0-BC22-576D-9CCF-1CC12FEAC477</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
