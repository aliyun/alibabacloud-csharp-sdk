// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class SizeChartDetectRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the image to detect.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i4/1822632490/O1CN01pbENR21UGT9w3a6gU_!!1822632490.jpg">https://img.alicdn.com/imgextra/i4/1822632490/O1CN01pbENR21UGT9w3a6gU_!!1822632490.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The detection threshold. Valid values: 0 to 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
