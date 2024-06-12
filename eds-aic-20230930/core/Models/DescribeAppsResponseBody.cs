// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeAppsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAppsResponseBodyData> Data { get; set; }
        public class DescribeAppsResponseBodyData : TeaModel {
            [NameInMap("AndroidAppVersion")]
            [Validation(Required=false)]
            public string AndroidAppVersion { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public int? AppId { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            [NameInMap("InstallationStatus")]
            [Validation(Required=false)]
            public string InstallationStatus { get; set; }

            [NameInMap("InstanceGroupList")]
            [Validation(Required=false)]
            public List<string> InstanceGroupList { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
