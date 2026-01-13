// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetRecallManagementServiceResponseBody : TeaModel {
        [NameInMap("CurrentRecallManagementServiceVersionId")]
        [Validation(Required=false)]
        public string CurrentRecallManagementServiceVersionId { get; set; }

        [NameInMap("CurrentRecallManagementServiceVersionName")]
        [Validation(Required=false)]
        public string CurrentRecallManagementServiceVersionName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RecallManagementServiceId")]
        [Validation(Required=false)]
        public string RecallManagementServiceId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
