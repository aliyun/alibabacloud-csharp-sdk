// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListInstanceAmountRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=true)]
        public long? ProjectId { get; set; }

        [NameInMap("BeginDate")]
        [Validation(Required=true)]
        public string BeginDate { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=true)]
        public string EndDate { get; set; }

    }

}
