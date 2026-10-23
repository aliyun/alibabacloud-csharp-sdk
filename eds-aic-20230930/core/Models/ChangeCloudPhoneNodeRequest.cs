// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ChangeCloudPhoneNodeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The display settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dpi&quot;:320}</para>
        /// </summary>
        [NameInMap("DisplayConfig")]
        [Validation(Required=false)]
        public string DisplayConfig { get; set; }

        /// <summary>
        /// <para>The downstream bandwidth throttling. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DownBandwidthLimit")]
        [Validation(Required=false)]
        public int? DownBandwidthLimit { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac.max</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The ID of the cloud phone matrix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpn-0ugbptfu473fy****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The number of cloud phone instances. You can call the <a href="https://help.aliyun.com/document_detail/2807299.html">DescribeSpec</a> operation to query the maximum and minimum limits on the number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PhoneCount")]
        [Validation(Required=false)]
        public int? PhoneCount { get; set; }

        /// <summary>
        /// <para>The local storage size. Valid values: 10 to 4000. Unit: GiB. If this parameter is left empty, the original size is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PhoneDataVolume")]
        [Validation(Required=false)]
        public int? PhoneDataVolume { get; set; }

        /// <summary>
        /// <para>The ID of the promotion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50003308011****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// <para>The size of the shared storage. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ShareDataVolume")]
        [Validation(Required=false)]
        public int? ShareDataVolume { get; set; }

        /// <summary>
        /// <para>The size of the swap space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SwapSize")]
        [Validation(Required=false)]
        public int? SwapSize { get; set; }

        /// <summary>
        /// <para>The upstream bandwidth throttling. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("UpBandwidthLimit")]
        [Validation(Required=false)]
        public int? UpBandwidthLimit { get; set; }

    }

}
