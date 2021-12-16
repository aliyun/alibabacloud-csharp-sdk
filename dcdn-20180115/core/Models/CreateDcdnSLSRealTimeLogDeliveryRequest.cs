// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateDcdnSLSRealTimeLogDeliveryRequest : TeaModel {
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("SLSLogStore")]
        [Validation(Required=false)]
        public string SLSLogStore { get; set; }

        [NameInMap("SLSProject")]
        [Validation(Required=false)]
        public string SLSProject { get; set; }

        [NameInMap("SLSRegion")]
        [Validation(Required=false)]
        public string SLSRegion { get; set; }

        [NameInMap("SamplingRate")]
        [Validation(Required=false)]
        public string SamplingRate { get; set; }

    }

}
