// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class UpdateOIDCProviderRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the client. If you want to specify multiple client IDs, separate the client IDs with commas (,).</para>
        /// <para>The client ID can contain letters, digits, and special characters and cannot start with the special characters. The special characters are <c>periods, (.), hyphens (-), underscores (_), colons (:), and forward slashes (/)</c>.``</para>
        /// <para>The client ID can be up to 64 characters in length.</para>
        /// <remarks>
        /// <para>If you specify this parameter, all the client IDs of the OIDC IdP are replaced. If you need to only add or remove a client ID, call the AddClientIdToOIDCProvider or RemoveClientIdFromOIDCProvider operation. For more information, see <a href="https://help.aliyun.com/document_detail/332057.html">AddClientIdToOIDCProvider</a> or <a href="https://help.aliyun.com/document_detail/332058.html">RemoveClientIdFromOIDCProvider</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>498469743454717****</para>
        /// </summary>
        [NameInMap("ClientIds")]
        [Validation(Required=false)]
        public string ClientIds { get; set; }

        /// <summary>
        /// <para>The earliest time when an external IdP can issue an ID token. If the value of the iat field in the ID token is later than the current time, the request is rejected. Unit: hours. Valid values: 1 to 168.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("IssuanceLimitTime")]
        [Validation(Required=false)]
        public long? IssuanceLimitTime { get; set; }

        /// <summary>
        /// <para>The description of the OIDC IdP.</para>
        /// <para>The description can be up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a new OIDC Provider.</para>
        /// </summary>
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        /// <summary>
        /// <para>The name of the OIDC IdP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestOIDCProvider</para>
        /// </summary>
        [NameInMap("OIDCProviderName")]
        [Validation(Required=false)]
        public string OIDCProviderName { get; set; }

    }

}
