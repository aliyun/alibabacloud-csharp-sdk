// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportWarningResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the file that contains exported baseline check results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>health_check_export_20220407</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The ID of the task to export baseline check results.</para>
        /// <remarks>
        /// <para>You can call use the value of this parameter to call the <a href="~~DescribeHcExportInfo~~">DescribeHcExportInfo</a> operation to query the export progress.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>439316</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7FC828B-C242-1005-9736-C7CC5DC09FF0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
