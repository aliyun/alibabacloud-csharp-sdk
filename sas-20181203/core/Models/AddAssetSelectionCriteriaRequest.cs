// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddAssetSelectionCriteriaRequest : TeaModel {
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        [NameInMap("CriteriaOperation")]
        [Validation(Required=false)]
        public string CriteriaOperation { get; set; }

        [NameInMap("SelectionKey")]
        [Validation(Required=false)]
        public string SelectionKey { get; set; }

        [NameInMap("TargetOperationList")]
        [Validation(Required=false)]
        public List<AddAssetSelectionCriteriaRequestTargetOperationList> TargetOperationList { get; set; }
        public class AddAssetSelectionCriteriaRequestTargetOperationList : TeaModel {
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

        }

    }

}
