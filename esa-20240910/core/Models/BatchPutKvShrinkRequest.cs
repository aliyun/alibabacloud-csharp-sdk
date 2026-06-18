// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchPutKvShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of key-value pairs to set. The total size cannot exceed 2 MB (2 × 1,000 × 1,000).</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("KvList")]
        [Validation(Required=false)]
        public string KvListShrink { get; set; }

        /// <summary>
        /// <para>The name specified when you call <a href="https://help.aliyun.com/document_detail/2850317.html">CreateKvNamespace</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}
