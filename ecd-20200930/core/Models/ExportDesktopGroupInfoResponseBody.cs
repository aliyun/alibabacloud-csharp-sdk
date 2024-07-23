// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ExportDesktopGroupInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24E05D3E-08F4-551E-B1F0-F6D84EE0BCCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The URL from which you can download the exported cloud computer pools. The details of the cloud computer pools include:</para>
        /// <list type="bullet">
        /// <item><description>IDs and names of the cloud computer pools</description></item>
        /// <item><description>IDs and names of the office networks</description></item>
        /// <item><description>Cloud computer pool templates</description></item>
        /// <item><description>Number of CPU cores and memory size</description></item>
        /// <item><description>System disks and data disks</description></item>
        /// <item><description>Names of security policies</description></item>
        /// <item><description>Number of current authorized users</description></item>
        /// <item><description>Billing methods</description></item>
        /// <item><description>The time when the cloud computer pools were created</description></item>
        /// <item><description>The time when the cloud computer pools expire</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cn-hangzhou-servicemanager.oss-cn-hangzhou.aliyuncs.com/A0_DESKTOP/EDS_CloudDesktopGroups_202203********_xBjqdCT***.xlsx">https://cn-hangzhou-servicemanager.oss-cn-hangzhou.aliyuncs.com/A0_DESKTOP/EDS_CloudDesktopGroups_202203********_xBjqdCT***.xlsx</a>?*********</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
