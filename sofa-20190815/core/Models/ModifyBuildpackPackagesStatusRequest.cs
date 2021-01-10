// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ModifyBuildpackPackagesStatusRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("NewFileStatus")]
        [Validation(Required=false)]
        public string NewFileStatus { get; set; }

        [NameInMap("OriginalFileStatus")]
        [Validation(Required=false)]
        public string OriginalFileStatus { get; set; }

        [NameInMap("RegionNumRepeatList")]
        [Validation(Required=false)]
        public List<string> RegionNumRepeatList { get; set; }

    }

}
