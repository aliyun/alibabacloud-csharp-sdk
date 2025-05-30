// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetServiceListenersRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the MSE instance to which the service belongs.</para>
        /// <remarks>
        /// <para> You must specify InstanceId or ClusterId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mse-09k1q11****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        [Obsolete]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the cluster to which the service belongs.</para>
        /// <remarks>
        /// <para>The cluster is a concept for Nacos services and is not equivalent to a Microservices Engine (MSE) instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The group to which the service belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WEB_GROUP</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("HasIpCount")]
        [Validation(Required=false)]
        public string HasIpCount { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which the service belongs.</para>
        /// <remarks>
        /// <para>You must specify InstanceId or ClusterId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mse_prepaid_public_cn-tl32odtt20j</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The namespace to which the service belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddaf8f12-****-b1c1-86e7c72e266b</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The extended request parameters in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        /// <summary>
        /// <para>The name of the service whose listeners you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zeekr-orderboss</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
