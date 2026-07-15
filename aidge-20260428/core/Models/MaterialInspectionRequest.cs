// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class MaterialInspectionRequest : TeaModel {
        /// <summary>
        /// <para>apiId</para>
        /// 
        /// <b>Example:</b>
        /// <para>fb0012f49b004f889207a3c5e6ef8da9</para>
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The URL of the reference image. When this parameter is not empty, multi-image comparison mode is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/reference.jpg">https://example.com/reference.jpg</a></para>
        /// </summary>
        [NameInMap("ImageRefer")]
        [Validation(Required=false)]
        public string ImageRefer { get; set; }

        /// <summary>
        /// <para>The URL of the target image to inspect.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/store.jpg">https://example.com/store.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The business request identity. This value is returned as-is in the response for Tracing Analysis purposes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-2026-06-04-001</para>
        /// </summary>
        [NameInMap("ReqId")]
        [Validation(Required=false)]
        public string ReqId { get; set; }

        /// <summary>
        /// <para>The rule prompt in natural language that defines the inspection criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>门型展架必须摆放在入口区域；功能台卡必须摆放在中柜台面</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

    }

}
