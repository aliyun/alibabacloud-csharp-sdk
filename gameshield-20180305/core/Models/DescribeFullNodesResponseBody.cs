// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeFullNodesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("NodeList")]
        [Validation(Required=false)]
        public List<DescribeFullNodesResponseBodyNodeList> NodeList { get; set; }
        public class DescribeFullNodesResponseBodyNodeList : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("InUse")]
            [Validation(Required=false)]
            public int? InUse { get; set; }

            [NameInMap("BizName")]
            [Validation(Required=false)]
            public string BizName { get; set; }

            [NameInMap("DdosStatus")]
            [Validation(Required=false)]
            public int? DdosStatus { get; set; }

            [NameInMap("IsDisabled")]
            [Validation(Required=false)]
            public bool? IsDisabled { get; set; }

            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

            [NameInMap("EsnBizId")]
            [Validation(Required=false)]
            public string EsnBizId { get; set; }

        }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

    }

}
