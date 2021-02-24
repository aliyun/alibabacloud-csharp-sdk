// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class RemoveGroupSilenceBlacklistRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 群禁言删除黑名单请求体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public RemoveGroupSilenceBlacklistRequestRequestParams RequestParams { get; set; }
        public class RemoveGroupSilenceBlacklistRequestRequestParams : TeaModel {
            [NameInMap("OperatorAppUid")]
            [Validation(Required=false)]
            public string OperatorAppUid { get; set; }
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
            [NameInMap("Members")]
            [Validation(Required=false)]
            public List<string> Members { get; set; }
        };

    }

}
