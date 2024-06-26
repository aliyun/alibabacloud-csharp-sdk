// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreateAccessTokenRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AccessTokenLifetime")]
        [Validation(Required=false)]
        public string AccessTokenLifetime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrganizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RefreshTokenLifetime")]
        [Validation(Required=false)]
        public string RefreshTokenLifetime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
