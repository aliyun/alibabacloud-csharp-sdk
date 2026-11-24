// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MerchandisePlacementDetectionProRequest : TeaModel {
        /// <summary>
        /// <para>The HTTPS URL of the display image to be detected.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/image.jpg">https://example.com/image.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The detection rule. If this parameter is not empty, it takes precedence as the model prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Recognize all Genki Forest beverages on the shelf and draw bounding boxes around their positions</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>The product type. If the Rule parameter is empty, you must set this parameter to Genki Forest.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Genki Forest</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
