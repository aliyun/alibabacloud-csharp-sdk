// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeSelectItemResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeSelectItemResponseBodyResultObject ResultObject { get; set; }
        public class DescribeSelectItemResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Monitoring status list.</para>
            /// </summary>
            [NameInMap("monitorStatusList")]
            [Validation(Required=false)]
            public List<string> MonitorStatusList { get; set; }

            /// <summary>
            /// <para>Task ID list.</para>
            /// </summary>
            [NameInMap("taskIdList")]
            [Validation(Required=false)]
            public List<string> TaskIdList { get; set; }

        }

    }

}
