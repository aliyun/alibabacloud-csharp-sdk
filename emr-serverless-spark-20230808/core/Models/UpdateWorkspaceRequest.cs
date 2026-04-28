// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class UpdateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("cu")]
        [Validation(Required=false)]
        public int? Cu { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        [NameInMap("gpuSpec")]
        [Validation(Required=false)]
        public List<string> GpuSpec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfmwpi66knkxny</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("subscription")]
        [Validation(Required=false)]
        public UpdateWorkspaceRequestSubscription Subscription { get; set; }
        public class UpdateWorkspaceRequestSubscription : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("autoRenew")]
            [Validation(Required=false)]
            public string AutoRenew { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("autoRenewPeriod")]
            [Validation(Required=false)]
            public string AutoRenewPeriod { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MONTH</para>
            /// </summary>
            [NameInMap("autoRenewPeriodUnit")]
            [Validation(Required=false)]
            public string AutoRenewPeriodUnit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-token-asxkxxxxxxx</para>
            /// </summary>
            [NameInMap("clientToken")]
            [Validation(Required=false)]
            public string ClientToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1799</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MONTH</para>
            /// </summary>
            [NameInMap("paymentDurationUnit")]
            [Validation(Required=false)]
            public string PaymentDurationUnit { get; set; }

            [NameInMap("queue")]
            [Validation(Required=false)]
            public List<string> Queue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>w-975bcfda9625****</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("workspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
