// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeBandWithdChargeTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the metering method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;BandWidthName&quot;: &quot;Monthly peak bandwidth of 95&quot;, 			&quot;BandWidthType&quot;: &quot;95BandwidthByMonth&quot; 		}</para>
        /// </summary>
        [NameInMap("BandWithTypeInfo")]
        [Validation(Required=false)]
        public string BandWithTypeInfo { get; set; }

        /// <summary>
        /// <para>The metering type.</para>
        /// <list type="bullet">
        /// <item><description>ChargeByUnified: unified metering.</description></item>
        /// <item><description>ChargeByGrade: differential metering.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ChargeByGrade</para>
        /// </summary>
        [NameInMap("ChargeContractType")]
        [Validation(Required=false)]
        public string ChargeContractType { get; set; }

        /// <summary>
        /// <para>The metering cycle. Currently, this parameter is empty in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{null}</para>
        /// </summary>
        [NameInMap("ChargeCycleInfo")]
        [Validation(Required=false)]
        public string ChargeCycleInfo { get; set; }

        /// <summary>
        /// <para>The returned service code. A value of 0 indicates that the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>791049FD-49CE-4667-BD6C-F23094DEDA7A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
