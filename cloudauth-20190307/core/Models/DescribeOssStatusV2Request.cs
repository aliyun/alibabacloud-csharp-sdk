// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeOssStatusV2Request : TeaModel {
        /// <summary>
        /// <para>ServiceCode for Real Person Cloud products:</para>
        /// <list type="bullet">
        /// <item><description><b>antcloudauth</b>: Financial-grade real person authentication</description></item>
        /// <item><description><b>cloudauthst (discontinued)</b>: Enhanced real person authentication</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>antcloudauth</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>Visitor\&quot;s source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120.25.41.25</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
