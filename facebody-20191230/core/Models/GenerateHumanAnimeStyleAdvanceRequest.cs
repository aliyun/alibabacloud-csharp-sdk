// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class GenerateHumanAnimeStyleAdvanceRequest : TeaModel {
        [NameInMap("AlgoType")]
        [Validation(Required=false)]
        public string AlgoType { get; set; }

        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public Stream ImageURLObject { get; set; }

    }

}
