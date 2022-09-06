// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySpeechPushJobResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySpeechPushJobResponseBodyData Data { get; set; }
        public class QuerySpeechPushJobResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QuerySpeechPushJobResponseBodyDataList List { get; set; }
            public class QuerySpeechPushJobResponseBodyDataList : TeaModel {
                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<QuerySpeechPushJobResponseBodyDataListItems> Items { get; set; }
                public class QuerySpeechPushJobResponseBodyDataListItems : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("CreatedTime")]
                    [Validation(Required=false)]
                    public long? CreatedTime { get; set; }

                    [NameInMap("DeviceName")]
                    [Validation(Required=false)]
                    public string DeviceName { get; set; }

                    [NameInMap("ExpiredTime")]
                    [Validation(Required=false)]
                    public long? ExpiredTime { get; set; }

                    [NameInMap("FailDeviceNum")]
                    [Validation(Required=false)]
                    public int? FailDeviceNum { get; set; }

                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    [NameInMap("IotId")]
                    [Validation(Required=false)]
                    public string IotId { get; set; }

                    [NameInMap("ProductKey")]
                    [Validation(Required=false)]
                    public string ProductKey { get; set; }

                    [NameInMap("PushMode")]
                    [Validation(Required=false)]
                    public string PushMode { get; set; }

                    [NameInMap("RunningDeviceNum")]
                    [Validation(Required=false)]
                    public int? RunningDeviceNum { get; set; }

                    [NameInMap("SpeechNum")]
                    [Validation(Required=false)]
                    public int? SpeechNum { get; set; }

                    [NameInMap("SpeechStatus")]
                    [Validation(Required=false)]
                    public bool? SpeechStatus { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("SuccessDeviceNum")]
                    [Validation(Required=false)]
                    public int? SuccessDeviceNum { get; set; }

                    [NameInMap("TotalDeviceNum")]
                    [Validation(Required=false)]
                    public int? TotalDeviceNum { get; set; }

                }

            }

            [NameInMap("PageId")]
            [Validation(Required=false)]
            public int? PageId { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
