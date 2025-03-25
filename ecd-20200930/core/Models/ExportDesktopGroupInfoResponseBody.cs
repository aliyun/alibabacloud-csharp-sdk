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
        /// <para>The download URL of the XLSX file that contains cloud computer shares. The XLSX file provides the following information:</para>
        /// <list type="bullet">
        /// <item><description>Cloud computer share ID/name</description></item>
        /// <item><description>Office network ID/name</description></item>
        /// <item><description>Cloud computer share template</description></item>
        /// <item><description>vCPUs/Memory size</description></item>
        /// <item><description>System disk/Data disk</description></item>
        /// <item><description>Security policy name</description></item>
        /// <item><description>Number of authorized users</description></item>
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
