// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGlobalPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>Filters by mounted resource type. This parameter takes effect only for the BlackOrWhite policy type. By default, the Gateway, Domain, and Route types are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Gateway</para>
        /// </summary>
        [NameInMap("attachResourceType")]
        [Validation(Required=false)]
        public string AttachResourceType { get; set; }

        /// <summary>
        /// <para>The policy class name. You can specify multiple values separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JWTAuth,OIDCAuth,ExternalZAuth</para>
        /// </summary>
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>Filters by enabling status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>Filters by environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-xxxx</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>Filters by gateway ID at the attachment level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xxxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The global policy type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GlobalAuth</para>
        /// </summary>
        [NameInMap("globalPolicyType")]
        [Validation(Required=false)]
        public string GlobalPolicyType { get; set; }

        /// <summary>
        /// <para>Filters by IP content by performing a LIKE query on the configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.3.4</para>
        /// </summary>
        [NameInMap("ipAccessControlContent")]
        [Validation(Required=false)]
        public string IpAccessControlContent { get; set; }

        /// <summary>
        /// <para>Filters by protocol layer. If you specify L4, configurations containing L4 are queried. If you specify L7, configurations that do not contain L4 are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>L7</para>
        /// </summary>
        [NameInMap("ipAccessControlProtocolLayer")]
        [Validation(Required=false)]
        public string IpAccessControlProtocolLayer { get; set; }

        /// <summary>
        /// <para>Filters by resource name by performing a LIKE query on the configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-route</para>
        /// </summary>
        [NameInMap("ipAccessControlResourceName")]
        [Validation(Required=false)]
        public string IpAccessControlResourceName { get; set; }

        /// <summary>
        /// <para>Filters by IP access control type by performing a LIKE query on the configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>White / Black</para>
        /// </summary>
        [NameInMap("ipAccessControlType")]
        [Validation(Required=false)]
        public string IpAccessControlType { get; set; }

        /// <summary>
        /// <para>Filters by exact policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-jwt-auth</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
