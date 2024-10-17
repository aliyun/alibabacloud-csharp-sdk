// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AppInfoDTO : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1-普通应用，2-内嵌SDK.</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public int? AppType { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("ItemId")]
        [Validation(Required=false)]
        public string ItemId { get; set; }

        [NameInMap("Platforms")]
        [Validation(Required=false)]
        public List<AppInfoDTOPlatforms> Platforms { get; set; }
        public class AppInfoDTOPlatforms : TeaModel {
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("LicenseItemIds")]
            [Validation(Required=false)]
            public List<string> LicenseItemIds { get; set; }

            [NameInMap("PkgName")]
            [Validation(Required=false)]
            public string PkgName { get; set; }

            [NameInMap("PkgSignature")]
            [Validation(Required=false)]
            public string PkgSignature { get; set; }

            [NameInMap("PlatformType")]
            [Validation(Required=false)]
            public long? PlatformType { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public long? Type { get; set; }

        }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
