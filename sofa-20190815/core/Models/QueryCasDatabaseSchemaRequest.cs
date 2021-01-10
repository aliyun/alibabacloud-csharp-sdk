// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasDatabaseSchemaRequest : TeaModel {
        [NameInMap("CharSetsRepeatList")]
        [Validation(Required=false)]
        public List<string> CharSetsRepeatList { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("DatabaseId")]
        [Validation(Required=false)]
        public string DatabaseId { get; set; }

        [NameInMap("IaasIdsRepeatList")]
        [Validation(Required=false)]
        public List<string> IaasIdsRepeatList { get; set; }

        [NameInMap("IdsRepeatList")]
        [Validation(Required=false)]
        public List<string> IdsRepeatList { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("StatusesRepeatList")]
        [Validation(Required=false)]
        public List<string> StatusesRepeatList { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
