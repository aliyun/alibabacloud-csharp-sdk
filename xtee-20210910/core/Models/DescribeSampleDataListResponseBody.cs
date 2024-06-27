// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSampleDataListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public List<DescribeSampleDataListResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeSampleDataListResponseBodyResultObject : TeaModel {
            [NameInMap("classificationType")]
            [Validation(Required=false)]
            public string ClassificationType { get; set; }

            [NameInMap("dataDistributed")]
            [Validation(Required=false)]
            public string DataDistributed { get; set; }

            [NameInMap("dataTitle")]
            [Validation(Required=false)]
            public string DataTitle { get; set; }

            [NameInMap("deleteTag")]
            [Validation(Required=false)]
            public string DeleteTag { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("normalSize")]
            [Validation(Required=false)]
            public long? NormalSize { get; set; }

            [NameInMap("recallConfig")]
            [Validation(Required=false)]
            public string RecallConfig { get; set; }

            [NameInMap("riskSize")]
            [Validation(Required=false)]
            public long? RiskSize { get; set; }

            [NameInMap("riskValue")]
            [Validation(Required=false)]
            public string RiskValue { get; set; }

            [NameInMap("sampleLabelDetail")]
            [Validation(Required=false)]
            public string SampleLabelDetail { get; set; }

            [NameInMap("sampleSize")]
            [Validation(Required=false)]
            public long? SampleSize { get; set; }

            [NameInMap("scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("storePath")]
            [Validation(Required=false)]
            public string StorePath { get; set; }

            [NameInMap("storeType")]
            [Validation(Required=false)]
            public string StoreType { get; set; }

            [NameInMap("supportRecall")]
            [Validation(Required=false)]
            public string SupportRecall { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        [NameInMap("totalItem")]
        [Validation(Required=false)]
        public int? TotalItem { get; set; }

        [NameInMap("totalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
