// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class AiRtcLicenseInfoDTO : TeaModel {
        /// <summary>
        /// <para>The remaining usage capacity of the batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000000</para>
        /// </summary>
        [NameInMap("AvailableCapacity")]
        [Validation(Required=false)]
        public long? AvailableCapacity { get; set; }

        /// <summary>
        /// <para>The time when the batch became active.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-23T13:33:49Z</para>
        /// </summary>
        [NameInMap("BeginOn")]
        [Validation(Required=false)]
        public string BeginOn { get; set; }

        /// <summary>
        /// <para>The contract number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258396267390***</para>
        /// </summary>
        [NameInMap("ContractNo")]
        [Validation(Required=false)]
        public string ContractNo { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-23T13:33:49Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-23T13:33:49Z</para>
        /// </summary>
        [NameInMap("ExpiredOn")]
        [Validation(Required=false)]
        public string ExpiredOn { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ice_CoverAILicense_public_cn***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The total number of licenses contained within this batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("LicenseCount")]
        [Validation(Required=false)]
        public long? LicenseCount { get; set; }

        /// <summary>
        /// <para>The ID of the batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17712***</para>
        /// </summary>
        [NameInMap("LicenseItemId")]
        [Validation(Required=false)]
        public string LicenseItemId { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-23T13:33:49Z</para>
        /// </summary>
        [NameInMap("ModificationTime")]
        [Validation(Required=false)]
        public string ModificationTime { get; set; }

        /// <summary>
        /// <para>The status of the batch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Active</description></item>
        /// <item><description>2\. Expired</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The license type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Audio call</description></item>
        /// <item><description>2: Vision call</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>The validity period of the licenses in this batch, in days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("ValidDays")]
        [Validation(Required=false)]
        public long? ValidDays { get; set; }

    }

}
