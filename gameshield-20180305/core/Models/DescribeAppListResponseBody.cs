// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeAppListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

        [NameInMap("AppList")]
        [Validation(Required=false)]
        public List<DescribeAppListResponseBodyAppList> AppList { get; set; }
        public class DescribeAppListResponseBodyAppList : TeaModel {
            [NameInMap("OldAppKey")]
            [Validation(Required=false)]
            public string OldAppKey { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("HasOldAppKey")]
            [Validation(Required=false)]
            public bool? HasOldAppKey { get; set; }

            [NameInMap("SdkVersion")]
            [Validation(Required=false)]
            public string SdkVersion { get; set; }

            [NameInMap("BizNum")]
            [Validation(Required=false)]
            public int? BizNum { get; set; }

            [NameInMap("GroupNum")]
            [Validation(Required=false)]
            public int? GroupNum { get; set; }

            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public int? NodeNum { get; set; }

        }

    }

}
