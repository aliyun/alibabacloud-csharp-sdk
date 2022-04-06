// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class CalcCACSRequest : TeaModel {
        [NameInMap("DataFormat")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        [NameInMap("OrgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        [NameInMap("URLList")]
        [Validation(Required=false)]
        public List<CalcCACSRequestURLList> URLList { get; set; }
        public class CalcCACSRequestURLList : TeaModel {
            [NameInMap("URL")]
            [Validation(Required=false)]
            public string URL { get; set; }

        }

    }

}
