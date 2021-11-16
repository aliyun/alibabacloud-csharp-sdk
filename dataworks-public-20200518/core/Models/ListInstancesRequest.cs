// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListInstancesRequest : TeaModel {
        [NameInMap("BeginBizdate")]
        [Validation(Required=false)]
        public string BeginBizdate { get; set; }

        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        [NameInMap("Bizdate")]
        [Validation(Required=false)]
        public string Bizdate { get; set; }

        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        [NameInMap("EndBizdate")]
        [Validation(Required=false)]
        public string EndBizdate { get; set; }

        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProgramType")]
        [Validation(Required=false)]
        public string ProgramType { get; set; }

        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
