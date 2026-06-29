// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListServicesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud-native API gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cpv4sqdl*****</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The service name for exact match query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-service</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
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
        /// <para>rg-acfmxxe5rc6cvla</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The source type of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MSE_NACOS: The service is from MSE Nacos.</description></item>
        /// <item><description>K8S: The service is from a Kubernetes cluster in Container Service.</description></item>
        /// <item><description>FC3: The service is from Function Compute.</description></item>
        /// <item><description>VIP: The service is from a fixed address.</description></item>
        /// <item><description>DNS: The service is from a domain name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MSE_NACOS</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The list of service source types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;K8S&quot;, &quot;FC3&quot;]</para>
        /// </summary>
        [NameInMap("sourceTypes")]
        [Validation(Required=false)]
        public string SourceTypes { get; set; }

    }

}
