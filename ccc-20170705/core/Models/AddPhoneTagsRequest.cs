// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class AddPhoneTagsRequest : TeaModel {
        [NameInMap("Concurrency")]
        [Validation(Required=false)]
        public int? Concurrency { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PhoneNumberList")]
        [Validation(Required=false)]
        public List<string> PhoneNumberList { get; set; }

        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        [NameInMap("RegionNameCity")]
        [Validation(Required=false)]
        public string RegionNameCity { get; set; }

        [NameInMap("RegionNameProvince")]
        [Validation(Required=false)]
        public string RegionNameProvince { get; set; }

        [NameInMap("ServiceTag")]
        [Validation(Required=false)]
        public string ServiceTag { get; set; }

        [NameInMap("SipTag")]
        [Validation(Required=false)]
        public string SipTag { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
