// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListNodeGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The node groups.</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<ListNodeGroupsResponseBodyGroups> Groups { get; set; }
        public class ListNodeGroupsResponseBodyGroups : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i113952461729854708648</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wzq-exclusivelite-71</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-27T13:16:31.599</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>created by ga2_prepare</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether file storage mounting is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("FileSystemMountEnabled")]
            [Validation(Required=false)]
            public bool? FileSystemMountEnabled { get; set; }

            /// <summary>
            /// <para>The group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>238276221</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>backend-group</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i194015071707321240258</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CentOS_7.9_x86_64_FULL_20221110</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>efg1.nvga1n</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public string MachineType { get; set; }

            /// <summary>
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public long? NodeCount { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-22T00:03:05.114</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen-c</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>563d42ae0b17572449ec8c97f7f66069</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>887FA855-89F4-5DB3-B305-C5879EC480E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
