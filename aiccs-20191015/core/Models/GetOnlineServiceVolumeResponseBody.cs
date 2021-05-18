// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetOnlineServiceVolumeResponseBody : TeaModel {
        /// <summary>
        /// 错误描述
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 错误编码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 调用接口是否成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOnlineServiceVolumeResponseBodyData Data { get; set; }
        public class GetOnlineServiceVolumeResponseBodyData : TeaModel {
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }
        };

        /// <summary>
        /// 请求ID，用于跟踪错误原因
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
