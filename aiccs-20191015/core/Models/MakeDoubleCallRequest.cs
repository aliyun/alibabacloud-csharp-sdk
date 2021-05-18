// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class MakeDoubleCallRequest : TeaModel {
        /// <summary>
        /// 实例ID
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 账号名称
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// 坐席手机号（需要通过坐席手机呼叫才需要填写）
        /// </summary>
        [NameInMap("ServicerPhone")]
        [Validation(Required=false)]
        public string ServicerPhone { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [NameInMap("MemberPhone")]
        [Validation(Required=false)]
        public string MemberPhone { get; set; }

        /// <summary>
        /// 外呼主叫号码
        /// </summary>
        [NameInMap("OutboundCallNumber")]
        [Validation(Required=false)]
        public string OutboundCallNumber { get; set; }

        /// <summary>
        /// 业务携带数据（JsonString）
        /// </summary>
        [NameInMap("BizData")]
        [Validation(Required=false)]
        public string BizData { get; set; }

    }

}
