// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class LogisticsOrderResult : TeaModel {
        [NameInMap("dataProvider")]
        [Validation(Required=false)]
        public string DataProvider { get; set; }

        [NameInMap("dataProviderTitle")]
        [Validation(Required=false)]
        public string DataProviderTitle { get; set; }

        [NameInMap("goods")]
        [Validation(Required=false)]
        public List<Good> Goods { get; set; }

        [NameInMap("logisticsCompanyCode")]
        [Validation(Required=false)]
        public string LogisticsCompanyCode { get; set; }

        [NameInMap("logisticsCompanyName")]
        [Validation(Required=false)]
        public string LogisticsCompanyName { get; set; }

        [NameInMap("logisticsDetailList")]
        [Validation(Required=false)]
        public List<LogisticsDetail> LogisticsDetailList { get; set; }

        [NameInMap("mailNo")]
        [Validation(Required=false)]
        public string MailNo { get; set; }

    }

}
