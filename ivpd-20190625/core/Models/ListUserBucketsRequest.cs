// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class ListUserBucketsRequest : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListUserBucketsRequestData> Data { get; set; }
        public class ListUserBucketsRequestData : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}
