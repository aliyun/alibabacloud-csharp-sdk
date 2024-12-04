// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeActiveOperationTaskCountResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NeedPop")]
        [Validation(Required=false)]
        public long? NeedPop { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EC7E27FC-58F8-4722-89BB-D1B6D0971956</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TaskCount")]
        [Validation(Required=false)]
        public long? TaskCount { get; set; }

    }

}
