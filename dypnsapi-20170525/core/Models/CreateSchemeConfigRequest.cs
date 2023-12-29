// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class CreateSchemeConfigRequest : TeaModel {
        /// <summary>
        /// The package name. This parameter is required when Platform is set to Android. The name must be 1 to 128 characters in length and can contain digits, letters, hyphens (-), underscores (\_), and periods (.).
        /// </summary>
        [NameInMap("AndroidPackageName")]
        [Validation(Required=false)]
        public string AndroidPackageName { get; set; }

        /// <summary>
        /// The package signature. This parameter is required when Platform is set to Android. The signature must be 32 characters in length and can contain digits and letters.
        /// </summary>
        [NameInMap("AndroidPackageSign")]
        [Validation(Required=false)]
        public string AndroidPackageSign { get; set; }

        /// <summary>
        /// The app name, which can be up to 20 characters in length and can contain letters.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// The reserved field. HTML5 apps are not supported.
        /// </summary>
        [NameInMap("H5Origin")]
        [Validation(Required=false)]
        public string H5Origin { get; set; }

        /// <summary>
        /// The reserved field. HTML5 apps are not supported.
        /// </summary>
        [NameInMap("H5Url")]
        [Validation(Required=false)]
        public string H5Url { get; set; }

        /// <summary>
        /// The bundle ID. This parameter is required when OsType is set to iOS. The bundle ID must be 1 to 128 characters in length and can contain digits, letters, hyphens (-), underscores (\_), and periods (.).
        /// </summary>
        [NameInMap("IosBundleId")]
        [Validation(Required=false)]
        public string IosBundleId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The app platform.
        /// 
        /// Valid values:
        /// 
        /// *   Android
        /// *   iOS
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
        /// The service name, which can be up to 10 characters in length and can contain letters.
        /// </summary>
        [NameInMap("SchemeName")]
        [Validation(Required=false)]
        public string SchemeName { get; set; }

    }

}
