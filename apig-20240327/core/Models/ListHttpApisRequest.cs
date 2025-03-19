// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListHttpApisRequest : TeaModel {
        /// <summary>
        /// <para>Cloud-native API Gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq2avtllh****</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>Search keyword, supports fuzzy search by API name or exact search by API ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>Exact search by name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>login</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Page number, starting from 1, default is 1 if not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, valid range [1, 100], default is 10 if not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ahr5uil8raz0rq3b</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Type of HTTP API. Multiple types can be passed, separated by &quot;,&quot;.</para>
        /// <list type="bullet">
        /// <item><description>Http</description></item>
        /// <item><description>Rest</description></item>
        /// <item><description>WebSocket</description></item>
        /// <item><description>HttpIngress</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Http,Rest</para>
        /// </summary>
        [NameInMap("types")]
        [Validation(Required=false)]
        public string Types { get; set; }

        /// <summary>
        /// <para>Each API information in the response carries consumer authentication policy information for the specified environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-xxx</para>
        /// </summary>
        [NameInMap("withAuthPolicyInEnvironmentId")]
        [Validation(Required=false)]
        public string WithAuthPolicyInEnvironmentId { get; set; }

        /// <summary>
        /// <para>Whether the authentication policy is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withAuthPolicyList")]
        [Validation(Required=false)]
        public bool? WithAuthPolicyList { get; set; }

        /// <summary>
        /// <para>Each API information in the response carries a list of authorization rules for the specified consumer ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-xxx</para>
        /// </summary>
        [NameInMap("withConsumerInfoById")]
        [Validation(Required=false)]
        public string WithConsumerInfoById { get; set; }

        /// <summary>
        /// <para>Environment information</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withEnvironmentInfo")]
        [Validation(Required=false)]
        public bool? WithEnvironmentInfo { get; set; }

        /// <summary>
        /// <para>Environment ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-ctovu5mm1hksb4q8ln40</para>
        /// </summary>
        [NameInMap("withEnvironmentInfoById")]
        [Validation(Required=false)]
        public string WithEnvironmentInfoById { get; set; }

        /// <summary>
        /// <para>Ingress information</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("withIngressInfo")]
        [Validation(Required=false)]
        public bool? WithIngressInfo { get; set; }

        /// <summary>
        /// <para>Plugin ID, used to get plugin release information based on this ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-ct9qn3um1hktue8dqol0</para>
        /// </summary>
        [NameInMap("withPluginAttachmentByPluginId")]
        [Validation(Required=false)]
        public string WithPluginAttachmentByPluginId { get; set; }

    }

}
