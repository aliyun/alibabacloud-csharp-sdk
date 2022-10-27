// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCommunityImagesRequest : TeaModel {
        [NameInMap("BaseOsTag")]
        [Validation(Required=false)]
        public string BaseOsTag { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

    }

}
