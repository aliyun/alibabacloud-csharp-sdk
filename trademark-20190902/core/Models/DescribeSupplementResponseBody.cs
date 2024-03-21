// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class DescribeSupplementResponseBody : TeaModel {
        [NameInMap("AcceptExpirationDate")]
        [Validation(Required=false)]
        public long? AcceptExpirationDate { get; set; }

        [NameInMap("AcceptTime")]
        [Validation(Required=false)]
        public long? AcceptTime { get; set; }

        [NameInMap("ApplicationType")]
        [Validation(Required=false)]
        public int? ApplicationType { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("OfficialFile")]
        [Validation(Required=false)]
        public string OfficialFile { get; set; }

        [NameInMap("OperateTime")]
        [Validation(Required=false)]
        public long? OperateTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SbjExpirationDate")]
        [Validation(Required=false)]
        public long? SbjExpirationDate { get; set; }

        [NameInMap("SendTime")]
        [Validation(Required=false)]
        public long? SendTime { get; set; }

        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        [NameInMap("SupplementId")]
        [Validation(Required=false)]
        public long? SupplementId { get; set; }

        [NameInMap("SupplementStatus")]
        [Validation(Required=false)]
        public int? SupplementStatus { get; set; }

        [NameInMap("TrademarkNumber")]
        [Validation(Required=false)]
        public string TrademarkNumber { get; set; }

        [NameInMap("UserFiles")]
        [Validation(Required=false)]
        public DescribeSupplementResponseBodyUserFiles UserFiles { get; set; }
        public class DescribeSupplementResponseBodyUserFiles : TeaModel {
            [NameInMap("UserFile")]
            [Validation(Required=false)]
            public List<string> UserFile { get; set; }

        }

    }

}
