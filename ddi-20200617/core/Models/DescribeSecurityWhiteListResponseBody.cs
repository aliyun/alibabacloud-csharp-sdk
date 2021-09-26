// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class DescribeSecurityWhiteListResponseBody : TeaModel {
        [NameInMap("DescribeSecurityWhiteList")]
        [Validation(Required=false)]
        public List<DescribeSecurityWhiteListResponseBodyDescribeSecurityWhiteList> DescribeSecurityWhiteList { get; set; }
        public class DescribeSecurityWhiteListResponseBodyDescribeSecurityWhiteList : TeaModel {
            [NameInMap("PortRange")]
            [Validation(Required=false)]
            public string PortRange { get; set; }

            [NameInMap("WhiteIp")]
            [Validation(Required=false)]
            public string WhiteIp { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
