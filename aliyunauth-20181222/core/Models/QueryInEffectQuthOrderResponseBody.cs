// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliyunAuth20181222.Models
{
    public class QueryInEffectQuthOrderResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryInEffectQuthOrderResponseBodyData Data { get; set; }
        public class QueryInEffectQuthOrderResponseBodyData : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryInEffectQuthOrderResponseBodyDataList> List { get; set; }
            public class QueryInEffectQuthOrderResponseBodyDataList : TeaModel {
                [NameInMap("AuthItemRecordGroupItemDTOS")]
                [Validation(Required=false)]
                public List<QueryInEffectQuthOrderResponseBodyDataListAuthItemRecordGroupItemDTOS> AuthItemRecordGroupItemDTOS { get; set; }
                public class QueryInEffectQuthOrderResponseBodyDataListAuthItemRecordGroupItemDTOS : TeaModel {
                    [NameInMap("AuthitemID")]
                    [Validation(Required=false)]
                    public string AuthitemID { get; set; }

                    [NameInMap("GmtCreated")]
                    [Validation(Required=false)]
                    public string GmtCreated { get; set; }

                    [NameInMap("Msg")]
                    [Validation(Required=false)]
                    public string Msg { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("RemarkDataJson")]
                    [Validation(Required=false)]
                    public string RemarkDataJson { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("Vid")]
                    [Validation(Required=false)]
                    public string Vid { get; set; }

                }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public string LastModifyTime { get; set; }

                [NameInMap("OperateTimes")]
                [Validation(Required=false)]
                public List<QueryInEffectQuthOrderResponseBodyDataListOperateTimes> OperateTimes { get; set; }
                public class QueryInEffectQuthOrderResponseBodyDataListOperateTimes : TeaModel {
                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public string End { get; set; }

                    [NameInMap("Start")]
                    [Validation(Required=false)]
                    public string Start { get; set; }

                }

                [NameInMap("OrderVid")]
                [Validation(Required=false)]
                public string OrderVid { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

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
