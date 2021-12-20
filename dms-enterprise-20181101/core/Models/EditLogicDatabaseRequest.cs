// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class EditLogicDatabaseRequest : TeaModel {
        [NameInMap("Alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        [NameInMap("DatabaseIds")]
        [Validation(Required=false)]
        public List<long?> DatabaseIds { get; set; }

        [NameInMap("LogicDbId")]
        [Validation(Required=false)]
        public long? LogicDbId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
