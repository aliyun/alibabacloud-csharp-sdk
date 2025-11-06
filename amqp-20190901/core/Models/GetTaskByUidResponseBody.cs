// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class GetTaskByUidResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTaskByUidResponseBodyData Data { get; set; }
        public class GetTaskByUidResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("VoList")]
            [Validation(Required=false)]
            public GetTaskByUidResponseBodyDataVoList VoList { get; set; }
            public class GetTaskByUidResponseBodyDataVoList : TeaModel {
                [NameInMap("ImportDefinitionTaskDO")]
                [Validation(Required=false)]
                public List<GetTaskByUidResponseBodyDataVoListImportDefinitionTaskDO> ImportDefinitionTaskDO { get; set; }
                public class GetTaskByUidResponseBodyDataVoListImportDefinitionTaskDO : TeaModel {
                    [NameInMap("BindingNum")]
                    [Validation(Required=false)]
                    public int? BindingNum { get; set; }

                    [NameInMap("ExchangeNum")]
                    [Validation(Required=false)]
                    public int? ExchangeNum { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("ImportType")]
                    [Validation(Required=false)]
                    public int? ImportType { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("InstanceName")]
                    [Validation(Required=false)]
                    public string InstanceName { get; set; }

                    [NameInMap("QueueNum")]
                    [Validation(Required=false)]
                    public int? QueueNum { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public long? UserId { get; set; }

                    [NameInMap("VhostName")]
                    [Validation(Required=false)]
                    public string VhostName { get; set; }

                    [NameInMap("VhostNum")]
                    [Validation(Required=false)]
                    public int? VhostNum { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
