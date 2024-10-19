// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeTrafficControlsByApiResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ004</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned throttling policy information. It is an array consisting of TrafficControlItem data.</para>
        /// </summary>
        [NameInMap("TrafficControlItems")]
        [Validation(Required=false)]
        public DescribeTrafficControlsByApiResponseBodyTrafficControlItems TrafficControlItems { get; set; }
        public class DescribeTrafficControlsByApiResponseBodyTrafficControlItems : TeaModel {
            [NameInMap("TrafficControlItem")]
            [Validation(Required=false)]
            public List<DescribeTrafficControlsByApiResponseBodyTrafficControlItemsTrafficControlItem> TrafficControlItem { get; set; }
            public class DescribeTrafficControlsByApiResponseBodyTrafficControlItemsTrafficControlItem : TeaModel {
                /// <summary>
                /// <para>The binding time of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-07-23T08:28:48Z</para>
                /// </summary>
                [NameInMap("BoundTime")]
                [Validation(Required=false)]
                public string BoundTime { get; set; }

                /// <summary>
                /// <para>The ID of the throttling policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dd05f1c54d6749eda95f9fa6d491449a</para>
                /// </summary>
                [NameInMap("TrafficControlItemId")]
                [Validation(Required=false)]
                public string TrafficControlItemId { get; set; }

                /// <summary>
                /// <para>The name of the throttling policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysecret</para>
                /// </summary>
                [NameInMap("TrafficControlItemName")]
                [Validation(Required=false)]
                public string TrafficControlItemName { get; set; }

            }

        }

    }

}
