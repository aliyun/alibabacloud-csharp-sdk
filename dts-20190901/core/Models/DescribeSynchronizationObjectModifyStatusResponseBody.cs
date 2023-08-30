// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20190901.Models
{
    public class DescribeSynchronizationObjectModifyStatusResponseBody : TeaModel {
        [NameInMap("DataInitializationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyDataInitializationStatus DataInitializationStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyDataInitializationStatus : TeaModel {
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("DataSynchronizationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyDataSynchronizationStatus DataSynchronizationStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyDataSynchronizationStatus : TeaModel {
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public string Delay { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("PrecheckStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatus PrecheckStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatus : TeaModel {
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatusDetail> Detail { get; set; }
            public class DescribeSynchronizationObjectModifyStatusResponseBodyPrecheckStatusDetail : TeaModel {
                [NameInMap("CheckStatus")]
                [Validation(Required=false)]
                public string CheckStatus { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("ItemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                [NameInMap("RepairMethod")]
                [Validation(Required=false)]
                public string RepairMethod { get; set; }

            }

            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StructureInitializationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationObjectModifyStatusResponseBodyStructureInitializationStatus StructureInitializationStatus { get; set; }
        public class DescribeSynchronizationObjectModifyStatusResponseBodyStructureInitializationStatus : TeaModel {
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
