// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of the entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The user groups.</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<DescribeGroupsResponseBodyGroups> Groups { get; set; }
        public class DescribeGroupsResponseBodyGroups : TeaModel {
            [NameInMap("AttachedLoginPolicy")]
            [Validation(Required=false)]
            public DescribeGroupsResponseBodyGroupsAttachedLoginPolicy AttachedLoginPolicy { get; set; }
            public class DescribeGroupsResponseBodyGroupsAttachedLoginPolicy : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

            }

            /// <summary>
            /// <para>The type of the resource assigned to the user group.</para>
            /// </summary>
            [NameInMap("AuthedResources")]
            [Validation(Required=false)]
            public Dictionary<string, string> AuthedResources { get; set; }

            /// <summary>
            /// <para>The time when the user group is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-08-07T13:40:40+08:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A test group.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ug-2412ojkwtybd****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestGroup</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>Indicates whether the file approval feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("TransferFileNeedApproval")]
            [Validation(Required=false)]
            public bool? TransferFileNeedApproval { get; set; }

            /// <summary>
            /// <para>The number of users in the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public int? UserCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
