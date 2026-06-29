// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class Job : TeaModel {
        /// <summary>
        /// <para>Job creator.</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public SimpleUser Creator { get; set; }

        /// <summary>
        /// <para>Creation Time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-28 11:42:19</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>Updated At.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-28 11:42:20</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>Job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>147***441221943296</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>Task Result.</para>
        /// </summary>
        [NameInMap("JobResult")]
        [Validation(Required=false)]
        public JobJobResult JobResult { get; set; }
        public class JobJobResult : TeaModel {
            /// <summary>
            /// <para>Return value link, which is the OSS path where the annotation results are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://****-hz-oss.oss-cn-hangzhou.aliyuncs.com/output/ocr_demo001.manifest</para>
            /// </summary>
            [NameInMap("ResultLink")]
            [Validation(Required=false)]
            public string ResultLink { get; set; }

        }

        /// <summary>
        /// <para>Task Type. Currently, only DOWNLOWD_MARKRESULT_FLOW is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DOWNLOWD_MARKRESULT_FLOW</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>Job status. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>init: initialization</description></item>
        /// <item><description>running: running</description></item>
        /// <item><description>pause: pause</description></item>
        /// <item><description>stop: stopped</description></item>
        /// <item><description>succ: Succeeded</description></item>
        /// <item><description>fail: failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>succ</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
