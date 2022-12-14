// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectPancAdvanceRequest : TeaModel {
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        [NameInMap("URLList")]
        [Validation(Required=false)]
        public List<DetectPancAdvanceRequestURLList> URLList { get; set; }
        public class DetectPancAdvanceRequestURLList : TeaModel {
            [NameInMap("URL")]
            [Validation(Required=false)]
            public Stream URLObject { get; set; }

        }

    }

}
