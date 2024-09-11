// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdatePrivateAccessApplicationRequest : TeaModel {
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("L7ProxyDomainAutomaticPrefix")]
        [Validation(Required=false)]
        public string L7ProxyDomainAutomaticPrefix { get; set; }

        [NameInMap("L7ProxyDomainCustom")]
        [Validation(Required=false)]
        public string L7ProxyDomainCustom { get; set; }

        [NameInMap("L7ProxyDomainPrivate")]
        [Validation(Required=false)]
        public string L7ProxyDomainPrivate { get; set; }

        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<UpdatePrivateAccessApplicationRequestPortRanges> PortRanges { get; set; }
        public class UpdatePrivateAccessApplicationRequestPortRanges : TeaModel {
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public int? Begin { get; set; }

            [NameInMap("End")]
            [Validation(Required=false)]
            public int? End { get; set; }

        }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

    }

}
