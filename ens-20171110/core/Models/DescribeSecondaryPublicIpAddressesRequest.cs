// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeSecondaryPublicIpAddressesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the edge node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-44</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The Internet service provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cmcc: China Mobile.</description></item>
        /// <item><description>unicom: China Unicom.</description></item>
        /// <item><description>telecom: China Telecom.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>unicom</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The secondary IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12.XXX.XXX.4</para>
        /// </summary>
        [NameInMap("SecondaryPublicIpAddress")]
        [Validation(Required=false)]
        public string SecondaryPublicIpAddress { get; set; }

        /// <summary>
        /// <para>The ID of the secondary public IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spi-5wys0pio93c9f9ukzj2f2fwyr</para>
        /// </summary>
        [NameInMap("SecondaryPublicIpId")]
        [Validation(Required=false)]
        public string SecondaryPublicIpId { get; set; }

    }

}
