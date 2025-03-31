// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class DescribeWorkgroupsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the workgroup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The state of the workgroup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NotStarted</description></item>
        /// <item><description>InProgress</description></item>
        /// <item><description>Cutover</description></item>
        /// <item><description>Completed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InProgress</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tag information of workgroups.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeWorkgroupsRequestTag> Tag { get; set; }
        public class DescribeWorkgroupsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the workgroup. Valid values of N: 1 to 20.</para>
            /// <para>You cannot specify an empty string as a tag key. The tag key can be up to 64 characters in length and cannot contain http:// or https://. The tag key cannot start with acs: or aliyun.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the workgroup. Valid values of N: 1 to 20.</para>
            /// <para>You can specify an empty string as a tag value. The tag value can be up to 64 characters in length and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The workgroup IDs. You can specify up to 50 workgroup IDs.</para>
        /// </summary>
        [NameInMap("WorkgroupId")]
        [Validation(Required=false)]
        public List<string> WorkgroupId { get; set; }

    }

}
