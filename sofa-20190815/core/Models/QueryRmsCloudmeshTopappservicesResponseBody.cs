// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsCloudmeshTopappservicesResponseBody : TeaModel {
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
        public QueryRmsCloudmeshTopappservicesResponseBodyResponse Response { get; set; }
        public class QueryRmsCloudmeshTopappservicesResponseBodyResponse : TeaModel {
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("Datas")]
            [Validation(Required=false)]
            public List<QueryRmsCloudmeshTopappservicesResponseBodyResponseDatas> Datas { get; set; }
            public class QueryRmsCloudmeshTopappservicesResponseBodyResponseDatas : TeaModel {
                public string AppInstanceService { get; set; }
                public string AppInstanceServiceId { get; set; }
                public string Cluster { get; set; }
                public string CopiesNum { get; set; }
                public string CostTime { get; set; }
                public string ErrorDetail { get; set; }
                public string ErrorRate { get; set; }
                public string FlowIn { get; set; }
                public string FlowOut { get; set; }
                public string Namespace { get; set; }
                public string Reporter { get; set; }
                public string Rqs { get; set; }
                public string TimeNoSec { get; set; }
            }
        };

    }

}
