// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class BindInterconnectionCidRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public BindInterconnectionCidRequestRequestParams RequestParams { get; set; }
        public class BindInterconnectionCidRequestRequestParams : TeaModel {
            [NameInMap("AimAppCid")]
            [Validation(Required=false)]
            public string AimAppCid { get; set; }

            [NameInMap("DingTalkCid")]
            [Validation(Required=false)]
            public string DingTalkCid { get; set; }

        }

    }

}
