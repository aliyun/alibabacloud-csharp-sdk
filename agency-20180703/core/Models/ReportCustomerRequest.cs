// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class ReportCustomerRequest : TeaModel {
        [NameInMap("ReportCustomerInfoList")]
        [Validation(Required=false)]
        public List<ReportCustomerRequestReportCustomerInfoList> ReportCustomerInfoList { get; set; }
        public class ReportCustomerRequestReportCustomerInfoList : TeaModel {
            [NameInMap("AliyunPk")]
            [Validation(Required=false)]
            public long? AliyunPk { get; set; }

            [NameInMap("CustomerName")]
            [Validation(Required=false)]
            public string CustomerName { get; set; }

            [NameInMap("CustomerSubTrade")]
            [Validation(Required=false)]
            public string CustomerSubTrade { get; set; }

            [NameInMap("CustomerTrade")]
            [Validation(Required=false)]
            public string CustomerTrade { get; set; }

            [NameInMap("CustomerType")]
            [Validation(Required=false)]
            public int? CustomerType { get; set; }

            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            [NameInMap("RamUid")]
            [Validation(Required=false)]
            public long? RamUid { get; set; }

        }

    }

}
