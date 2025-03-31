// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListServicesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Cloud-native API Gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cpv4sqdl*****</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-service</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number to return. Pages start from page 1. Default value: 1.</para>
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
        /// <para>The service source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MSE_NACOS: a service in an MSE Nacos instance</description></item>
        /// <item><description>K8S: a service in a Kubernetes (K8s) cluster in Container Service for Kubernetes (ACK)</description></item>
        /// <item><description>FC3: a service in Function Compute</description></item>
        /// <item><description>VIP: a fixed address</description></item>
        /// <item><description>DNS: a domain name</description></item>
        /// </list>
        /// <para>Enumerated values:</para>
        /// <list type="bullet">
        /// <item><description>K8S</description></item>
        /// <item><description>FC3</description></item>
        /// <item><description>DNS</description></item>
        /// <item><description>VIP</description></item>
        /// <item><description>MSE_NACOS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MSE_NACOS</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
