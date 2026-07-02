// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliyunAuth20181222.Models
{
    public class QueryAuthResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAuthResponseBodyData Data { get; set; }
        public class QueryAuthResponseBodyData : TeaModel {
            [NameInMap("InfoDTOList")]
            [Validation(Required=false)]
            public QueryAuthResponseBodyDataInfoDTOList InfoDTOList { get; set; }
            public class QueryAuthResponseBodyDataInfoDTOList : TeaModel {
                [NameInMap("InfoDTOList")]
                [Validation(Required=false)]
                public List<QueryAuthResponseBodyDataInfoDTOListInfoDTOList> InfoDTOList { get; set; }
                public class QueryAuthResponseBodyDataInfoDTOListInfoDTOList : TeaModel {
                    [NameInMap("AuthOrderVid")]
                    [Validation(Required=false)]
                    public string AuthOrderVid { get; set; }

                    [NameInMap("ItemName")]
                    [Validation(Required=false)]
                    public string ItemName { get; set; }

                    [NameInMap("ItemRecordVid")]
                    [Validation(Required=false)]
                    public string ItemRecordVid { get; set; }

                    [NameInMap("OperateCode")]
                    [Validation(Required=false)]
                    public string OperateCode { get; set; }

                }

            }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

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
