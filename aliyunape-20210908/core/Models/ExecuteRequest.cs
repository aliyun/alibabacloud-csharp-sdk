/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliyunape20210908.Models
{
    public class ExecuteRequest : TeaModel {
        /// <summary>
        /// aliyunPk
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// serviceParam
        /// </summary>
        [NameInMap("ServiceParam")]
        [Validation(Required=false)]
        public Dictionary<string, string> ServiceParam { get; set; }

        /// <summary>
        /// extendParam
        /// </summary>
        [NameInMap("ExtendParam")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtendParam { get; set; }

        /// <summary>
        /// orderId
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// appName
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// source
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

    }

}
