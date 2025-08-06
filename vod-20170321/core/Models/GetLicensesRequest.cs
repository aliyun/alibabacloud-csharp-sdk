// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetLicensesRequest : TeaModel {
        [NameInMap("AppItemId")]
        [Validation(Required=false)]
        public string AppItemId { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        [NameInMap("NeedTotalCount")]
        [Validation(Required=false)]
        public bool? NeedTotalCount { get; set; }

        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PkgName")]
        [Validation(Required=false)]
        public string PkgName { get; set; }

        [NameInMap("PlatformType")]
        [Validation(Required=false)]
        public long? PlatformType { get; set; }

    }

}
