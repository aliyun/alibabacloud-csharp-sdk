// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSafStartStepsRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("aliyunServer")]
        [Validation(Required=false)]
        public bool? AliyunServer { get; set; }

        [NameInMap("deviceTypesStr")]
        [Validation(Required=false)]
        public string DeviceTypesStr { get; set; }

        [NameInMap("eventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        [NameInMap("serverRegion")]
        [Validation(Required=false)]
        public string ServerRegion { get; set; }

    }

}
