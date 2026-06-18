// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetIPv6ResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies whether IPv6 is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <para>The region where IPv6 is enabled. The default value is <c>x.x</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>x.x</c>: Global.</para>
        /// </description></item>
        /// <item><description><para><c>cn.cn</c>: Chinese mainland.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156A6B-677B1A-4297B7-9187B7-2B44792</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
