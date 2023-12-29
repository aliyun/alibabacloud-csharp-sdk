// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class GetFusionAuthTokenRequest : TeaModel {
        /// <summary>
        /// The bundle ID of the app. This parameter is required when Platform is set to iOS.
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// The validity period of the token. Unit: seconds. Valid values: 900 to 43200.
        /// </summary>
        [NameInMap("DurationSeconds")]
        [Validation(Required=false)]
        public long? DurationSeconds { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The package name of the app. This parameter is required when Platform is set to Android.
        /// </summary>
        [NameInMap("PackageName")]
        [Validation(Required=false)]
        public string PackageName { get; set; }

        /// <summary>
        /// The package signature of the app. This parameter is required when Platform is set to Android.
        /// </summary>
        [NameInMap("PackageSign")]
        [Validation(Required=false)]
        public string PackageSign { get; set; }

        /// <summary>
        /// The platform type. Valid values: Android and iOS.
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The service code.
        /// </summary>
        [NameInMap("SchemeCode")]
        [Validation(Required=false)]
        public string SchemeCode { get; set; }

    }

}
