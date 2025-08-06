// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class EditAppInfoRequest : TeaModel {
        [NameInMap("AppItemId")]
        [Validation(Required=false)]
        public string AppItemId { get; set; }

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

        [NameInMap("Platforms")]
        [Validation(Required=false)]
        public List<EditAppInfoRequestPlatforms> Platforms { get; set; }
        public class EditAppInfoRequestPlatforms : TeaModel {
            [NameInMap("PkgName")]
            [Validation(Required=false)]
            public string PkgName { get; set; }

            [NameInMap("PkgSignature")]
            [Validation(Required=false)]
            public string PkgSignature { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PlatformType")]
            [Validation(Required=false)]
            public long? PlatformType { get; set; }

        }

    }

}
