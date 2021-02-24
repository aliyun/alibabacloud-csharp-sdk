// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class RemoveGroupMembersRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 群踢人请求实体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public RemoveGroupMembersRequestRequestParams RequestParams { get; set; }
        public class RemoveGroupMembersRequestRequestParams : TeaModel {
            [NameInMap("OperatorAppUid")]
            [Validation(Required=false)]
            public string OperatorAppUid { get; set; }
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
            [NameInMap("AppUidsRemoved")]
            [Validation(Required=false)]
            public List<string> AppUidsRemoved { get; set; }
        };

    }

}
