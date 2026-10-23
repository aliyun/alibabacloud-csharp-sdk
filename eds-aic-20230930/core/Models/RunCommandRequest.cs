// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class RunCommandRequest : TeaModel {
        /// <summary>
        /// <para>The channel type used to execute the command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EdsAgent</para>
        /// </summary>
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        /// <summary>
        /// <para>The command content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ls</para>
        /// </summary>
        [NameInMap("CommandContent")]
        [Validation(Required=false)]
        public string CommandContent { get; set; }

        /// <summary>
        /// <para>The encoding method of the command content (<c>CommandContent</c>). This parameter is case-insensitive.</para>
        /// <remarks>
        /// <para>If the specified value is not within the valid values, it is processed as <c>PlainText</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("ContentEncoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// <para>The list of instance IDs. A single request supports up to 50 instances.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The timeout period. Unit: seconds. If the command is not completed within this period, the command execution status is set to timeout. If this parameter is not specified, the default value is 60 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
