// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveIpInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The Chinese name of the ISP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>电信</para>
        /// </summary>
        [NameInMap("ISP")]
        [Validation(Required=false)]
        public string ISP { get; set; }

        /// <summary>
        /// <para>The English name of the Internet service provider (ISP).</para>
        /// 
        /// <b>Example:</b>
        /// <para>telecom</para>
        /// </summary>
        [NameInMap("IspEname")]
        [Validation(Required=false)]
        public string IspEname { get; set; }

        /// <summary>
        /// <para>The Chinese name of the IP region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>中国-贵州省-贵阳市</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The English name of the IP region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>China-Guizhou-guiyang</para>
        /// </summary>
        [NameInMap("RegionEname")]
        [Validation(Required=false)]
        public string RegionEname { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1B1D0EE7-9559-489D-BC4E-279495EB8FB8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
