// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the specified IP address is assigned to an Alibaba Cloud DCDN POP.</para>
        /// <list type="bullet">
        /// <item><description>True</description></item>
        /// <item><description>False</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("DcdnIp")]
        [Validation(Required=false)]
        public string DcdnIp { get; set; }

        /// <summary>
        /// <para>The ISP to which the specified IP address belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>China Telecom</para>
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// <para>The name of the Internet service provider (ISP).</para>
        /// 
        /// <b>Example:</b>
        /// <para>telecom</para>
        /// </summary>
        [NameInMap("IspEname")]
        [Validation(Required=false)]
        public string IspEname { get; set; }

        /// <summary>
        /// <para>The Chinese name of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// <para> The maximum number of times that users can call this operation per second is 50.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The English name of the region.</para>
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
        /// <para>1B1D0EE7-9559-489D-BC4E-279495EB8FB8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
