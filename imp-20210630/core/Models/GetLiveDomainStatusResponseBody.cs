// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetLiveDomainStatusResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetLiveDomainStatusResponseBodyResult Result { get; set; }
        public class GetLiveDomainStatusResponseBodyResult : TeaModel {
            [NameInMap("LiveDomainInfoList")]
            [Validation(Required=false)]
            public List<GetLiveDomainStatusResponseBodyResultLiveDomainInfoList> LiveDomainInfoList { get; set; }
            public class GetLiveDomainStatusResponseBodyResultLiveDomainInfoList : TeaModel {
                public string Cname { get; set; }
                public string Domain { get; set; }
                public string Status { get; set; }
            }
        };

    }

}
