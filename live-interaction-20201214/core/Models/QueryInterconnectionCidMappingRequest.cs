// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class QueryInterconnectionCidMappingRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 查询请求体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public QueryInterconnectionCidMappingRequestRequestParams RequestParams { get; set; }
        public class QueryInterconnectionCidMappingRequestRequestParams : TeaModel {
            [NameInMap("SrcCid")]
            [Validation(Required=false)]
            public string SrcCid { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public long? Type { get; set; }
        };

    }

}
