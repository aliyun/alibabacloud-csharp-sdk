// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ApplyCoordinationForMonitoringRequest : TeaModel {
        /// <summary>
        /// <para>The coordination policy.</para>
        /// <para>Set the value to FULL_CONTROL.</para>
        /// <list type="bullet">
        /// <item><description><para>The value FULL_CONTROL specifies that the cloud desktop is shared and remote access to the cloud desktop is allowed.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FULL_CONTROL</para>
        /// </summary>
        [NameInMap("CoordinatePolicyType")]
        [Validation(Required=false)]
        public string CoordinatePolicyType { get; set; }

        /// <summary>
        /// <para>The ID of the end user who initiates the stream collaboration. If the initiator is the administrator, do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The type of the initiator.</para>
        /// <para>Set the value to ADMIN_INITIATE.</para>
        /// <list type="bullet">
        /// <item><description><para>The value ADMIN_INITIATE specifies that the administrator initiates the coordination request.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ADMIN_INITIATE</para>
        /// </summary>
        [NameInMap("InitiatorType")]
        [Validation(Required=false)]
        public string InitiatorType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://next.api.aliyun.com/document/ecd/2020-09-30/DescribeRegions">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of cloud desktops that run the collaboration task at the same time.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceCandidates")]
        [Validation(Required=false)]
        public List<ApplyCoordinationForMonitoringRequestResourceCandidates> ResourceCandidates { get; set; }
        public class ApplyCoordinationForMonitoringRequestResourceCandidates : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the current cloud desktop belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130247021517****</para>
            /// </summary>
            [NameInMap("OwnerAliUid")]
            [Validation(Required=false)]
            public long? OwnerAliUid { get; set; }

            /// <summary>
            /// <para>The ID of the current end user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("OwnerEndUserId")]
            [Validation(Required=false)]
            public string OwnerEndUserId { get; set; }

            /// <summary>
            /// <para>The ID of the cloud desktop.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-08zhejm3h7ilr****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The name of the cloud desktop.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestDesktop</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The properties of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestProperty</para>
            /// </summary>
            [NameInMap("ResourceProperties")]
            [Validation(Required=false)]
            public string ResourceProperties { get; set; }

            /// <summary>
            /// <para>The region where the resource resides.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// <para>Set the value to CLOUD_DESKTOP.</para>
            /// <list type="bullet">
            /// <item><description><para>The value CLOUD_DESKTOP specifies that the resource is a cloud desktop.</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CLOUD_DESKTOP</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The universally unique identifier (UUID) of the device.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>62f2f1f252f04e0e9d8bc****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
