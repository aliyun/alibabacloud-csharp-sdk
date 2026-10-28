// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class TokenSettings : TeaModel {
        /// <summary>
        /// <para>Specifies whether cross-account access through sharing links is allowed.</para>
        /// </summary>
        [NameInMap("EnableCrossAccountAccess")]
        [Validation(Required=false)]
        public bool? EnableCrossAccountAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether task logs can be downloaded through sharing links.</para>
        /// </summary>
        [NameInMap("EnableLogDownloadJob")]
        [Validation(Required=false)]
        public bool? EnableLogDownloadJob { get; set; }

    }

}
