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
        /// <item><description><para>Cloud computer share ID/name</para>
        /// </description></item>
        /// <item><description><para>Office network ID/name</para>
        /// </description></item>
        /// <item><description><para>Cloud computer share template</para>
        /// </description></item>
        /// <item><description><para>vCPUs/Memory size</para>
        /// </description></item>
        /// <item><description><para>System disk/Data disk</para>
        /// </description></item>
        /// <item><description><para>Security policy name</para>
        /// </description></item>
        /// <item><description><para>Number of authorized users</para>
        /// </description></item>
        /// <item><description><para>Billing method</para>
        /// </description></item>
        /// <item><description><para>Creation time</para>
        /// </description></item>
        /// <item><description><para>Expiration time</para>
        /// </description></item>
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
