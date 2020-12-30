// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribePbrInterfacesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PbrInterfaces")]
        [Validation(Required=false)]
        public DescribePbrInterfacesResponseBodyPbrInterfaces PbrInterfaces { get; set; }
        public class DescribePbrInterfacesResponseBodyPbrInterfaces : TeaModel {
            [NameInMap("PbrInterface")]
            [Validation(Required=false)]
            public List<DescribePbrInterfacesResponseBodyPbrInterfacesPbrInterface> PbrInterface { get; set; }
            public class DescribePbrInterfacesResponseBodyPbrInterfacesPbrInterface : TeaModel {
                public string Action { get; set; }
                public string InterfaceName { get; set; }
                public string HealthCheckInstanceId { get; set; }
                public int? Priority { get; set; }
            }
        };

    }

}
