// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeActiveOperationTaskCountResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether a pop-up notification is required. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Required.</description></item>
        /// <item><description>0: Not required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NeedPop")]
        [Validation(Required=false)]
        public long? NeedPop { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC7E27FC-58F8-4722-89BB-D1B6D0971956</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TaskCount")]
        [Validation(Required=false)]
        public long? TaskCount { get; set; }

    }

}
