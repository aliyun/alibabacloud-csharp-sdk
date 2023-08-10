// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataArchiveCountRequest : TeaModel {
        [NameInMap("OrderResultType")]
        [Validation(Required=false)]
        public string OrderResultType { get; set; }

        [NameInMap("PluginType")]
        [Validation(Required=false)]
        public string PluginType { get; set; }

        [NameInMap("SearchDateType")]
        [Validation(Required=false)]
        public string SearchDateType { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
