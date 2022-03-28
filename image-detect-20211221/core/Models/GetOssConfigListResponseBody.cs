// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Image_detect20211221.Models
{
    public class GetOssConfigListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public GetOssConfigListResponseBodyResponse Response { get; set; }
        public class GetOssConfigListResponseBodyResponse : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetOssConfigListResponseBodyResponseList> List { get; set; }
            public class GetOssConfigListResponseBodyResponseList : TeaModel {
                public string AccessKeyId { get; set; }
                public string ConfigName { get; set; }
                public string GmtCreate { get; set; }
                public string OssBucketName { get; set; }
                public string OssEndpoint { get; set; }
                public string Uid { get; set; }
            }
            [NameInMap("PageIndex")]
            [Validation(Required=false)]
            public long? PageIndex { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
