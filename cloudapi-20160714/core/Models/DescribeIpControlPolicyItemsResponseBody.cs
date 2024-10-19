// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeIpControlPolicyItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about policies. The information is an array of IpControlPolicyItem data.</para>
        /// </summary>
        [NameInMap("IpControlPolicyItems")]
        [Validation(Required=false)]
        public DescribeIpControlPolicyItemsResponseBodyIpControlPolicyItems IpControlPolicyItems { get; set; }
        public class DescribeIpControlPolicyItemsResponseBodyIpControlPolicyItems : TeaModel {
            [NameInMap("IpControlPolicyItem")]
            [Validation(Required=false)]
            public List<DescribeIpControlPolicyItemsResponseBodyIpControlPolicyItemsIpControlPolicyItem> IpControlPolicyItem { get; set; }
            public class DescribeIpControlPolicyItemsResponseBodyIpControlPolicyItemsIpControlPolicyItem : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11112</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The IP addresses or CIDR blocks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>113.125.XX.XX;101.11.XX.XX</para>
                /// </summary>
                [NameInMap("CidrIp")]
                [Validation(Required=false)]
                public string CidrIp { get; set; }

                /// <summary>
                /// <para>The time when the policy was created. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-01-17T06:20:08Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the policy was modified. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-01-17T06:25:13Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The ID of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>P151617000829241</para>
                /// </summary>
                [NameInMap("PolicyItemId")]
                [Validation(Required=false)]
                public string PolicyItemId { get; set; }

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
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
