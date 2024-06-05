// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_dg20230914.Models
{
    public class FindUserGatewayByIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Gateway")]
        [Validation(Required=false)]
        public FindUserGatewayByIdResponseBodyGateway Gateway { get; set; }
        public class FindUserGatewayByIdResponseBodyGateway : TeaModel {
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("DgVersion")]
            [Validation(Required=false)]
            public string DgVersion { get; set; }

            [NameInMap("ExceptionMsg")]
            [Validation(Required=false)]
            public string ExceptionMsg { get; set; }

            /// <summary>
            /// 网关的描述
            /// </summary>
            [NameInMap("GatewayDesc")]
            [Validation(Required=false)]
            public string GatewayDesc { get; set; }

            /// <summary>
            /// 网关的编号
            /// </summary>
            [NameInMap("GatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// 网关的名称
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("GatewayName")]
            [Validation(Required=false)]
            public string GatewayName { get; set; }

            [NameInMap("NumOfExceptionInstance")]
            [Validation(Required=false)]
            public int? NumOfExceptionInstance { get; set; }

            [NameInMap("NumOfRunningInstance")]
            [Validation(Required=false)]
            public int? NumOfRunningInstance { get; set; }

            /// <summary>
            /// 地域的编号
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// 网关的状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 用户的编号
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
