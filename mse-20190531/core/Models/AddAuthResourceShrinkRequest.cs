// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddAuthResourceShrinkRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The ID of the authorization record.
        /// </summary>
        [NameInMap("AuthId")]
        [Validation(Required=false)]
        public long? AuthId { get; set; }

        [NameInMap("AuthResourceHeaderList")]
        [Validation(Required=false)]
        public string AuthResourceHeaderListShrink { get; set; }

        /// <summary>
        /// The ID of the domain name.
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public long? DomainId { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        [NameInMap("IgnoreCase")]
        [Validation(Required=false)]
        public bool? IgnoreCase { get; set; }

        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// The path.
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

    }

}
