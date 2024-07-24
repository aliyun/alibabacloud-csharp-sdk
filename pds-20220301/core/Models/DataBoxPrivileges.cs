// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class DataBoxPrivileges : TeaModel {
        [NameInMap("feature_attr_id")]
        [Validation(Required=false)]
        public string FeatureAttrId { get; set; }

        [NameInMap("feature_id")]
        [Validation(Required=false)]
        public string FeatureId { get; set; }

        [NameInMap("quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

    }

}
