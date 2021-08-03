// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeInvocationsRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InvokeId")]
        [Validation(Required=false)]
        public string InvokeId { get; set; }

        [NameInMap("CommandType")]
        [Validation(Required=false)]
        public string CommandType { get; set; }

        [NameInMap("InvokeStatus")]
        [Validation(Required=false)]
        public string InvokeStatus { get; set; }

        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        [NameInMap("IncludeOutput")]
        [Validation(Required=false)]
        public bool? IncludeOutput { get; set; }

        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
