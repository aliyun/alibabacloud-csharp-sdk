// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class PutFunctionAsyncInvokeConfigRequest : TeaModel {
        [NameInMap("destinationConfig")]
        [Validation(Required=false)]
        public DestinationConfig DestinationConfig { get; set; }

        /// <summary>
        /// 消息最大存活时长
        /// </summary>
        [NameInMap("maxAsyncEventAgeInSeconds")]
        [Validation(Required=false)]
        public long? MaxAsyncEventAgeInSeconds { get; set; }

        /// <summary>
        /// 异步调用失败后的最大重试次数
        /// </summary>
        [NameInMap("maxAsyncRetryAttempts")]
        [Validation(Required=false)]
        public long? MaxAsyncRetryAttempts { get; set; }

        [NameInMap("statefulInvocation")]
        [Validation(Required=false)]
        public bool? StatefulInvocation { get; set; }

        /// <summary>
        /// 别名或版本
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
