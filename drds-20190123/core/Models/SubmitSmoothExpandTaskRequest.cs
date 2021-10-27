// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SubmitSmoothExpandTaskRequest : TeaModel {
        [NameInMap("DbInstanceIsCreating")]
        [Validation(Required=false)]
        public bool? DbInstanceIsCreating { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("RdsSuperInstances")]
        [Validation(Required=false)]
        public List<SubmitSmoothExpandTaskRequestRdsSuperInstances> RdsSuperInstances { get; set; }
        public class SubmitSmoothExpandTaskRequestRdsSuperInstances : TeaModel {
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("RdsName")]
            [Validation(Required=false)]
            public string RdsName { get; set; }

        }

        [NameInMap("TransferTaskInfos")]
        [Validation(Required=false)]
        public List<SubmitSmoothExpandTaskRequestTransferTaskInfos> TransferTaskInfos { get; set; }
        public class SubmitSmoothExpandTaskRequestTransferTaskInfos : TeaModel {
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("DstInstanceName")]
            [Validation(Required=false)]
            public string DstInstanceName { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("SrcInstanceName")]
            [Validation(Required=false)]
            public string SrcInstanceName { get; set; }

        }

    }

}
