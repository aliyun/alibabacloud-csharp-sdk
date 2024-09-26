// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class CommitContainerRequest : TeaModel {
        /// <summary>
        /// <para>The access credential configurations of the Container Registry Enterprise Edition instance.</para>
        /// <remarks>
        /// <para> If you use a Container Registry Personal Edition instance, you do not need to configure this parameter. If you use a Container Registry Enterprise Edition instance, you must configure this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("AcrRegistryInfo")]
        [Validation(Required=false)]
        public CommitContainerRequestAcrRegistryInfo AcrRegistryInfo { get; set; }
        public class CommitContainerRequestAcrRegistryInfo : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Access (ARN) of the RAM role that is assigned to the user (the authorized account) in cross-account authorization scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1609982529******:role/role-test</para>
            /// </summary>
            [NameInMap("ArnService")]
            [Validation(Required=false)]
            public string ArnService { get; set; }

            /// <summary>
            /// <para>The ARN of the RAM role that is assigned to the authorizer in cross-account authorization scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1298452580******:role/role-test</para>
            /// </summary>
            [NameInMap("ArnUser")]
            [Validation(Required=false)]
            public string ArnUser { get; set; }

            /// <summary>
            /// <para>The ID of the Container Registry Enterprise Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-nwj395hgf6f3****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region ID of the Container Registry Enterprise Edition instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The details about the ARN that is required for authorization.</para>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public CommitContainerRequestArn Arn { get; set; }
        public class CommitContainerRequestArn : TeaModel {
            /// <summary>
            /// <para>The ARN of the authorized role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram:xxx</para>
            /// </summary>
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The authorization type. A value of service indicates that RAM roles are used for authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the container group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eci-bp1do4xz75fa5sd****</para>
        /// </summary>
        [NameInMap("ContainerGroupId")]
        [Validation(Required=false)]
        public string ContainerGroupId { get; set; }

        /// <summary>
        /// <para>The name of the container.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>container-1</para>
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// <para>The image of the container.</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public CommitContainerRequestImage Image { get; set; }
        public class CommitContainerRequestImage : TeaModel {
            /// <summary>
            /// <para>The authorization of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECI</para>
            /// </summary>
            [NameInMap("Author")]
            [Validation(Required=false)]
            public string Author { get; set; }

            /// <summary>
            /// <para>The message about the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test commit</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The image repository.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/eastest/registry-test</para>
            /// </summary>
            [NameInMap("Repository")]
            [Validation(Required=false)]
            public string Repository { get; set; }

            /// <summary>
            /// <para>The tag of the image. This parameter is empty by default, which indicates that the tag is not modified.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.6</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
