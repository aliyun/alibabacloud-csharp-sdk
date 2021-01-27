// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateSiteMonitorResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSiteMonitorResponseBodyData Data { get; set; }
        public class CreateSiteMonitorResponseBodyData : TeaModel {
            [NameInMap("AttachAlertResult")]
            [Validation(Required=false)]
            public CreateSiteMonitorResponseBodyDataAttachAlertResult AttachAlertResult { get; set; }
            public class CreateSiteMonitorResponseBodyDataAttachAlertResult : TeaModel {
                [NameInMap("Contact")]
                [Validation(Required=false)]
                public List<CreateSiteMonitorResponseBodyDataAttachAlertResultContact> Contact { get; set; }
                public class CreateSiteMonitorResponseBodyDataAttachAlertResultContact : TeaModel {
                    [NameInMap("RequestId")]
                    [Validation(Required=false)]
                    public string RequestId { get; set; }

                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public string Success { get; set; }

                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public string RuleId { get; set; }

                }

            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CreateResultList")]
        [Validation(Required=false)]
        public CreateSiteMonitorResponseBodyCreateResultList CreateResultList { get; set; }
        public class CreateSiteMonitorResponseBodyCreateResultList : TeaModel {
            [NameInMap("CreateResultList")]
            [Validation(Required=false)]
            public List<CreateSiteMonitorResponseBodyCreateResultListCreateResultList> CreateResultList { get; set; }
            public class CreateSiteMonitorResponseBodyCreateResultListCreateResultList : TeaModel {
                public string TaskName { get; set; }
                public string TaskId { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
