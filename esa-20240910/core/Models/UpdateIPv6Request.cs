// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateIPv6Request : TeaModel {
        /// <summary>
        /// <para>Whether to enable IPv6. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enables IPv6.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disables IPv6.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <para>The region in which to enable IPv6. The default value is x.x.</para>
        /// <list type="bullet">
        /// <item><description><para>x.x: global</para>
        /// </description></item>
        /// <item><description><para>cn.cn: Chinese mainland</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>x.x</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The site ID. You can get this ID by calling <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5407498413****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
