// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeComponentsJsResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration of the JavaScript file for the component.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {
        ///         &quot;js&quot;: &quot;<a href="https://xxxxx.oss-cn-zhangjiakou.aliyuncs.com/componentUpload/xxxxx">https://xxxxx.oss-cn-zhangjiakou.aliyuncs.com/componentUpload/xxxxx</a>&quot;,
        ///         &quot;name&quot;: &quot;python3&quot;,
        ///         &quot;ownType&quot;: &quot;sys&quot;
        ///     }
        /// ]</para>
        /// </summary>
        [NameInMap("ComponentsJs")]
        [Validation(Required=false)]
        public string ComponentsJs { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58A518BC-E4A8-5BD7-AFEA-366046ED9073</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
