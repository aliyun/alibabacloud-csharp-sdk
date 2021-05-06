// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class MuteUsersRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public MuteUsersRequestRequestParams RequestParams { get; set; }
        public class MuteUsersRequestRequestParams : TeaModel {
            [NameInMap("AppUids")]
            [Validation(Required=false)]
            public List<string> AppUids { get; set; }
            [NameInMap("MuteDuration")]
            [Validation(Required=false)]
            public long? MuteDuration { get; set; }
            [NameInMap("Mute")]
            [Validation(Required=false)]
            public bool? Mute { get; set; }
        };

    }

}
