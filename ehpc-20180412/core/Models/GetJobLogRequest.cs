// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetJobLogRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-jeJki6****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The node on which the job runs.</para>
        /// <list type="bullet">
        /// <item><description>If the job is completed, you do not need to specify the parameter.</description></item>
        /// <item><description>If the job is running, you must specify the parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>compute000</para>
        /// </summary>
        [NameInMap("ExecHost")]
        [Validation(Required=false)]
        public string ExecHost { get; set; }

        /// <summary>
        /// <para>The ID of the job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.scheduler****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The position where logs start to be read.</para>
        /// <para>Unit: bits</para>
        /// <para>Default value: 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// <para>The maximum size of logs that you can read in a single request.</para>
        /// <para>Unit: bits</para>
        /// <para>Default value: 1024</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
