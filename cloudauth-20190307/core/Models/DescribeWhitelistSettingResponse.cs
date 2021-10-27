// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeWhitelistSettingResponse : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=true)]
        public List<DescribeWhitelistSettingResponseItems> Items { get; set; }
        public class DescribeWhitelistSettingResponseItems : TeaModel {
            [NameInMap("CertNo")]
            [Validation(Required=true)]
            public string CertNo { get; set; }

            [NameInMap("CertifyId")]
            [Validation(Required=true)]
            public string CertifyId { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=true)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=true)]
            public long? Id { get; set; }

            [NameInMap("SceneId")]
            [Validation(Required=true)]
            public long? SceneId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

            [NameInMap("ValidEndDate")]
            [Validation(Required=true)]
            public string ValidEndDate { get; set; }

            [NameInMap("ValidStartDate")]
            [Validation(Required=true)]
            public string ValidStartDate { get; set; }

        }

    }

}
