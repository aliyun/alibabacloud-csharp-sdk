// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeBizUserTypeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeBizUserTypeResponseBodyData> Data { get; set; }
        public class DescribeBizUserTypeResponseBodyData : TeaModel {
            [NameInMap("Profile")]
            [Validation(Required=false)]
            public string Profile { get; set; }

        }

        /// <summary>
        /// Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
