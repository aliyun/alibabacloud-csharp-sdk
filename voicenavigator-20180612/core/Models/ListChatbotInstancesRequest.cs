// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ListChatbotInstancesRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("NluServiceParamsJson")]
        [Validation(Required=false)]
        public string NluServiceParamsJson { get; set; }

        [NameInMap("NluServiceType")]
        [Validation(Required=false)]
        public string NluServiceType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("UnionSource")]
        [Validation(Required=false)]
        public string UnionSource { get; set; }

    }

}
