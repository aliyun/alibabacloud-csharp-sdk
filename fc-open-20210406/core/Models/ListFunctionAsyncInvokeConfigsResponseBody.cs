// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListFunctionAsyncInvokeConfigsResponseBody : TeaModel {
        /// <summary>
        /// The list of asynchronous invocation configurations.
        /// </summary>
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<ListFunctionAsyncInvokeConfigsResponseBodyConfigs> Configs { get; set; }
        public class ListFunctionAsyncInvokeConfigsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// The time when the desktop group was created.
            /// </summary>
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// The configuration structure of the destination for asynchronous invocations. If you have not configured this parameter, this parameter is null.
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
            /// The maximum validity period of a message. If you have not configured this parameter, this parameter is null.
            /// </summary>
            [NameInMap("maxAsyncEventAgeInSeconds")]
            [Validation(Required=false)]
            public long? MaxAsyncEventAgeInSeconds { get; set; }

            /// <summary>
            /// The maximum number of retries allowed after an asynchronous invocation fails. If you have not configured this parameter, this parameter is null.
            /// </summary>
            [NameInMap("maxAsyncRetryAttempts")]
            [Validation(Required=false)]
            public long? MaxAsyncRetryAttempts { get; set; }

            /// <summary>
            /// The version or alias of the service.
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
            /// Indicates whether the asynchronous task feature is enabled.
            /// 
            /// *   **true**: The asynchronous task feature is enabled.
            /// *   **false**: The asynchronous task feature is disabled.
            /// 
            /// If you have not configured this parameter, this parameter is null.
            /// </summary>
            [NameInMap("statefulInvocation")]
            [Validation(Required=false)]
            public bool? StatefulInvocation { get; set; }

        }

        /// <summary>
        /// The token used to obtain more results.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
