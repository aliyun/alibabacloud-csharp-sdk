// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListExternalServicesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return only services that have not been imported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("importableOnly")]
        [Validation(Required=false)]
        public bool? ImportableOnly { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. Valid range: (0, 100]. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The API name for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imah</para>
        /// </summary>
        [NameInMap("nameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        /// <summary>
        /// <para>The workspace ID of the PAI-EAS service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>667435</para>
        /// </summary>
        [NameInMap("paiWorkspaceId")]
        [Validation(Required=false)]
        public string PaiWorkspaceId { get; set; }

        /// <summary>
        /// <para>The service source type used to filter results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MSE_NACOS: services from MSE Nacos.</description></item>
        /// <item><description>K8S: services from a Kubernetes cluster in Container Service.</description></item>
        /// <item><description>FC3: services from Function Compute.</description></item>
        /// <item><description>VIP: services from a fixed address.</description></item>
        /// <item><description>DNS: services from a domain name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FC3</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
