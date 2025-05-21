// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiInfoByName : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>gw-xx</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-api</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Http</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("versionEnabled")]
        [Validation(Required=false)]
        public bool? VersionEnabled { get; set; }

        [NameInMap("versionedHttpApis")]
        [Validation(Required=false)]
        public List<HttpApiApiInfo> VersionedHttpApis { get; set; }

    }

}
