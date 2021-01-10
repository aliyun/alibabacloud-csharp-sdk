// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ScaleAKSClusterNodeRequest : TeaModel {
        [NameInMap("NodeSpecs")]
        [Validation(Required=false)]
        public List<ScaleAKSClusterNodeRequestNodeSpecs> NodeSpecs { get; set; }
        public class ScaleAKSClusterNodeRequestNodeSpecs : TeaModel {
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

            [NameInMap("Cell")]
            [Validation(Required=false)]
            public string Cell { get; set; }

            [NameInMap("ComputerSpecId")]
            [Validation(Required=false)]
            public string ComputerSpecId { get; set; }

            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public long? DataDiskSize { get; set; }

            [NameInMap("DataDiskSpecId")]
            [Validation(Required=false)]
            public string DataDiskSpecId { get; set; }

            [NameInMap("NamePrefix")]
            [Validation(Required=false)]
            public string NamePrefix { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public long? SystemDiskSize { get; set; }

            [NameInMap("SystemDiskSpecId")]
            [Validation(Required=false)]
            public string SystemDiskSpecId { get; set; }

            [NameInMap("VswicthId")]
            [Validation(Required=false)]
            public string VswicthId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("OperatorName")]
        [Validation(Required=false)]
        public string OperatorName { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
