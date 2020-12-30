// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoInfoRequest : TeaModel {
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

        [NameInMap("ResultTypes")]
        [Validation(Required=false)]
        public string ResultTypes { get; set; }

        [NameInMap("AdditionType")]
        [Validation(Required=false)]
        public string AdditionType { get; set; }

    }

}
