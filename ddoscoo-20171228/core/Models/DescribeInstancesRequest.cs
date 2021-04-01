// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeInstancesRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=true)]
        public string PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public string PageSize { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("Edition")]
        [Validation(Required=false)]
        public int? Edition { get; set; }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public int? Enabled { get; set; }

        [NameInMap("ExpireStartTime")]
        [Validation(Required=false)]
        public long? ExpireStartTime { get; set; }

        [NameInMap("ExpireEndTime")]
        [Validation(Required=false)]
        public long? ExpireEndTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<int?> Status { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstancesRequestTag> Tag { get; set; }
        public class DescribeInstancesRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
