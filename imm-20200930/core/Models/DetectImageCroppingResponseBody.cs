// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DetectImageCroppingResponseBody : TeaModel {
        /// <summary>
        /// <para>The image croppings.</para>
        /// </summary>
        [NameInMap("Croppings")]
        [Validation(Required=false)]
        public List<CroppingSuggestion> Croppings { get; set; }

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
