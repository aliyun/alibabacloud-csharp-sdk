// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsCloudmeshSidecarlistResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public QueryRmsCloudmeshSidecarlistResponseBodyResponse Response { get; set; }
        public class QueryRmsCloudmeshSidecarlistResponseBodyResponse : TeaModel {
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("Entity")]
            [Validation(Required=false)]
            public QueryRmsCloudmeshSidecarlistResponseBodyResponseEntity Entity { get; set; }
            public class QueryRmsCloudmeshSidecarlistResponseBodyResponseEntity : TeaModel {
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public long? CurrentPage { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public long? TotalSize { get; set; }

                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<QueryRmsCloudmeshSidecarlistResponseBodyResponseEntityData> Data { get; set; }
                public class QueryRmsCloudmeshSidecarlistResponseBodyResponseEntityData : TeaModel {
                    [NameInMap("Agreement")]
                    [Validation(Required=false)]
                    public string Agreement { get; set; }

                    [NameInMap("AppService")]
                    [Validation(Required=false)]
                    public string AppService { get; set; }

                    [NameInMap("AppServiceId")]
                    [Validation(Required=false)]
                    public string AppServiceId { get; set; }

                    [NameInMap("CopiesNum")]
                    [Validation(Required=false)]
                    public string CopiesNum { get; set; }

                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public string Cpu { get; set; }

                    [NameInMap("ErrorRate")]
                    [Validation(Required=false)]
                    public string ErrorRate { get; set; }

                    [NameInMap("FlowIn")]
                    [Validation(Required=false)]
                    public string FlowIn { get; set; }

                    [NameInMap("FlowOut")]
                    [Validation(Required=false)]
                    public string FlowOut { get; set; }

                    [NameInMap("Men")]
                    [Validation(Required=false)]
                    public string Men { get; set; }

                    [NameInMap("PodName")]
                    [Validation(Required=false)]
                    public string PodName { get; set; }

                    [NameInMap("ResponseTime")]
                    [Validation(Required=false)]
                    public string ResponseTime { get; set; }

                    [NameInMap("Rqs")]
                    [Validation(Required=false)]
                    public string Rqs { get; set; }

                    [NameInMap("SidecarVersion")]
                    [Validation(Required=false)]
                    public string SidecarVersion { get; set; }

                }

            }
        };

    }

}
