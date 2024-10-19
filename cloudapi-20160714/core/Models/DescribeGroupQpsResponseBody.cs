// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeGroupQpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of requests directed to the API group.</para>
        /// </summary>
        [NameInMap("GroupQps")]
        [Validation(Required=false)]
        public DescribeGroupQpsResponseBodyGroupQps GroupQps { get; set; }
        public class DescribeGroupQpsResponseBodyGroupQps : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeGroupQpsResponseBodyGroupQpsMonitorItem> MonitorItem { get; set; }
            public class DescribeGroupQpsResponseBodyGroupQpsMonitorItem : TeaModel {
                /// <summary>
                /// <para>The point in time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-08-02T09:15:00Z</para>
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// <para>The number of requests at the specified point in time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>17</para>
                /// </summary>
                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6E46F10-F26C-4AA0-BB69-FE2743D9AE62</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
