// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DetectImageScoreResponseBody : TeaModel {
        /// <summary>
        /// <para>The quality score of the image.</para>
        /// </summary>
        [NameInMap("ImageScore")]
        [Validation(Required=false)]
        public DetectImageScoreResponseBodyImageScore ImageScore { get; set; }
        public class DetectImageScoreResponseBodyImageScore : TeaModel {
            /// <summary>
            /// <para>The overall quality score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("OverallQualityScore")]
            [Validation(Required=false)]
            public float? OverallQualityScore { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6E93D6C9-5AC0-49F9-914D-E02678D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
