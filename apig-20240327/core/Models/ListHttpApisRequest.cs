// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListHttpApisRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud-native API Gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq2avtllh****</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The search keyword. You can fuzzy-search by API name or exact-search by API ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The API name that is used for the search. In this case, exact search is performed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>login</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ahr5uil8raz0rq3b</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The API type. You can specify multiple types and separate them with a comma (,).</para>
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

        [NameInMap("withAPIsPublishedToEnvironment")]
        [Validation(Required=false)]
        public bool? WithAPIsPublishedToEnvironment { get; set; }

        /// <summary>
        /// <para>The consumer authentication policy in the specified environment in each returned API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-xxx</para>
        /// </summary>
        [NameInMap("withAuthPolicyInEnvironmentId")]
        [Validation(Required=false)]
        public string WithAuthPolicyInEnvironmentId { get; set; }

        /// <summary>
        /// <para>Specifies whether authentication is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withAuthPolicyList")]
        [Validation(Required=false)]
        public bool? WithAuthPolicyList { get; set; }

        /// <summary>
        /// <para>The authorization rules of the specified consumer in each returned API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-xxx</para>
        /// </summary>
        [NameInMap("withConsumerInfoById")]
        [Validation(Required=false)]
        public string WithConsumerInfoById { get; set; }

        /// <summary>
        /// <para>The environment information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withEnvironmentInfo")]
        [Validation(Required=false)]
        public bool? WithEnvironmentInfo { get; set; }

        /// <summary>
        /// <para>The environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-ctovu5mm1hksb4q8ln40</para>
        /// </summary>
        [NameInMap("withEnvironmentInfoById")]
        [Validation(Required=false)]
        public string WithEnvironmentInfoById { get; set; }

        /// <summary>
        /// <para>The Ingress information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("withIngressInfo")]
        [Validation(Required=false)]
        public bool? WithIngressInfo { get; set; }

        /// <summary>
        /// <para>The plug-in ID. You can use the returned value of this parameter to query the plug-in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-ct9qn3um1hktue8dqol0</para>
        /// </summary>
        [NameInMap("withPluginAttachmentByPluginId")]
        [Validation(Required=false)]
        public string WithPluginAttachmentByPluginId { get; set; }

        [NameInMap("withPolicyConfigs")]
        [Validation(Required=false)]
        public bool? WithPolicyConfigs { get; set; }

    }

}
