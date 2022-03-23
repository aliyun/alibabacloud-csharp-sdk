// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetCnameDetailResponseBody : TeaModel {
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
        public GetCnameDetailResponseBodyResult Result { get; set; }
        public class GetCnameDetailResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<GetCnameDetailResponseBodyResultData> Data { get; set; }
            public class GetCnameDetailResponseBodyResultData : TeaModel {
                public string Cname { get; set; }
                public string DomainName { get; set; }
                public int? Status { get; set; }
            }
        };

    }

}
