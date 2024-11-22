// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetKvRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to decode the value by using Base 64. If you call the <a href="https://help.aliyun.com/document_detail/2850482.html">PutKv</a> operation and set the Base64 parameter to true, set this parameter to true to read the original content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Base64")]
        [Validation(Required=false)]
        public bool? Base64 { get; set; }

        /// <summary>
        /// <para>The key name for the query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_key</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

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
