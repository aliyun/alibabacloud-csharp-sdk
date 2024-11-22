// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchDeleteKvRequest : TeaModel {
        /// <summary>
        /// <para>The keys that you want to delete. You can delete a maximum of 10,000 key-value pairs at a time.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public List<string> Keys { get; set; }

        /// <summary>
        /// <para>The name of the namespace that you specify when you call the <a href="https://help.aliyun.com/document_detail/2850317.html">CreateKvNamespace</a> operation.</para>
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
