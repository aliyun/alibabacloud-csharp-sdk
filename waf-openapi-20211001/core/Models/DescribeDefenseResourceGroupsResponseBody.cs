// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseResourceGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of protected object groups.</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<DescribeDefenseResourceGroupsResponseBodyGroups> Groups { get; set; }
        public class DescribeDefenseResourceGroupsResponseBodyGroups : TeaModel {
            /// <summary>
            /// <para>The description of the protected object group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is test description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the protected object group was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1624343180000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The most recent time when the protected object group was modified. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1701656305000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The name of the protected object group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apptest</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The names of the protected objects that are added to the protected object group. Separate multiple protected objects with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>example02.aliyun-waf,example01.aliyun-waf</para>
            /// </summary>
            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public string ResourceList { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BFEC5C77-049B-5E88-A5B6-CB0C****B66E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
