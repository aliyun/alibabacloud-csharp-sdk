// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class AttachDbfsRequest : TeaModel {
        [NameInMap("AttachMode")]
        [Validation(Required=false)]
        public string AttachMode { get; set; }

        [NameInMap("AttachPoint")]
        [Validation(Required=false)]
        public string AttachPoint { get; set; }

        [NameInMap("ECSInstanceId")]
        [Validation(Required=false)]
        public string ECSInstanceId { get; set; }

        [NameInMap("FsId")]
        [Validation(Required=false)]
        public string FsId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ServerUrl")]
        [Validation(Required=false)]
        public string ServerUrl { get; set; }

    }

}
