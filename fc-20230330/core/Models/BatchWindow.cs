// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class BatchWindow : TeaModel {
        /// <summary>
        /// <para>The maximum number of events that are allowed in the batch window. When this threshold is reached, data in the window is pushed downstream. If multiple batch windows exist, data is pushed if triggering conditions are met in one of the windows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("CountBasedWindow")]
        [Validation(Required=false)]
        public int? CountBasedWindow { get; set; }

        /// <summary>
        /// <para>The maximum period of time during which events are allowed in the batch window. Unit: seconds. When this threshold is reached, data in the window is pushed downstream. If multiple batch windows exist, data is pushed if triggering conditions are met in one of the windows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TimeBasedWindow")]
        [Validation(Required=false)]
        public int? TimeBasedWindow { get; set; }

    }

}
