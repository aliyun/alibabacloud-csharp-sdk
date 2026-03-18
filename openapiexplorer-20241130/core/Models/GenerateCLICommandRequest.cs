// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class GenerateCLICommandRequest : TeaModel {
        /// <summary>
        /// <para>Enable aggregation. If enabled, the CLI automatically reads full data using pagination and aggregates the results.</para>
        /// <remarks>
        /// <para>Warning: </para>
        /// </remarks>
        /// <para>You can use this option only with List operations that support pagination.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enable</para>
        /// </description></item>
        /// <item><description><para>false: Disable</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("aggregatePagination")]
        [Validation(Required=false)]
        public bool? AggregatePagination { get; set; }

        /// <summary>
        /// <para>API name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DescribeRegions</para>
        /// </summary>
        [NameInMap("api")]
        [Validation(Required=false)]
        public string Api { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Request parameters.</para>
        /// </summary>
        [NameInMap("apiParams")]
        [Validation(Required=false)]
        [Obsolete]
        public Dictionary<string, object> ApiParams { get; set; }

        /// <summary>
        /// <para>API version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2014-05-26</para>
        /// </summary>
        [NameInMap("apiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// <para>API input parameters in JSON format. This parameter has lower priority than apiParams. If you set apiParams, this parameter is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;InstanceChargeType&quot;: &quot;PostPaid&quot;,
        ///     &quot;ResourceType&quot;: &quot;instance&quot;,
        ///     &quot;AcceptLanguage&quot;: &quot;en-US&quot;
        /// }</para>
        /// </summary>
        [NameInMap("jsonApiParams")]
        [Validation(Required=false)]
        public string JsonApiParams { get; set; }

        /// <summary>
        /// <para>Product code.</para>
        /// <list type="bullet">
        /// <item><description><para>Call the GetRequestLog operation and get the product code from the response.</para>
        /// </description></item>
        /// <item><description><para>Find the product code in the OpenAPI portal URL. For example, the OpenAPI portal URL for Short Message Service is https\://api.aliyun.com/product/Dysmsapi. The product code for Short Message Service is Dysmsapi. In international regions, the URL is https\://api.alibabacloud.com/product/Dysmsapi. The product code remains Dysmsapi.</para>
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

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
