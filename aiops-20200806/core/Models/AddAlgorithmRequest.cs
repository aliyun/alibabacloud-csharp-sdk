/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class AddAlgorithmRequest : TeaModel {
        [NameInMap("AlgorithmId")]
        [Validation(Required=false)]
        public string AlgorithmId { get; set; }

        [NameInMap("AlgorithmType")]
        [Validation(Required=false)]
        public int? AlgorithmType { get; set; }

        [NameInMap("BusinessGroupId")]
        [Validation(Required=false)]
        public string BusinessGroupId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("ExpandInformation")]
        [Validation(Required=false)]
        public string ExpandInformation { get; set; }

        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
