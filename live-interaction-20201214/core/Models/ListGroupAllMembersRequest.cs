// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ListGroupAllMembersRequest : TeaModel {
        /// <summary>
        /// App ID, IMPaaS租户的ID
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 拉取群成员列表的请求体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public ListGroupAllMembersRequestRequestParams RequestParams { get; set; }
        public class ListGroupAllMembersRequestRequestParams : TeaModel {
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
        };

    }

}
