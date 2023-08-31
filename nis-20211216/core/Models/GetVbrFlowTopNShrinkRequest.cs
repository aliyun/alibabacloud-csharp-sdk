// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class GetVbrFlowTopNShrinkRequest : TeaModel {
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public string AccountIdsShrink { get; set; }

        [NameInMap("AttachmentId")]
        [Validation(Required=false)]
        public string AttachmentId { get; set; }

        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("CloudIp")]
        [Validation(Required=false)]
        public string CloudIp { get; set; }

        [NameInMap("CloudPort")]
        [Validation(Required=false)]
        public string CloudPort { get; set; }

        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("GroupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("OtherIp")]
        [Validation(Required=false)]
        public string OtherIp { get; set; }

        [NameInMap("OtherPort")]
        [Validation(Required=false)]
        public string OtherPort { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        [NameInMap("TopN")]
        [Validation(Required=false)]
        public int? TopN { get; set; }

        [NameInMap("UseMultiAccount")]
        [Validation(Required=false)]
        public bool? UseMultiAccount { get; set; }

        [NameInMap("VirtualBorderRouterId")]
        [Validation(Required=false)]
        public string VirtualBorderRouterId { get; set; }

    }

}
