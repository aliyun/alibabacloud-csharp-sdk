// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateRecursionZoneEffectiveScopeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>21079fa016944979537637959d09bc</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("EffectiveScopes")]
        [Validation(Required=false)]
        public List<UpdateRecursionZoneEffectiveScopeRequestEffectiveScopes> EffectiveScopes { get; set; }
        public class UpdateRecursionZoneEffectiveScopeRequestEffectiveScopes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>account</para>
            /// </summary>
            [NameInMap("EffectiveType")]
            [Validation(Required=false)]
            public string EffectiveType { get; set; }

            [NameInMap("Scope")]
            [Validation(Required=false)]
            public List<string> Scope { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>173671468000011</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
