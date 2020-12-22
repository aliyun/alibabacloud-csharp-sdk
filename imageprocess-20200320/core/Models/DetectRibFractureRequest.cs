// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectRibFractureRequest : TeaModel {
        [NameInMap("URLList")]
        [Validation(Required=true)]
        public List<DetectRibFractureRequestURLList> URLList { get; set; }
        public class DetectRibFractureRequestURLList : TeaModel {
            [NameInMap("URL")]
            [Validation(Required=true)]
            public string URL { get; set; }

        }

        [NameInMap("DataFormat")]
        [Validation(Required=true)]
        public string DataFormat { get; set; }

        [NameInMap("OrgName")]
        [Validation(Required=true)]
        public string OrgName { get; set; }

        [NameInMap("OrgId")]
        [Validation(Required=true)]
        public string OrgId { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=true)]
        public string SourceType { get; set; }

    }

}
