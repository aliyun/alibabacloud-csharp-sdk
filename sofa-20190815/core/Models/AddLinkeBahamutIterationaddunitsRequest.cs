// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeBahamutIterationaddunitsRequest : TeaModel {
        [NameInMap("IterationId")]
        [Validation(Required=false)]
        public string IterationId { get; set; }

        [NameInMap("UserAccount")]
        [Validation(Required=false)]
        public string UserAccount { get; set; }

        [NameInMap("UnitFormsRepeatList")]
        [Validation(Required=false)]
        public List<string> UnitFormsRepeatList { get; set; }

    }

}
