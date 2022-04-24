// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class UpgradePackageResponseBody : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 成功和失败的机器人code
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpgradePackageResponseBodyData Data { get; set; }
        public class UpgradePackageResponseBodyData : TeaModel {
            [NameInMap("FailedRobotCodes")]
            [Validation(Required=false)]
            public List<string> FailedRobotCodes { get; set; }
            [NameInMap("SuccessRobotCodes")]
            [Validation(Required=false)]
            public List<string> SuccessRobotCodes { get; set; }
        };

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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

    }

}
