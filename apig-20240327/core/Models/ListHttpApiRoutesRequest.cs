// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListHttpApiRoutesRequest : TeaModel {
        [NameInMap("consumerAuthorizationRuleId")]
        [Validation(Required=false)]
        public string ConsumerAuthorizationRuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NotDeployed</para>
        /// </summary>
        [NameInMap("deployStatuses")]
        [Validation(Required=false)]
        public string DeployStatuses { get; set; }

        [NameInMap("domainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>env-cpqnr6tlhtgubc***</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gw-cpv4sqdl****</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>itemcenter-gateway</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>item</para>
        /// </summary>
        [NameInMap("nameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/v1</para>
        /// </summary>
        [NameInMap("pathLike")]
        [Validation(Required=false)]
        public string PathLike { get; set; }

        [NameInMap("withAuthPolicyInfo")]
        [Validation(Required=false)]
        public bool? WithAuthPolicyInfo { get; set; }

        [NameInMap("withConsumerInfoById")]
        [Validation(Required=false)]
        public string WithConsumerInfoById { get; set; }

        [NameInMap("withPluginAttachmentByPluginId")]
        [Validation(Required=false)]
        public string WithPluginAttachmentByPluginId { get; set; }

    }

}
