// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class ApplyAntChainCertificateWithKeyAutoCreationRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AntChainId")]
        [Validation(Required=false)]
        public string AntChainId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsortiumId")]
        [Validation(Required=false)]
        public string ConsortiumId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CountryName")]
        [Validation(Required=false)]
        public string CountryName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("LocalityName")]
        [Validation(Required=false)]
        public string LocalityName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrganizationName")]
        [Validation(Required=false)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrganizationUnitName")]
        [Validation(Required=false)]
        public string OrganizationUnitName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StateOrProvinceName")]
        [Validation(Required=false)]
        public string StateOrProvinceName { get; set; }

    }

}
