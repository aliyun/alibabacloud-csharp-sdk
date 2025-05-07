// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Buss20220822.Models
{
    public class FindInstanceInfoShrinkRequest : TeaModel {
        [NameInMap("businessCodes")]
        [Validation(Required=false)]
        public string BusinessCodes { get; set; }

        [NameInMap("bussinessCode")]
        [Validation(Required=false)]
        public string BussinessCode { get; set; }

        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("extras")]
        [Validation(Required=false)]
        public string ExtrasShrink { get; set; }

        [NameInMap("ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("needDNS")]
        [Validation(Required=false)]
        public bool? NeedDNS { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
