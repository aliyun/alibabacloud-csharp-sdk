// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDataSourceLogsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataSourceLogsResponseBodyData Data { get; set; }
        public class ListDataSourceLogsResponseBodyData : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            [NameInMap("DataSourceInstanceId")]
            [Validation(Required=false)]
            public string DataSourceInstanceId { get; set; }

            [NameInMap("DataSourceInstanceLogs")]
            [Validation(Required=false)]
            public List<ListDataSourceLogsResponseBodyDataDataSourceInstanceLogs> DataSourceInstanceLogs { get; set; }
            public class ListDataSourceLogsResponseBodyDataDataSourceInstanceLogs : TeaModel {
                [NameInMap("LogCode")]
                [Validation(Required=false)]
                public string LogCode { get; set; }

                [NameInMap("LogInstanceId")]
                [Validation(Required=false)]
                public string LogInstanceId { get; set; }

                [NameInMap("LogMdsCode")]
                [Validation(Required=false)]
                public string LogMdsCode { get; set; }

                [NameInMap("LogParams")]
                [Validation(Required=false)]
                public List<ListDataSourceLogsResponseBodyDataDataSourceInstanceLogsLogParams> LogParams { get; set; }
                public class ListDataSourceLogsResponseBodyDataDataSourceInstanceLogsLogParams : TeaModel {
                    [NameInMap("ParaCode")]
                    [Validation(Required=false)]
                    public string ParaCode { get; set; }

                    [NameInMap("ParaValue")]
                    [Validation(Required=false)]
                    public string ParaValue { get; set; }

                }

                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public int? TaskStatus { get; set; }

            }

            [NameInMap("DataSourceInstanceName")]
            [Validation(Required=false)]
            public string DataSourceInstanceName { get; set; }

            [NameInMap("DataSourceInstanceRemark")]
            [Validation(Required=false)]
            public string DataSourceInstanceRemark { get; set; }

            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
