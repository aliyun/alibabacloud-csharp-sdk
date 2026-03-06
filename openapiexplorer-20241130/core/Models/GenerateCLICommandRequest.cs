// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenAPIExplorer20241130.Models
{
    public class GenerateCLICommandRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable aggregation. If you enable this feature, the CLI automatically reads full data by page and aggregates the results.</para>
        /// <remarks>
        /// <para>Warning: </para>
        /// </remarks>
        /// <para>Only List operations that support paging can use this switch.</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables aggregation.</para>
        /// </description></item>
        /// <item><description><para>false: disables aggregation.</para>
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
        /// <para>The name of the API.</para>
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
        /// <para>The request parameters.</para>
        /// </summary>
        [NameInMap("apiParams")]
        [Validation(Required=false)]
        [Obsolete]
        public Dictionary<string, object> ApiParams { get; set; }

        /// <summary>
        /// <para>The version of the API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2014-05-26</para>
        /// </summary>
        [NameInMap("apiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// <para>The request parameters for the API in JSON format. This parameter has a lower priority than \<c>apiParams\\</c>. If \<c>apiParams\\</c> is set, this parameter is ignored.</para>
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
        /// <para>The product code.</para>
        /// <list type="bullet">
        /// <item><description><para>Call the GetRequestLog operation to obtain the product code from the response.</para>
        /// </description></item>
        /// <item><description><para>Find the product code in the URL of the product in OpenAPI Portal. For example, &lt;props=&quot;china&quot;&gt;the OpenAPI Portal URL for Short Message Service is https\://api.aliyun.com/product/Dysmsapi. The product code for Short Message Service is Dysmsapi.
        /// &lt;props=&quot;intl&quot;&gt;the OpenAPI Portal URL for Short Message Service is https\://api.alibabacloud.com/product/Dysmsapi. The product code for Short Message Service is Dysmsapi.</para>
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
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
