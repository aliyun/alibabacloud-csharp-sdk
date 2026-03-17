// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class GetSmartAGDpiAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the DPI-based monitoring feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Active</b>: enabled</description></item>
        /// <item><description><b>Inactive</b>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Inactive</para>
        /// </summary>
        [NameInMap("DpiMonitorStatus")]
        [Validation(Required=false)]
        public string DpiMonitorStatus { get; set; }

        /// <summary>
        /// <para>The status of the DPI feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>On</b>: enabled</description></item>
        /// <item><description><b>Off</b>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>On</para>
        /// </summary>
        [NameInMap("DpiStatus")]
        [Validation(Required=false)]
        public string DpiStatus { get; set; }

        /// <summary>
        /// <para>The name of the Log Service Logstore that is associated with the DPI feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("LogstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        /// <summary>
        /// <para>The name of the Log Service project that is associated with the DPI feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test2</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B2997DC4-F1A2-418B-81FC-C8892CD31CFF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The region where Log Service is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("SlsRegion")]
        [Validation(Required=false)]
        public string SlsRegion { get; set; }

    }

}
