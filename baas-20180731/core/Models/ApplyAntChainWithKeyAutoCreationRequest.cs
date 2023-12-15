// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class ApplyAntChainWithKeyAutoCreationRequest : TeaModel {
        [NameInMap("AntChainId")]
        [Validation(Required=false)]
        public string AntChainId { get; set; }

        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        [NameInMap("ConsortiumId")]
        [Validation(Required=false)]
        public string ConsortiumId { get; set; }

        [NameInMap("CountryName")]
        [Validation(Required=false)]
        public string CountryName { get; set; }

        [NameInMap("LocalityName")]
        [Validation(Required=false)]
        public string LocalityName { get; set; }

        [NameInMap("OrganizationName")]
        [Validation(Required=false)]
        public string OrganizationName { get; set; }

        [NameInMap("OrganizationUnitName")]
        [Validation(Required=false)]
        public string OrganizationUnitName { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("StateOrProvinceName")]
        [Validation(Required=false)]
        public string StateOrProvinceName { get; set; }

    }

}
