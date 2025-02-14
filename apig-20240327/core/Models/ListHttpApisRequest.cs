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
        /// <para>Page number, starting from 1, default is 1 if not provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, valid range [1, 100], default is 10 if not provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Type of HTTP API. Supports multiple types, separated by &quot;,&quot;.</para>
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
        /// <para>Each API information in the response carries consumer authentication policy information under the specified environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-xxx</para>
        /// </summary>
        [NameInMap("withAuthPolicyInEnvironmentId")]
        [Validation(Required=false)]
        public string WithAuthPolicyInEnvironmentId { get; set; }

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

        [NameInMap("withEnvironmentInfo")]
        [Validation(Required=false)]
        public bool? WithEnvironmentInfo { get; set; }

        [NameInMap("withEnvironmentInfoById")]
        [Validation(Required=false)]
        public string WithEnvironmentInfoById { get; set; }

        [NameInMap("withIngressInfo")]
        [Validation(Required=false)]
        public bool? WithIngressInfo { get; set; }

        [NameInMap("withPluginAttachmentByPluginId")]
        [Validation(Required=false)]
        public string WithPluginAttachmentByPluginId { get; set; }

    }

}
