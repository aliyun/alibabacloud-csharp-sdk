// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ValidateDnsGtmCnameRrCanUseRequest : TeaModel {
        [NameInMap("CnameMode")]
        [Validation(Required=false)]
        public string CnameMode { get; set; }

        [NameInMap("CnameRr")]
        [Validation(Required=false)]
        public string CnameRr { get; set; }

        [NameInMap("CnameType")]
        [Validation(Required=false)]
        public string CnameType { get; set; }

        [NameInMap("CnameZone")]
        [Validation(Required=false)]
        public string CnameZone { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
