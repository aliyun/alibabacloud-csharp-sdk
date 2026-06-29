// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class FlowJobInfo : TeaModel {
        /// <summary>
        /// <para>Whether to display. Possible values are:</para>
        /// <list type="bullet">
        /// <item><description>true: Display.</description></item>
        /// <item><description>false: Do not display.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Display")]
        [Validation(Required=false)]
        public bool? Display { get; set; }

        /// <summary>
        /// <para>Job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1475***441221943296</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

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
        /// <para>Message ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>792B76F4000E681A95155146A002D5F8</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>Processing information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NEW_INIT</para>
        /// </summary>
        [NameInMap("ProcessType")]
        [Validation(Required=false)]
        public string ProcessType { get; set; }

        /// <summary>
        /// <para>Job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1543***518306500608</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
