// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class AddGroupSilenceBlacklistRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 群禁言添加白名单请求体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public AddGroupSilenceBlacklistRequestRequestParams RequestParams { get; set; }
        public class AddGroupSilenceBlacklistRequestRequestParams : TeaModel {
            [NameInMap("OperatorAppUid")]
            [Validation(Required=false)]
            public string OperatorAppUid { get; set; }
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
            [NameInMap("Members")]
            [Validation(Required=false)]
            public List<string> Members { get; set; }
            [NameInMap("SilenceDuration")]
            [Validation(Required=false)]
            public long? SilenceDuration { get; set; }
        };

    }

}
