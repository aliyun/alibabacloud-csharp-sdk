// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGlobalPoliciesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Gateway</para>
        /// </summary>
        [NameInMap("attachResourceType")]
        [Validation(Required=false)]
        public string AttachResourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>JWTAuth,OIDCAuth,ExternalZAuth</para>
        /// </summary>
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>env-xxxx</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gw-xxxx</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GlobalAuth</para>
        /// </summary>
        [NameInMap("globalPolicyType")]
        [Validation(Required=false)]
        public string GlobalPolicyType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.2.3.4</para>
        /// </summary>
        [NameInMap("ipAccessControlContent")]
        [Validation(Required=false)]
        public string IpAccessControlContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>L7</para>
        /// </summary>
        [NameInMap("ipAccessControlProtocolLayer")]
        [Validation(Required=false)]
        public string IpAccessControlProtocolLayer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-route</para>
        /// </summary>
        [NameInMap("ipAccessControlResourceName")]
        [Validation(Required=false)]
        public string IpAccessControlResourceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>White / Black</para>
        /// </summary>
        [NameInMap("ipAccessControlType")]
        [Validation(Required=false)]
        public string IpAccessControlType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-jwt-auth</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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

    }

}
