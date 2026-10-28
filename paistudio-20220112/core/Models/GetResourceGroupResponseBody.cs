// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster to which the resource group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb2c7bde30b774e46a329c</para>
        /// </summary>
        [NameInMap("ClusterID")]
        [Validation(Required=false)]
        public string ClusterID { get; set; }

        /// <summary>
        /// <para>The type of compute resources for the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ComputingResourceProvider")]
        [Validation(Required=false)]
        public string ComputingResourceProvider { get; set; }

        /// <summary>
        /// <para>The user ID of the creator of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1612285282502324</para>
        /// </summary>
        [NameInMap("CreatorID")]
        [Validation(Required=false)]
        public string CreatorID { get; set; }

        /// <summary>
        /// <para>The description of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the resource group was created. The time follows the ISO 8601 standard in the UTC time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtCreatedTime")]
        [Validation(Required=false)]
        public string GmtCreatedTime { get; set; }

        /// <summary>
        /// <para>The time when the resource group was updated. The time follows the ISO 8601 standard in the UTC time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-22T00:00:00Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The name of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestResourceGroup</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18D5A1C6-14B8-545E-8408-0A7DDB4C6B5E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of compute resources for the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ecs</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The status of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the resource group supports RDMA.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportRDMA")]
        [Validation(Required=false)]
        public bool? SupportRDMA { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetResourceGroupResponseBodyTags> Tags { get; set; }
        public class GetResourceGroupResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The details of the VPC connected to the resource group.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UserVpc UserVpc { get; set; }

        /// <summary>
        /// <para>The version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35201</para>
        /// </summary>
        [NameInMap("WorkspaceID")]
        [Validation(Required=false)]
        public string WorkspaceID { get; set; }

    }

}
