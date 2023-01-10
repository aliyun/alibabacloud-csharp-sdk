// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class PutFunctionAsyncInvokeConfigRequest : TeaModel {
        /// <summary>
        /// The configuration structure of the destination for asynchronous invocation.
        /// </summary>
        [NameInMap("destinationConfig")]
        [Validation(Required=false)]
        public DestinationConfig DestinationConfig { get; set; }

        /// <summary>
        /// The maximum validity period of messages. Valid values: 1 to 2592000. Unit: seconds.
        /// </summary>
        [NameInMap("maxAsyncEventAgeInSeconds")]
        [Validation(Required=false)]
        public long? MaxAsyncEventAgeInSeconds { get; set; }

        /// <summary>
        /// The maximum number of retries allowed after an asynchronous invocation fails. Default value: 3. Valid values: 0 to 8.
        /// </summary>
        [NameInMap("maxAsyncRetryAttempts")]
        [Validation(Required=false)]
        public long? MaxAsyncRetryAttempts { get; set; }

        /// <summary>
        /// Specifies whether to enable the asynchronous task feature. 
        /// 
        /// - **true**: enables the asynchronous task feature. 
        /// - **false**: does not enable the asynchronous task feature.
        /// </summary>
        [NameInMap("statefulInvocation")]
        [Validation(Required=false)]
        public bool? StatefulInvocation { get; set; }

        /// <summary>
        /// The version or alias of the service.
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
