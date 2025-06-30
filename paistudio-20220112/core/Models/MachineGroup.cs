// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class MachineGroup : TeaModel {
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public long? Cpu { get; set; }

        [NameInMap("CreatorID")]
        [Validation(Required=false)]
        public string CreatorID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>470.199.02</para>
        /// </summary>
        [NameInMap("DefaultDriver")]
        [Validation(Required=false)]
        public string DefaultDriver { get; set; }

        [NameInMap("DiskCapacity")]
        [Validation(Required=false)]
        public long? DiskCapacity { get; set; }

        [NameInMap("DiskPL")]
        [Validation(Required=false)]
        public string DiskPL { get; set; }

        [NameInMap("EcsCount")]
        [Validation(Required=false)]
        public long? EcsCount { get; set; }

        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        [NameInMap("GmtCreatedTime")]
        [Validation(Required=false)]
        public string GmtCreatedTime { get; set; }

        [NameInMap("GmtExpiredTime")]
        [Validation(Required=false)]
        public string GmtExpiredTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("GmtStartedTime")]
        [Validation(Required=false)]
        public string GmtStartedTime { get; set; }

        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public long? Gpu { get; set; }

        [NameInMap("GpuMemory")]
        [Validation(Required=false)]
        public long? GpuMemory { get; set; }

        [NameInMap("GpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mg1</para>
        /// </summary>
        [NameInMap("MachineGroupID")]
        [Validation(Required=false)]
        public string MachineGroupID { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public long? Memory { get; set; }

        [NameInMap("OrderInstanceId")]
        [Validation(Required=false)]
        public string OrderInstanceId { get; set; }

        [NameInMap("PaymentDuration")]
        [Validation(Required=false)]
        public string PaymentDuration { get; set; }

        [NameInMap("PaymentDurationUnit")]
        [Validation(Required=false)]
        public string PaymentDurationUnit { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        [NameInMap("ResourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SupportedDrivers")]
        [Validation(Required=false)]
        public List<string> SupportedDrivers { get; set; }

    }

}
