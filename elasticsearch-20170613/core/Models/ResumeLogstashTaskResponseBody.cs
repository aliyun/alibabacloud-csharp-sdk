// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ResumeLogstashTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned. If the API operation is successfully called, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InstanceNotFound</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message returned. If the API operation is successfully called, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified cluster does not exist. Check the cluster status and try again.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FA05123-745C-42FD-A69B-AFF48EF9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the change task is resumed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The change task is resumed.</description></item>
        /// <item><description>false: The change task fails to be resumed.</description></item>
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
