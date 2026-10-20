// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MerchandisePlacementDetectionProRequest : TeaModel {
        /// <summary>
        /// <para>The HTTPS URL of the display image to detect.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/image.jpg">https://example.com/image.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The detection rule. When non-empty, this value takes priority as the model prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Identify all Genki Forest beverages on the shelf and mark their positions</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>The product type. This parameter must be set to Genki Forest when Rule is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>元气森林</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
