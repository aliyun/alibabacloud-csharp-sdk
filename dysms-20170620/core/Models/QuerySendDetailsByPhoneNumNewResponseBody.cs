// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySendDetailsByPhoneNumNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public QuerySendDetailsByPhoneNumNewResponseBodyList List { get; set; }
        public class QuerySendDetailsByPhoneNumNewResponseBodyList : TeaModel {
            [NameInMap("SmsSendDetailResponse")]
            [Validation(Required=false)]
            public List<QuerySendDetailsByPhoneNumNewResponseBodyListSmsSendDetailResponse> SmsSendDetailResponse { get; set; }
            public class QuerySendDetailsByPhoneNumNewResponseBodyListSmsSendDetailResponse : TeaModel {
                [NameInMap("ApplyDateStr")]
                [Validation(Required=false)]
                public string ApplyDateStr { get; set; }

                [NameInMap("BillCount")]
                [Validation(Required=false)]
                public long? BillCount { get; set; }

                [NameInMap("BizId")]
                [Validation(Required=false)]
                public string BizId { get; set; }

                [NameInMap("BizType")]
                [Validation(Required=false)]
                public long? BizType { get; set; }

                [NameInMap("BlackListStatus")]
                [Validation(Required=false)]
                public int? BlackListStatus { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("ErrCode")]
                [Validation(Required=false)]
                public string ErrCode { get; set; }

                [NameInMap("ErrCodeDesc")]
                [Validation(Required=false)]
                public string ErrCodeDesc { get; set; }

                [NameInMap("InnerErrCode")]
                [Validation(Required=false)]
                public string InnerErrCode { get; set; }

                [NameInMap("OutId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                [NameInMap("PhoneNum")]
                [Validation(Required=false)]
                public string PhoneNum { get; set; }

                [NameInMap("ReceiveDateStr")]
                [Validation(Required=false)]
                public string ReceiveDateStr { get; set; }

                [NameInMap("SendDateStr")]
                [Validation(Required=false)]
                public string SendDateStr { get; set; }

                [NameInMap("SendStatus")]
                [Validation(Required=false)]
                public long? SendStatus { get; set; }

                [NameInMap("SmsLength")]
                [Validation(Required=false)]
                public long? SmsLength { get; set; }

                [NameInMap("StatisticsStatus")]
                [Validation(Required=false)]
                public int? StatisticsStatus { get; set; }

                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                [NameInMap("TemplateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

            }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
