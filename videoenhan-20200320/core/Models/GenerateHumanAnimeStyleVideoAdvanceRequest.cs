// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Videoenhan20200320.Models
{
    public class GenerateHumanAnimeStyleVideoAdvanceRequest : TeaModel {
        [NameInMap("CartoonStyle")]
        [Validation(Required=false)]
        public string CartoonStyle { get; set; }

        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public Stream VideoUrlObject { get; set; }

    }

}
