// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribePostpayTrafficTotalResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>826B6280-9704-5643-97B1-6B47AC3F027A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of assets that are protected by border firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TotalAssets")]
        [Validation(Required=false)]
        public long? TotalAssets { get; set; }

        /// <summary>
        /// <para>For the subscription edition, this is the total billed elastic traffic after deductions are applied. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2320274874426</para>
        /// </summary>
        [NameInMap("TotalBillTraffic")]
        [Validation(Required=false)]
        public long? TotalBillTraffic { get; set; }

        /// <summary>
        /// <para>The total number of assets that are protected by Internet Border firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("TotalInternetAssets")]
        [Validation(Required=false)]
        public long? TotalInternetAssets { get; set; }

        /// <summary>
        /// <para>The total traffic of the Internet Border. For the subscription edition, this is the total elastic traffic of the Internet Border. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2320274874426</para>
        /// </summary>
        [NameInMap("TotalInternetTraffic")]
        [Validation(Required=false)]
        public long? TotalInternetTraffic { get; set; }

        /// <summary>
        /// <para>The total number of assets that are protected by NAT border firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNatAssets")]
        [Validation(Required=false)]
        public long? TotalNatAssets { get; set; }

        /// <summary>
        /// <para>The total traffic of the NAT border. For the subscription edition, this is the total elastic traffic of the NAT border. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>560646279</para>
        /// </summary>
        [NameInMap("TotalNatTraffic")]
        [Validation(Required=false)]
        public long? TotalNatTraffic { get; set; }

        /// <summary>
        /// <para>The total billed traffic for data leakage detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalSdlBillTraffic")]
        [Validation(Required=false)]
        public long? TotalSdlBillTraffic { get; set; }

        /// <summary>
        /// <para>The total free traffic for data leakage detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalSdlFreeTraffic")]
        [Validation(Required=false)]
        public long? TotalSdlFreeTraffic { get; set; }

        /// <summary>
        /// <para>The total traffic. For the subscription edition, this is the total elastic traffic. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2320274874426</para>
        /// </summary>
        [NameInMap("TotalTraffic")]
        [Validation(Required=false)]
        public long? TotalTraffic { get; set; }

        /// <summary>
        /// <para>The total number of assets that are protected by VPC border firewalls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalVpcAssets")]
        [Validation(Required=false)]
        public long? TotalVpcAssets { get; set; }

        /// <summary>
        /// <para>The total traffic of the VPC border. For the subscription edition, this is the total elastic traffic of the VPC border. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2320274874426</para>
        /// </summary>
        [NameInMap("TotalVpcTraffic")]
        [Validation(Required=false)]
        public long? TotalVpcTraffic { get; set; }

    }

}
