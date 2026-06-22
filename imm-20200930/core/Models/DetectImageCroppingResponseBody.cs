// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DetectImageCroppingResponseBody : TeaModel {
        /// <summary>
        /// <para>The array of image cropping information.</para>
        /// </summary>
        [NameInMap("Croppings")]
        [Validation(Required=false)]
        public List<CroppingSuggestion> Croppings { get; set; }

        /// <summary>
        /// <para>The list of objects included in the cropping region, corresponding to the InclusionHints input parameter. This field is empty if no objects are included.</para>
        /// </summary>
        [NameInMap("MatchedInclusionHints")]
        [Validation(Required=false)]
        public List<string> MatchedInclusionHints { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91AC8C98-0F36-49D2-8290-742E24D*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
