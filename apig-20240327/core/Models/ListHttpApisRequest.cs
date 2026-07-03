// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListHttpApisRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud-native API gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq2avtllh****</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The gateway type filter. Valid values: <b>AI</b> and <b>API</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>The search keyword. Supports fuzzy match by API name or exact search by API ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The exact name to search for.</para>
        /// 
        /// <b>Example:</b>
        /// <para>login</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1. Default value: 1.</para>
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
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ahr5uil8raz0rq3b</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of the HTTP API. You can specify multiple types separated by commas (,). Valid values:</para>
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
        /// <para>Specifies whether to return information about APIs published to the specified environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withAPIsPublishedToEnvironment")]
        [Validation(Required=false)]
        public bool? WithAPIsPublishedToEnvironment { get; set; }

        /// <summary>
        /// <para>The environment ID. If specified, the response includes consumer authentication policy information for each API in the specified environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-xxx</para>
        /// </summary>
        [NameInMap("withAuthPolicyInEnvironmentId")]
        [Validation(Required=false)]
        public string WithAuthPolicyInEnvironmentId { get; set; }

        /// <summary>
        /// <para>Specifies whether authentication policies are enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withAuthPolicyList")]
        [Validation(Required=false)]
        public bool? WithAuthPolicyList { get; set; }

        /// <summary>
        /// <para>The consumer ID. If specified, the response includes the authorization rule list for the specified consumer for each API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs-xxx</para>
        /// </summary>
        [NameInMap("withConsumerInfoById")]
        [Validation(Required=false)]
        public string WithConsumerInfoById { get; set; }

        /// <summary>
        /// <para>The environment context.</para>
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
        /// <para>Specifies whether to include ingress information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("withIngressInfo")]
        [Validation(Required=false)]
        public bool? WithIngressInfo { get; set; }

        /// <summary>
        /// <para>The plug-in ID. If specified, the response includes the plug-in publishing information for the specified plug-in.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl-ct9qn3um1hktue8dqol0</para>
        /// </summary>
        [NameInMap("withPluginAttachmentByPluginId")]
        [Validation(Required=false)]
        public string WithPluginAttachmentByPluginId { get; set; }

        /// <summary>
        /// <para>Specifies whether to include policy information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("withPolicyConfigs")]
        [Validation(Required=false)]
        public bool? WithPolicyConfigs { get; set; }

    }

}
