// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class GetEnterpriseDingtalkGroupCustomerMemberResponseBody : TeaModel {
        /// <summary>
        /// 接口请求结果返回码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 成员信息列表
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public EnterpriseDingtalkGroupMember Data { get; set; }

        /// <summary>
        /// 错误信息, 当success=false的时候, 可以取到message
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 接口请求的唯一ID, 每次调用requestID唯一
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 调用接口返回是否成功, true代表调用正常
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
