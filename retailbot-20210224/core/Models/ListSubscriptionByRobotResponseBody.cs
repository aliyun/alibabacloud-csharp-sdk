// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class ListSubscriptionByRobotResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 订阅的行业包
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSubscriptionByRobotResponseBodyData> Data { get; set; }
        public class ListSubscriptionByRobotResponseBodyData : TeaModel {
            /// <summary>
            /// 行业包code
            /// </summary>
            [NameInMap("PackageCode")]
            [Validation(Required=false)]
            public string PackageCode { get; set; }

            /// <summary>
            /// 行业包版本
            /// </summary>
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public string PackageVersion { get; set; }

            /// <summary>
            /// 机器人code
            /// </summary>
            [NameInMap("RobotCode")]
            [Validation(Required=false)]
            public string RobotCode { get; set; }

        }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
