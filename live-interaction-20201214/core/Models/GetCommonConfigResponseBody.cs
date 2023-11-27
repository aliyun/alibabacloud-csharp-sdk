// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetCommonConfigResponseBody : TeaModel {
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

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetCommonConfigResponseBodyResult Result { get; set; }
        public class GetCommonConfigResponseBodyResult : TeaModel {
            [NameInMap("CommonConfig")]
            [Validation(Required=false)]
            public GetCommonConfigResponseBodyResultCommonConfig CommonConfig { get; set; }
            public class GetCommonConfigResponseBodyResultCommonConfig : TeaModel {
                [NameInMap("AppConfigs")]
                [Validation(Required=false)]
                public List<GetCommonConfigResponseBodyResultCommonConfigAppConfigs> AppConfigs { get; set; }
                public class GetCommonConfigResponseBodyResultCommonConfigAppConfigs : TeaModel {
                    /// <summary>
                    /// appKey
                    /// </summary>
                    [NameInMap("AppKey")]
                    [Validation(Required=false)]
                    public string AppKey { get; set; }

                    [NameInMap("Platform")]
                    [Validation(Required=false)]
                    public string Platform { get; set; }

                }

                [NameInMap("LoginConfig")]
                [Validation(Required=false)]
                public GetCommonConfigResponseBodyResultCommonConfigLoginConfig LoginConfig { get; set; }
                public class GetCommonConfigResponseBodyResultCommonConfigLoginConfig : TeaModel {
                    [NameInMap("LoginType")]
                    [Validation(Required=false)]
                    public int? LoginType { get; set; }

                }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
