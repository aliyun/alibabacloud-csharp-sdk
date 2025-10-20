// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateWuyingServerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("DataDisk")]
        [Validation(Required=false)]
        public List<CreateWuyingServerRequestDataDisk> DataDisk { get; set; }
        public class CreateWuyingServerRequestDataDisk : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cloud_auto</para>
            /// </summary>
            [NameInMap("DataDiskCategory")]
            [Validation(Required=false)]
            public string DataDiskCategory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("DataDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string DataDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public int? DataDiskSize { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6a1b8c3d</para>
        /// </summary>
        [NameInMap("IdempotenceToken")]
        [Validation(Required=false)]
        public string IdempotenceToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>img-bp13mu****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("NetworkStrategyType")]
        [Validation(Required=false)]
        public string NetworkStrategyType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-643067****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>YourPassword123</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17440009****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eds.proworkstation_flagship_elite_ne.96c384g.192g4x</para>
        /// </summary>
        [NameInMap("ServerInstanceType")]
        [Validation(Required=false)]
        public string ServerInstanceType { get; set; }

        [NameInMap("ServerPortRange")]
        [Validation(Required=false)]
        public string ServerPortRange { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("SystemDiskCategory")]
        [Validation(Required=false)]
        public string SystemDiskCategory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("SystemDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string SystemDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        [NameInMap("VirtualNodePoolId")]
        [Validation(Required=false)]
        public string VirtualNodePoolId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>exampleServerName</para>
        /// </summary>
        [NameInMap("WuyingServerName")]
        [Validation(Required=false)]
        public string WuyingServerName { get; set; }

    }

}
