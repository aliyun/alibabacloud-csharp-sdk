// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListServicesRequest : TeaModel {
        /// <summary>
        /// <para>Cloud-native API Gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cpv4sqdl*****</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>Exact query by service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-service</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Page number, starting from 1. Default is 1 if not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, valid range [1, 100]. Default is 10 if not specified.</para>
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
        /// <para>rg-acfmxxe5rc6cvla</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Query by service source type. Service sources:</para>
        /// <list type="bullet">
        /// <item><description>MSE_NACOS: Services from MSE Nacos.</description></item>
        /// <item><description>K8S: Services from K8S clusters in container services.</description></item>
        /// <item><description>FC3: Services from function computing.</description></item>
        /// <item><description>VIP: Services from a fixed address.</description></item>
        /// <item><description>DNS: Services from a domain name.</description></item>
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
