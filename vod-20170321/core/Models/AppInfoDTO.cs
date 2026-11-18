// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AppInfoDTO : TeaModel {
        /// <summary>
        /// <para>The application name.</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The application type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Common application.</description></item>
        /// <item><description>2: Embedded SDK.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public int? AppType { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// </summary>
        [NameInMap("ItemId")]
        [Validation(Required=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// </summary>
        [NameInMap("ModificationTime")]
        [Validation(Required=false)]
        public string ModificationTime { get; set; }

        /// <summary>
        /// <para>The list of platform information for the application.</para>
        /// </summary>
        [NameInMap("Platforms")]
        [Validation(Required=false)]
        public List<AppInfoDTOPlatforms> Platforms { get; set; }
        public class AppInfoDTOPlatforms : TeaModel {
            /// <summary>
            /// <para>The platform ID.</para>
            /// </summary>
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// <para>The list of licenses.</para>
            /// </summary>
            [NameInMap("LicenseItemIds")]
            [Validation(Required=false)]
            public List<string> LicenseItemIds { get; set; }

            /// <summary>
            /// <para>The package name.</para>
            /// </summary>
            [NameInMap("PkgName")]
            [Validation(Required=false)]
            public string PkgName { get; set; }

            /// <summary>
            /// <para>The package signature.</para>
            /// </summary>
            [NameInMap("PkgSignature")]
            [Validation(Required=false)]
            public string PkgSignature { get; set; }

            /// <summary>
            /// <para>The platform type.</para>
            /// </summary>
            [NameInMap("PlatformType")]
            [Validation(Required=false)]
            public long? PlatformType { get; set; }

            /// <summary>
            /// <para>The platform type.</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public long? Type { get; set; }

        }

        /// <summary>
        /// <para>The user ID.</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
