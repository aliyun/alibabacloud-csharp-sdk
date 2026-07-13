// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DeleteRecursionZoneRequest : TeaModel {
        /// <summary>
        /// <para>A client token used to ensure the idempotence of the request.</para>
        /// <para>Generate a unique value from your client for each request. The ClientToken parameter supports only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21079fa016944979537637959d09bc</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The unique ID of the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>169783221000012</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
