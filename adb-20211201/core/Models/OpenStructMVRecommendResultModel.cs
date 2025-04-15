// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class OpenStructMVRecommendResultModel : TeaModel {
        [NameInMap("AcceleratedQueriesCount")]
        [Validation(Required=false)]
        public long? AcceleratedQueriesCount { get; set; }

        [NameInMap("BaseTables")]
        [Validation(Required=false)]
        public List<OpenStructMvBaseTableDetailModel> BaseTables { get; set; }

        [NameInMap("SavedScanbytes")]
        [Validation(Required=false)]
        public long? SavedScanbytes { get; set; }

        [NameInMap("Subquery")]
        [Validation(Required=false)]
        public string Subquery { get; set; }

        [NameInMap("SubqueryId")]
        [Validation(Required=false)]
        public long? SubqueryId { get; set; }

        [NameInMap("SupportIncrementalRefresh")]
        [Validation(Required=false)]
        public bool? SupportIncrementalRefresh { get; set; }

    }

}
