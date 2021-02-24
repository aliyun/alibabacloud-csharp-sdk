// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetMessageByIdRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 请求实体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public GetMessageByIdRequestRequestParams RequestParams { get; set; }
        public class GetMessageByIdRequestRequestParams : TeaModel {
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }
        };

    }

}
