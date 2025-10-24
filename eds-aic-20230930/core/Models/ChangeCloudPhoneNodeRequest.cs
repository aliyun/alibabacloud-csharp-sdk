// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ChangeCloudPhoneNodeRequest : TeaModel {
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("DisplayConfig")]
        [Validation(Required=false)]
        public string DisplayConfig { get; set; }

        [NameInMap("DownBandwidthLimit")]
        [Validation(Required=false)]
        public int? DownBandwidthLimit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ac.max</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cpn-0ugbptfu473fy****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PhoneCount")]
        [Validation(Required=false)]
        public int? PhoneCount { get; set; }

        [NameInMap("PhoneDataVolume")]
        [Validation(Required=false)]
        public int? PhoneDataVolume { get; set; }

        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        [NameInMap("ShareDataVolume")]
        [Validation(Required=false)]
        public int? ShareDataVolume { get; set; }

        [NameInMap("SwapSize")]
        [Validation(Required=false)]
        public int? SwapSize { get; set; }

        [NameInMap("UpBandwidthLimit")]
        [Validation(Required=false)]
        public int? UpBandwidthLimit { get; set; }

    }

}
