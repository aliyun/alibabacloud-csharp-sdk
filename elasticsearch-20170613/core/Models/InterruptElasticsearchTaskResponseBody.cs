// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class InterruptElasticsearchTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. Only displayed if an exception is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceStatusNotSupportCurrentAction</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message. Only displayed if an exception is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The cluster is running tasks or in an error status. Try again later.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return results:</para>
        /// <list type="bullet">
        /// <item><description>true: interrupted change successfully</description></item>
        /// <item><description>false: interrupted change failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

    }

}
