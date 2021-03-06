/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class AddConsumerRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        [NameInMap("Company")]
        [Validation(Required=false)]
        public string Company { get; set; }

        [NameInMap("Site")]
        [Validation(Required=false)]
        public string Site { get; set; }

        [NameInMap("Requirement")]
        [Validation(Required=false)]
        public string Requirement { get; set; }

        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("Ca")]
        [Validation(Required=false)]
        public string Ca { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("BandwidthRequirement")]
        [Validation(Required=false)]
        public string BandwidthRequirement { get; set; }

    }

}
