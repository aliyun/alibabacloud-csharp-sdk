// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostsRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("HostAddress")]
        [Validation(Required=false)]
        public string HostAddress { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("SourceInstanceId")]
        [Validation(Required=false)]
        public string SourceInstanceId { get; set; }

        [NameInMap("SourceInstanceState")]
        [Validation(Required=false)]
        public string SourceInstanceState { get; set; }

        [NameInMap("HostGroupId")]
        [Validation(Required=false)]
        public string HostGroupId { get; set; }

    }

}
