// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiIpControlsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the ACLs. The information is an array of ApiIpControlItem data.</para>
        /// </summary>
        [NameInMap("ApiIpControls")]
        [Validation(Required=false)]
        public DescribeApiIpControlsResponseBodyApiIpControls ApiIpControls { get; set; }
        public class DescribeApiIpControlsResponseBodyApiIpControls : TeaModel {
            [NameInMap("ApiIpControlItem")]
            [Validation(Required=false)]
            public List<DescribeApiIpControlsResponseBodyApiIpControlsApiIpControlItem> ApiIpControlItem { get; set; }
            public class DescribeApiIpControlsResponseBodyApiIpControlsApiIpControlItem : TeaModel {
                /// <summary>
                /// <para>The ID of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>46fbb52840d146f186e38e8e70fc8c90</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// <para>The name of the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testapi</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>The time of binding.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-07-23T08:28:48Z</para>
                /// </summary>
                [NameInMap("BoundTime")]
                [Validation(Required=false)]
                public string BoundTime { get; set; }

                /// <summary>
                /// <para>The ID of the ACL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dd05f1c54d6749eda95f9fa6d491449a</para>
                /// </summary>
                [NameInMap("IpControlId")]
                [Validation(Required=false)]
                public string IpControlId { get; set; }

                /// <summary>
                /// <para>The name of the ACL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testControlName</para>
                /// </summary>
                [NameInMap("IpControlName")]
                [Validation(Required=false)]
                public string IpControlName { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
