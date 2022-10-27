// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAnomalySQLListRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("FilterCondition")]
        [Validation(Required=false)]
        public Dictionary<string, object> FilterCondition { get; set; }

        [NameInMap("NodeIp")]
        [Validation(Required=false)]
        public string NodeIp { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SQLId")]
        [Validation(Required=false)]
        public string SQLId { get; set; }

        [NameInMap("SearchKeyWord")]
        [Validation(Required=false)]
        public string SearchKeyWord { get; set; }

        [NameInMap("SearchParameter")]
        [Validation(Required=false)]
        public string SearchParameter { get; set; }

        [NameInMap("SearchRule")]
        [Validation(Required=false)]
        public string SearchRule { get; set; }

        [NameInMap("SearchValue")]
        [Validation(Required=false)]
        public string SearchValue { get; set; }

        [NameInMap("SortColumn")]
        [Validation(Required=false)]
        public string SortColumn { get; set; }

        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
