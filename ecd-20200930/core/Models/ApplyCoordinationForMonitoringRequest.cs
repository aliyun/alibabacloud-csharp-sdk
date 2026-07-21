// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ApplyCoordinationForMonitoringRequest : TeaModel {
        /// <summary>
        /// <para>The access policy during the remote assistance procedure.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FULL_CONTROL</para>
        /// </summary>
        [NameInMap("CoordinatePolicyType")]
        [Validation(Required=false)]
        public string CoordinatePolicyType { get; set; }

        /// <summary>
        /// <para>The ID of the end user who initiates the coordination flow. This parameter is not required if the request is initiated by an administrator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The initiator type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADMIN_INITIATE</para>
        /// </summary>
        [NameInMap("InitiatorType")]
        [Validation(Required=false)]
        public string InitiatorType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of cloud computers that need to accept remote assistance.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceCandidates")]
        [Validation(Required=false)]
        public List<ApplyCoordinationForMonitoringRequestResourceCandidates> ResourceCandidates { get; set; }
        public class ApplyCoordinationForMonitoringRequestResourceCandidates : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID of the cloud computer administrator.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130247021517****</para>
            /// </summary>
            [NameInMap("OwnerAliUid")]
            [Validation(Required=false)]
            public long? OwnerAliUid { get; set; }

            /// <summary>
            /// <para>The username of the current user of the cloud computer.</para>
            /// <remarks>
            /// <para>This field is required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("OwnerEndUserId")]
            [Validation(Required=false)]
            public string OwnerEndUserId { get; set; }

            /// <summary>
            /// <para>The cloud computer ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-08zhejm3h7ilr****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The cloud computer name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DemoComputer</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The properties of the cloud computer.</para>
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
        /// <para>The UUID (unique identifier) of the device.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E14A18BD4D088504B9F8A8751AB****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
