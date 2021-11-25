// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class GetCallsPerDayRequest : TeaModel {
        [NameInMap("DataId")]
        [Validation(Required=false)]
        public string DataId { get; set; }

        [NameInMap("DataIdEnd")]
        [Validation(Required=false)]
        public string DataIdEnd { get; set; }

        [NameInMap("DataIdStart")]
        [Validation(Required=false)]
        public string DataIdStart { get; set; }

        [NameInMap("HavePhoneNumbers")]
        [Validation(Required=false)]
        public string HavePhoneNumbers { get; set; }

        [NameInMap("HourId")]
        [Validation(Required=false)]
        public string HourId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MinuteId")]
        [Validation(Required=false)]
        public string MinuteId { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public string PhoneNumbers { get; set; }

    }

}
