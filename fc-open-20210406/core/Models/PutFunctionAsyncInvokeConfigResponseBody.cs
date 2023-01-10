// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class PutFunctionAsyncInvokeConfigResponseBody : TeaModel {
        /// <summary>
        /// The creation time.
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// The configuration structure of the destination for asynchronous invocation.
        /// </summary>
        [NameInMap("destinationConfig")]
        [Validation(Required=false)]
        public DestinationConfig DestinationConfig { get; set; }

        /// <summary>
        /// The name of the function.
        /// </summary>
        [NameInMap("function")]
        [Validation(Required=false)]
        public string Function { get; set; }

        /// <summary>
        /// The time when the configuration was last modified.
        /// </summary>
        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// The maximum validity period of messages.
        /// </summary>
        [NameInMap("maxAsyncEventAgeInSeconds")]
        [Validation(Required=false)]
        public long? MaxAsyncEventAgeInSeconds { get; set; }

        /// <summary>
        /// The maximum number of retries allowed after an asynchronous invocation fails.
        /// </summary>
        [NameInMap("maxAsyncRetryAttempts")]
        [Validation(Required=false)]
        public long? MaxAsyncRetryAttempts { get; set; }

        /// <summary>
        /// The qualifier.
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// The name of the service.
        /// </summary>
        [NameInMap("service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// Specifies whether to enable the asynchronous task feature. 
        /// 
        /// - **true**: enables the asynchronous task feature. 
        /// - **false**: does not enable the asynchronous task feature.
        /// </summary>
        [NameInMap("statefulInvocation")]
        [Validation(Required=false)]
        public bool? StatefulInvocation { get; set; }

    }

}
