// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListAssignmentRequest : TeaModel {
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("manage_resource_id")]
        [Validation(Required=false)]
        public string ManageResourceId { get; set; }

        [NameInMap("manage_resource_type")]
        [Validation(Required=false)]
        public string ManageResourceType { get; set; }

        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

    }

}
