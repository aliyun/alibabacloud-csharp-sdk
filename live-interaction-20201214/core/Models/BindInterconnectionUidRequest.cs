// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class BindInterconnectionUidRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public BindInterconnectionUidRequestRequestParams RequestParams { get; set; }
        public class BindInterconnectionUidRequestRequestParams : TeaModel {
            [NameInMap("AppUid")]
            [Validation(Required=false)]
            public string AppUid { get; set; }

            [NameInMap("DingTalkUid")]
            [Validation(Required=false)]
            public string DingTalkUid { get; set; }

        }

    }

}
