// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ListInstancesRequest : TeaModel {
        [NameInMap("InstanceIdListJsonString")]
        [Validation(Required=false)]
        public string InstanceIdListJsonString { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NluServiceTypeListJsonString")]
        [Validation(Required=false)]
        public string NluServiceTypeListJsonString { get; set; }

        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UnionInstanceId")]
        [Validation(Required=false)]
        public string UnionInstanceId { get; set; }

        [NameInMap("UnionSource")]
        [Validation(Required=false)]
        public string UnionSource { get; set; }

    }

}
