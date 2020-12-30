// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagECRouteBackupAttributeResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("HcIp")]
        [Validation(Required=false)]
        public string HcIp { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ExpressConnectionInterface")]
        [Validation(Required=false)]
        public string ExpressConnectionInterface { get; set; }

        [NameInMap("RouteBackup")]
        [Validation(Required=false)]
        public bool? RouteBackup { get; set; }

        [NameInMap("ExpressConnectionNexthop")]
        [Validation(Required=false)]
        public string ExpressConnectionNexthop { get; set; }

        [NameInMap("SagId")]
        [Validation(Required=false)]
        public string SagId { get; set; }

        [NameInMap("Cidrs")]
        [Validation(Required=false)]
        public DescribeSagECRouteBackupAttributeResponseBodyCidrs Cidrs { get; set; }
        public class DescribeSagECRouteBackupAttributeResponseBodyCidrs : TeaModel {
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public List<DescribeSagECRouteBackupAttributeResponseBodyCidrsCidr> Cidr { get; set; }
            public class DescribeSagECRouteBackupAttributeResponseBodyCidrsCidr : TeaModel {
                public bool? EnableBackup { get; set; }
                public string Cidr { get; set; }
            }
        };

    }

}
