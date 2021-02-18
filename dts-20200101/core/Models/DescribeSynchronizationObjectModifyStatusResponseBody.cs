// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSynchronizationObjectModifyStatusResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("PrecheckStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatus PrecheckStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatus : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatusDetail> Detail { get; set; }
            public class DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatusDetail : TeaModel {
                public string CheckStatus { get; set; }
                public string ErrorMessage { get; set; }
                public string ItemName { get; set; }
                public string RepairMethod { get; set; }
            }
        };

        [NameInMap("DataInitializationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyDataInitializationStatus DataInitializationStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyDataInitializationStatus : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("StructureInitializationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyStructureInitializationStatus StructureInitializationStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyStructureInitializationStatus : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }
        };

        [NameInMap("DataSynchronizationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyDataSynchronizationStatus DataSynchronizationStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyDataSynchronizationStatus : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public string Delay { get; set; }
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }
        };

    }

}
