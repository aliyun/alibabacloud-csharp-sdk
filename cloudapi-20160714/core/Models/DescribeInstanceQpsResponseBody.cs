// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceQpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of requests sent to the APIs in the instance.</para>
        /// </summary>
        [NameInMap("InstanceQps")]
        [Validation(Required=false)]
        public DescribeInstanceQpsResponseBodyInstanceQps InstanceQps { get; set; }
        public class DescribeInstanceQpsResponseBodyInstanceQps : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceQpsResponseBodyInstanceQpsMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceQpsResponseBodyInstanceQpsMonitorItem : TeaModel {
                /// <summary>
                /// <para>The monitoring time. The time follows the ISO 8601 standard. Format: YYYY-MM-DDThh:mm:ssZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-03-29T06:25:00Z</para>
                /// </summary>
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                /// <summary>
                /// <para>The number of requests sent to the APIs in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ004</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
