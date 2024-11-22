// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchPutKvWithHighCapacityAdvanceRequest : TeaModel {
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

        /// <summary>
        /// <para>The download URL of the key-value pairs that you want to configure. This parameter is automatically filled in when you use the SDK to call the operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxobject.oss-cn-reginon.aliyuncs.com/9d91_xxxxxxxxxxx_158bb6e0f97c477791209bb46bd599f7">https://xxxobject.oss-cn-reginon.aliyuncs.com/9d91_xxxxxxxxxxx_158bb6e0f97c477791209bb46bd599f7</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public Stream UrlObject { get; set; }

    }

}
