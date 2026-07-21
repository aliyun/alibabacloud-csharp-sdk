// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ExportDesktopGroupInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24E05D3E-08F4-551E-B1F0-F6D84EE0BCCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The download URL of the exported shared cloud desktop list file. The exported file contains the following details of shared cloud desktops:</para>
        /// <list type="bullet">
        /// <item><description>Shared cloud desktop ID/name</description></item>
        /// <item><description>Office network ID/name</description></item>
        /// <item><description>Shared cloud desktop template</description></item>
        /// <item><description>CPU/memory</description></item>
        /// <item><description>System cloud disk/data cloud disk</description></item>
        /// <item><description>Security policy name</description></item>
        /// <item><description>Number of currently authorized users</description></item>
        /// <item><description>Billing method</description></item>
        /// <item><description>Creation time</description></item>
        /// <item><description>Expiration time</description></item>
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
