// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class GetApiDefinitionRequest : TeaModel {
        /// <summary>
        /// <para>The API name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DescribeRegions</para>
        /// </summary>
        [NameInMap("api")]
        [Validation(Required=false)]
        public string Api { get; set; }

        /// <summary>
        /// <para>The API version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2014-05-26</para>
        /// </summary>
        [NameInMap("apiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// <para>The product code.</para>
        /// <list type="bullet">
        /// <item><description><para>Call the GetRequestLog operation to obtain the product code from the response.</para>
        /// </description></item>
        /// <item><description><para>Find the product code in the product\&quot;s OpenAPI Portal URL. &lt;props=&quot;china&quot;&gt;For example, the OpenAPI Portal URL for Short Message Service is https\://api.aliyun.com/product/Dysmsapi. The product code for Short Message Service is Dysmsapi.
        /// &lt;props=&quot;intl&quot;&gt;For example, the OpenAPI Portal URL for Short Message Service is https\://api.alibabacloud.com/product/Dysmsapi. The product code for Short Message Service is Dysmsapi.</para>
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
