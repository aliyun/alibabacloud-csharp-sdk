// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListAvailableServiceAddressRequest : TeaModel {
        /// <summary>
        /// <para>The type of the service address for the Smart Access Gateway instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ProbeTask</b>: the source IP address for network probes.</para>
        /// </description></item>
        /// <item><description><para><b>RemoteWeb</b>: the IP address for remote logon.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, all types of service addresses are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ProbeTask</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Smart Access Gateway instance is deployed.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/69813.html">DescribeRegions</a> operation to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Smart Access Gateway instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-****</para>
        /// </summary>
        [NameInMap("SagId")]
        [Validation(Required=false)]
        public string SagId { get; set; }

        /// <summary>
        /// <para>The serial number of the Smart Access Gateway device.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag****</para>
        /// </summary>
        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

    }

}
