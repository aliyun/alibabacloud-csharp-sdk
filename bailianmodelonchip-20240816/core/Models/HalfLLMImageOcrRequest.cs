// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianModelOnChip20240816.Models
{
    public class HalfLLMImageOcrRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b504f84b69b9a73d3a21a2cff05e190</para>
        /// </summary>
        [NameInMap("deviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx/xx.jpg">https://xxx/xx.jpg</a></para>
        /// </summary>
        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-vl-ocr</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2oImhCz4f8XCviiM</para>
        /// </summary>
        [NameInMap("productKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>520539530998273</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
