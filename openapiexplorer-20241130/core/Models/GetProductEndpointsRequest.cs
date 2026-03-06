// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class GetProductEndpointsRequest : TeaModel {
        /// <summary>
        /// <para>The product code.</para>
        /// <list type="bullet">
        /// <item><description><para>Call the GetRequestLog operation and find the product code in the response.</para>
        /// </description></item>
        /// <item><description><para>Find the product code in the URL of the OpenAPI Portal page for the product. For example, &lt;props=&quot;china&quot;&gt;the URL for the Short Message Service (SMS) OpenAPI Portal page is https\://api.aliyun.com/product/Dysmsapi. The product code is Dysmsapi.
        /// &lt;props=&quot;intl&quot;&gt;the URL for the Short Message Service (SMS) OpenAPI Portal page is https\://api.alibabacloud.com/product/Dysmsapi. The product code is Dysmsapi.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ecs</para>
        /// </summary>
        [NameInMap("product")]
        [Validation(Required=false)]
        public string Product { get; set; }

    }

}
