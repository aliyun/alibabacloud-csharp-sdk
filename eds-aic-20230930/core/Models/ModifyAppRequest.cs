// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyAppRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public int? AppId { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("IconUrl")]
        [Validation(Required=false)]
        public string IconUrl { get; set; }

    }

}
