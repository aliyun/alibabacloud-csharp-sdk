// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobSettings : TeaModel {
        [NameInMap("AdvancedSettings")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdvancedSettings { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>166924</para>
        /// </summary>
        [NameInMap("BusinessUserId")]
        [Validation(Required=false)]
        public string BusinessUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SilkFlow</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableEcsStockCheck")]
        [Validation(Required=false)]
        public bool? DisableEcsStockCheck { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>535.54.03</para>
        /// </summary>
        [NameInMap("Driver")]
        [Validation(Required=false)]
        public string Driver { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableErrorMonitoringInAIMaster")]
        [Validation(Required=false)]
        public bool? EnableErrorMonitoringInAIMaster { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableOssAppend")]
        [Validation(Required=false)]
        public bool? EnableOssAppend { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRDMA")]
        [Validation(Required=false)]
        public bool? EnableRDMA { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSanityCheck")]
        [Validation(Required=false)]
        public bool? EnableSanityCheck { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableTideResource")]
        [Validation(Required=false)]
        public bool? EnableTideResource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>--enable-log-hang-detection true</para>
        /// </summary>
        [NameInMap("ErrorMonitoringArgs")]
        [Validation(Required=false)]
        public string ErrorMonitoringArgs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("JobReservedMinutes")]
        [Validation(Required=false)]
        public int? JobReservedMinutes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Always</para>
        /// </summary>
        [NameInMap("JobReservedPolicy")]
        [Validation(Required=false)]
        public string JobReservedPolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AcceptQuotaOverSold</para>
        /// </summary>
        [NameInMap("OversoldType")]
        [Validation(Required=false)]
        public string OversoldType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pid-123456</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>--sanity-check-timing=AfterJobFaultTolerant --sanity-check-timeout-ops=MarkJobFai</para>
        /// </summary>
        [NameInMap("SanityCheckArgs")]
        [Validation(Required=false)]
        public string SanityCheckArgs { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

    }

}
