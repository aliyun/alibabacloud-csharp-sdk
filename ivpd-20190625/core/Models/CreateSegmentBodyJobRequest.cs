// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class CreateSegmentBodyJobRequest : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<CreateSegmentBodyJobRequestDataList> DataList { get; set; }
        public class CreateSegmentBodyJobRequestDataList : TeaModel {
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

        }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("TimeToLive")]
        [Validation(Required=false)]
        public int? TimeToLive { get; set; }

    }

}
