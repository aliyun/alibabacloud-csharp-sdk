// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeActiveOperationTaskCountResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether any O\&amp;M tasks need pop-up windows to notify users actions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No O\&amp;M tasks need pop-up windows to notify users actions.</description></item>
        /// <item><description><b>1</b>: Some O\&amp;M tasks need pop-up windows to notify users actions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NeedPop")]
        [Validation(Required=false)]
        public int? NeedPop { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D9F3768-EDA9-4811-943E-42C8006E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of pending O\&amp;M tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskCount")]
        [Validation(Required=false)]
        public int? TaskCount { get; set; }

    }

}
