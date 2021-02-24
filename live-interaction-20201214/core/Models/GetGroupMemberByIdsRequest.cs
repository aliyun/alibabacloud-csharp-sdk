// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetGroupMemberByIdsRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 群聊设置扩展字段请求实体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public GetGroupMemberByIdsRequestRequestParams RequestParams { get; set; }
        public class GetGroupMemberByIdsRequestRequestParams : TeaModel {
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
            [NameInMap("AppUids")]
            [Validation(Required=false)]
            public List<string> AppUids { get; set; }
        };

    }

}
