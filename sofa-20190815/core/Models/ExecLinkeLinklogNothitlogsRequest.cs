// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecLinkeLinklogNothitlogsRequest : TeaModel {
        [NameInMap("Begin")]
        [Validation(Required=false)]
        public long? Begin { get; set; }

        [NameInMap("BeginMills")]
        [Validation(Required=false)]
        public long? BeginMills { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("Encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        [NameInMap("EndMills")]
        [Validation(Required=false)]
        public long? EndMills { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("IterationId")]
        [Validation(Required=false)]
        public string IterationId { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("Sorter")]
        [Validation(Required=false)]
        public string Sorter { get; set; }

        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        [NameInMap("SourcePath")]
        [Validation(Required=false)]
        public string SourcePath { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public long? StoreId { get; set; }

        [NameInMap("TaskApp")]
        [Validation(Required=false)]
        public string TaskApp { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        [NameInMap("TaskUrl")]
        [Validation(Required=false)]
        public string TaskUrl { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("BizInfoRepeatList")]
        [Validation(Required=false)]
        public List<string> BizInfoRepeatList { get; set; }

        [NameInMap("BizPatternRepeatList")]
        [Validation(Required=false)]
        public List<string> BizPatternRepeatList { get; set; }

    }

}
