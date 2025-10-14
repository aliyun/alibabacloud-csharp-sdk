// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateCacheReserveSpecRequest : TeaModel {
        /// <summary>
        /// <para>Automatic payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Billing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PREPAY</description></item>
        /// <item><description>POSTPAY</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-cr-9tuv*********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Cache requested size, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TargetQuotaGb")]
        [Validation(Required=false)]
        public long? TargetQuotaGb { get; set; }

    }

}
