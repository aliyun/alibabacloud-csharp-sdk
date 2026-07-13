// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateRecursionZoneEffectiveScopeShrinkRequest : TeaModel {
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
        public string EffectiveScopesShrink { get; set; }

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
