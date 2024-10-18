// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class GetJobLogRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-jeJki6****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.manager</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The log type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>stdout: standard output logs.</description></item>
        /// <item><description>stderr: error output logs.</description></item>
        /// <item><description>all: all logs.</description></item>
        /// </list>
        /// <para>Default value: all.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stdout</para>
        /// </summary>
        [NameInMap("LogType")]
        [Validation(Required=false)]
        public string LogType { get; set; }

        /// <summary>
        /// <para>The position where logs start to be read.</para>
        /// <para>Unit: bytes.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public string Offset { get; set; }

        /// <summary>
        /// <para>The maximum size of logs that you can read in a single request.</para>
        /// <para>Unit: bytes.</para>
        /// <para>Default value: 10240.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20480</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

    }

}
