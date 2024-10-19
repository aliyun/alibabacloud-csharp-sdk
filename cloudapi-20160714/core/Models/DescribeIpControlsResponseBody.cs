// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeIpControlsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the ACL. The information is an array that consists of IpControlInfo data. The information does not include specific policies.</para>
        /// </summary>
        [NameInMap("IpControlInfos")]
        [Validation(Required=false)]
        public DescribeIpControlsResponseBodyIpControlInfos IpControlInfos { get; set; }
        public class DescribeIpControlsResponseBodyIpControlInfos : TeaModel {
            [NameInMap("IpControlInfo")]
            [Validation(Required=false)]
            public List<DescribeIpControlsResponseBodyIpControlInfosIpControlInfo> IpControlInfo { get; set; }
            public class DescribeIpControlsResponseBodyIpControlInfosIpControlInfo : TeaModel {
                /// <summary>
                /// <para>The time when the ACL was created. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-01-17T05:48:11Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the ACL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the ACL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7ea91319a34d48a09b5c9c871d9768b1</para>
                /// </summary>
                [NameInMap("IpControlId")]
                [Validation(Required=false)]
                public string IpControlId { get; set; }

                /// <summary>
                /// <para>The name of the ACL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testControl11</para>
                /// </summary>
                [NameInMap("IpControlName")]
                [Validation(Required=false)]
                public string IpControlName { get; set; }

                /// <summary>
                /// <para>The type of the ACL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ALLOW</para>
                /// </summary>
                [NameInMap("IpControlType")]
                [Validation(Required=false)]
                public string IpControlType { get; set; }

                /// <summary>
                /// <para>The time when the ACL was modified. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-01-17T06:00:38Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The ID of the region in which the ACL is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-qingdao</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

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
