// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Um_test20211027.Models
{
    public class GetOssUploadParamResponseBody : TeaModel {
        /// <summary>
        /// 请求唯一ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// code
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetOssUploadParamResponseBodyData Data { get; set; }
        public class GetOssUploadParamResponseBodyData : TeaModel {
            [NameInMap("accessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }
            [NameInMap("callback")]
            [Validation(Required=false)]
            public string Callback { get; set; }
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }
            [NameInMap("policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }
            [NameInMap("signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
            [NameInMap("uploadAddress")]
            [Validation(Required=false)]
            public string UploadAddress { get; set; }
        };

        /// <summary>
        /// 异常描述
        /// </summary>
        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
