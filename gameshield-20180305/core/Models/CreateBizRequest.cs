// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class CreateBizRequest : TeaModel {
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        [NameInMap("UseCc")]
        [Validation(Required=false)]
        public int? UseCc { get; set; }

        [NameInMap("CcQps")]
        [Validation(Required=false)]
        public int? CcQps { get; set; }

        [NameInMap("L4Rules")]
        [Validation(Required=false)]
        public string L4Rules { get; set; }

        [NameInMap("Groups")]
        [Validation(Required=false)]
        public string Groups { get; set; }

    }

}
