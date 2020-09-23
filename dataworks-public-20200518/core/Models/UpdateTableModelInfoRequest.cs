// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateTableModelInfoRequest : TeaModel {
        [NameInMap("FirstLevelThemeId")]
        [Validation(Required=false)]
        public long FirstLevelThemeId { get; set; }

        [NameInMap("SecondLevelThemeId")]
        [Validation(Required=false)]
        public long SecondLevelThemeId { get; set; }

        [NameInMap("LevelId")]
        [Validation(Required=false)]
        public long LevelId { get; set; }

        [NameInMap("TableGuid")]
        [Validation(Required=true)]
        public string TableGuid { get; set; }

        [NameInMap("LevelType")]
        [Validation(Required=false)]
        public int? LevelType { get; set; }

    }

}
