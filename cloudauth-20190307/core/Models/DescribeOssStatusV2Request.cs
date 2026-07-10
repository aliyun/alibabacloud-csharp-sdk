// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeOssStatusV2Request : TeaModel {
        /// <summary>
        /// <para>The ServiceCode of the ID Verification product. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>antcloudauth</b>: financial-grade ID Verification.</description></item>
        /// <item><description><b>cloudauthst (discontinued)</b>: enhanced ID Verification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>antcloudauth</para>
        /// </summary>
        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// <para>The source IP address of the visitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120.25.41.25</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
