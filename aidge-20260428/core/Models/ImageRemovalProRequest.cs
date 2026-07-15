// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageRemovalProRequest : TeaModel {
        /// <summary>
        /// <para>The call type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: asynchronous.</description></item>
        /// <item><description>false: synchronous.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// <para>The URL of the image to process.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cbu01.alicdn.com/imgextra/i2/1067106875/O1CN013rvpXP20enxPQttb3_!!4611686018427380283-0-item_pic.jpg">https://cbu01.alicdn.com/imgextra/i2/1067106875/O1CN013rvpXP20enxPQttb3_!!4611686018427380283-0-item_pic.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

    }

}
