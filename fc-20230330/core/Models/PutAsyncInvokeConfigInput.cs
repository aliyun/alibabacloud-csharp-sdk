// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutAsyncInvokeConfigInput : TeaModel {
        /// <summary>
        /// <para>Optional. Specify whether to enable the asynchronous task feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("asyncTask")]
        [Validation(Required=false)]
        public bool? AsyncTask { get; set; }

        /// <summary>
        /// <para>Optional. The struct of the destination of asynchronous invocations.</para>
        /// </summary>
        [NameInMap("destinationConfig")]
        [Validation(Required=false)]
        public DestinationConfig DestinationConfig { get; set; }

        /// <summary>
        /// <para>Optional. The maximum validity period of a message. Valid values: [1,604800]. Default value: 86400. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("maxAsyncEventAgeInSeconds")]
        [Validation(Required=false)]
        public long? MaxAsyncEventAgeInSeconds { get; set; }

        /// <summary>
        /// <para>Optional. The maximum number of retries if an asynchronous invocation fails. Valid values: [0,8]. If you do not configure this parameter, the default number of retries is 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("maxAsyncRetryAttempts")]
        [Validation(Required=false)]
        public long? MaxAsyncRetryAttempts { get; set; }

    }

}
