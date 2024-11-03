// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeIpInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the IP address belongs to an Alibaba Cloud CDN POP.</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>:Yes.</description></item>
        /// <item><description><b>False</b>:No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("CdnIp")]
        [Validation(Required=false)]
        public string CdnIp { get; set; }

        /// <summary>
        /// <para>The name of the ISP in Chinese.</para>
        /// 
        /// <b>Example:</b>
        /// <para>电信</para>
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// <para>The name of the ISP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>telecom</para>
        /// </summary>
        [NameInMap("IspEname")]
        [Validation(Required=false)]
        public string IspEname { get; set; }

        /// <summary>
        /// <para>The name of the region in Chinese.</para>
        /// 
        /// <b>Example:</b>
        /// <para>中国-贵州省-贵阳市</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The name of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>China-Guizhou-guiyang</para>
        /// </summary>
        [NameInMap("RegionEname")]
        [Validation(Required=false)]
        public string RegionEname { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123847FA-9A00-4426-83B8-B4B45D475930</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
