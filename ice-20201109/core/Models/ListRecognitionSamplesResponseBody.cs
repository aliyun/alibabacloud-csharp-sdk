// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListRecognitionSamplesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx-xxxx-xxxxx-xxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Samples")]
        [Validation(Required=false)]
        public ListRecognitionSamplesResponseBodySamples Samples { get; set; }
        public class ListRecognitionSamplesResponseBodySamples : TeaModel {
            [NameInMap("Sample")]
            [Validation(Required=false)]
            public List<ListRecognitionSamplesResponseBodySamplesSample> Sample { get; set; }
            public class ListRecognitionSamplesResponseBodySamplesSample : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://example.com/sample.png">https://example.com/sample.png</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("SampleId")]
                [Validation(Required=false)]
                public string SampleId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
