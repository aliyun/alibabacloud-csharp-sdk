// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class GetErrorCodeSolutionsRequest : TeaModel {
        /// <summary>
        /// <para>The language of the solution. Valid values: zh-CN and en-US. Not all of the solutions are available in English. If you set this parameter to en-US, but the corresponding solution is actually not available in English, no response is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("acceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The error code based on which you want to query a solution.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IncorrectStatus.TransitRouter</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message for which you want to query a solution. This parameter must be configured together with the errorCode parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The resource is not in a valid state for the operation.</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The product code. You can use one of the following methods to query a product code:</para>
        /// <list type="bullet">
        /// <item><description><para>Call the GetRequestLog operation to query a product code from the response.</para>
        /// </description></item>
        /// <item><description><para>Query the code of a product in the OpenAPI Explorer URL of the product. For example, the OpenAPI Explorer URL of Short Message Service (SMS) is https\://api.alibabacloud.com/product/Dysmsapi. Therefore, the product code of SMS is Dysmsapi.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ecs</para>
        /// </summary>
        [NameInMap("product")]
        [Validation(Required=false)]
        public string Product { get; set; }

    }

}
