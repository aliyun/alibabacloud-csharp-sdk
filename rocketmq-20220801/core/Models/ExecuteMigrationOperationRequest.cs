// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ExecuteMigrationOperationRequest : TeaModel {
        [NameInMap("operationParam")]
        [Validation(Required=false)]
        public ExecuteMigrationOperationRequestOperationParam OperationParam { get; set; }
        public class ExecuteMigrationOperationRequestOperationParam : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("paramData")]
            [Validation(Required=false)]
            public object ParamData { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rmq-cn-x0r37kelk0o</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
