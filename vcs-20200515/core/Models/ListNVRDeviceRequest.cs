// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListNVRDeviceRequest : TeaModel {
        [NameInMap("DeviceCode")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        [NameInMap("CorpIdList")]
        [Validation(Required=false)]
        public string CorpIdList { get; set; }

        [NameInMap("IsPage")]
        [Validation(Required=false)]
        public long IsPage { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long PageSize { get; set; }

    }

}
