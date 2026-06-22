// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeHcExportInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of data entries that have been exported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>148</para>
        /// </summary>
        [NameInMap("CurrentCount")]
        [Validation(Required=false)]
        public int? CurrentCount { get; set; }

        /// <summary>
        /// <para>The name of the exported file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>health_check_export_2022****</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The time when the task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-03T15:15Z</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <para>The ID of the export task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1082278</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The download link of the exported file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://hc-export.oss-cn-shanghai.aliyuncs.com/export_hc/health_check_export_20221222_1671699255808.zip?Expires=1672304056&OSSAccessKeyId=****&Signature=">https://hc-export.oss-cn-shanghai.aliyuncs.com/export_hc/health_check_export_20221222_1671699255808.zip?Expires=1672304056&amp;OSSAccessKeyId=****&amp;Signature=</a>****</para>
        /// </summary>
        [NameInMap("Link")]
        [Validation(Required=false)]
        public string Link { get; set; }

        /// <summary>
        /// <para>The export progress in percentage (%).</para>
        /// 
        /// <b>Example:</b>
        /// <para>89</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C2C94CF-ED08-50C0-BC72-C5029251****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the export task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>exporting</b>: The export is in progress.</para>
        /// </description></item>
        /// <item><description><para><b>success</b>: The export is successful.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>exporting</para>
        /// </summary>
        [NameInMap("ResultStatus")]
        [Validation(Required=false)]
        public string ResultStatus { get; set; }

        /// <summary>
        /// <para>The total number of data entries to be exported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>624</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
