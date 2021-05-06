// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class GetCommonConfigResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 返回值
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetCommonConfigResponseBodyResult Result { get; set; }
        public class GetCommonConfigResponseBodyResult : TeaModel {
            [NameInMap("CommonConfig")]
            [Validation(Required=false)]
            public GetCommonConfigResponseBodyResultCommonConfig CommonConfig { get; set; }
            public class GetCommonConfigResponseBodyResultCommonConfig : TeaModel {
                /// <summary>
                /// 登录配置
                /// </summary>
                [NameInMap("LoginConfig")]
                [Validation(Required=false)]
                public GetCommonConfigResponseBodyResultCommonConfigLoginConfig LoginConfig { get; set; }
                public class GetCommonConfigResponseBodyResultCommonConfigLoginConfig : TeaModel {
                    [NameInMap("LoginType")]
                    [Validation(Required=false)]
                    public int? LoginType { get; set; }
                };

                /// <summary>
                /// app配置
                /// </summary>
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

                    /// <summary>
                    /// 平台
                    /// </summary>
                    [NameInMap("Platform")]
                    [Validation(Required=false)]
                    public string Platform { get; set; }

                }

                /// <summary>
                /// 多媒体配置
                /// </summary>
                [NameInMap("MediaConfig")]
                [Validation(Required=false)]
                public GetCommonConfigResponseBodyResultCommonConfigMediaConfig MediaConfig { get; set; }
                public class GetCommonConfigResponseBodyResultCommonConfigMediaConfig : TeaModel {
                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }
                };

                /// <summary>
                /// 长连接配置
                /// </summary>
                [NameInMap("ConnectionConfig")]
                [Validation(Required=false)]
                public GetCommonConfigResponseBodyResultCommonConfigConnectionConfig ConnectionConfig { get; set; }
                public class GetCommonConfigResponseBodyResultCommonConfigConnectionConfig : TeaModel {
                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }
                };

            }
        };

    }

}
