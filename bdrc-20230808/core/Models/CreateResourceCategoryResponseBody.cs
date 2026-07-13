// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class CreateResourceCategoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateResourceCategoryResponseBodyData Data { get; set; }
        public class CreateResourceCategoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Resource category ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rc-123****7890</para>
            /// </summary>
            [NameInMap("ResourceCategoryId")]
            [Validation(Required=false)]
            public string ResourceCategoryId { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AF95C627-D725-5656-B128-B9BCCAF89025</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
