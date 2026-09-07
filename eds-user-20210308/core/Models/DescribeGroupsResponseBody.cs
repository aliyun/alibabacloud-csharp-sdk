// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned in the query result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of user groups.</para>
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
            /// <para>The list of assigned resources.</para>
            /// </summary>
            [NameInMap("AuthedResources")]
            [Validation(Required=false)]
            public Dictionary<string, string> AuthedResources { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
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
            /// <para>Indicates whether download requires approval.</para>
            /// </summary>
            [NameInMap("DownloadNeedApproval")]
            [Validation(Required=false)]
            public bool? DownloadNeedApproval { get; set; }

            /// <summary>
            /// <para>The user group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ug-2412ojkwtybd****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The user group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestGroup</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>Indicates whether file approval is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("TransferFileNeedApproval")]
            [Validation(Required=false)]
            public bool? TransferFileNeedApproval { get; set; }

            /// <summary>
            /// <para>Indicates whether upload requires approval.</para>
            /// </summary>
            [NameInMap("UploadNeedApproval")]
            [Validation(Required=false)]
            public bool? UploadNeedApproval { get; set; }

            /// <summary>
            /// <para>The number of members in the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("UserCount")]
            [Validation(Required=false)]
            public int? UserCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
