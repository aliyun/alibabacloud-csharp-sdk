// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateRecursionZoneEffectiveScopeRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token to ensure request idempotence. The token must be unique for each request. It can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21079fa016944979537637959d09bc</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>A list of effective scopes.</para>
        /// </summary>
        [NameInMap("EffectiveScopes")]
        [Validation(Required=false)]
        public List<UpdateRecursionZoneEffectiveScopeRequestEffectiveScopes> EffectiveScopes { get; set; }
        public class UpdateRecursionZoneEffectiveScopeRequestEffectiveScopes : TeaModel {
            /// <summary>
            /// <para>The type of the effective scope. Valid value: <em>account</em>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>account</para>
            /// </summary>
            [NameInMap("EffectiveType")]
            [Validation(Required=false)]
            public string EffectiveType { get; set; }

            /// <summary>
            /// <para>The values for the scope, which depend on the value of <c>EffectiveType</c>. If <c>EffectiveType</c> is set to <c>account</c>, this parameter is a list of account IDs.</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public List<string> Scope { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173671468000011</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
