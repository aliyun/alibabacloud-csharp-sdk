// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ExportCustomizeReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The download URL of the report.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxxxxxx.oss-cn-hangzhou-1.aliyuncs.com/xxxxx/xxxxxxxxxxxxxx?Expires=1671448125&OSSAccessKeyId=xxx">https://xxxxxxxx.oss-cn-hangzhou-1.aliyuncs.com/xxxxx/xxxxxxxxxxxxxx?Expires=1671448125&amp;OSSAccessKeyId=xxx</a></para>
        /// </summary>
        [NameInMap("DownloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The time when the report was generated. Format: YYYY-MM-DD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-10</para>
        /// </summary>
        [NameInMap("ExportDate")]
        [Validation(Required=false)]
        public string ExportDate { get; set; }

        /// <summary>
        /// <para>The ID of the export report task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("ExportId")]
        [Validation(Required=false)]
        public long? ExportId { get; set; }

        /// <summary>
        /// <para>The status of the export node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>fail</b>: The export failed.</description></item>
        /// <item><description><b>exporting</b>: The export is in progress.</description></item>
        /// <item><description><b>success</b>: The export succeeded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>exporting</para>
        /// </summary>
        [NameInMap("ExportStatus")]
        [Validation(Required=false)]
        public string ExportStatus { get; set; }

        /// <summary>
        /// <para>The name of the exported file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_xxxx.html</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The ID of the security report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

        /// <summary>
        /// <para>The request ID, which is a unique identifier that Alibaba Cloud generates for the request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFDFCEB3-A5EE-590A-8E70-283EBC5D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp when the report download URL expires. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1673335497000</para>
        /// </summary>
        [NameInMap("UrlExpiredTime")]
        [Validation(Required=false)]
        public long? UrlExpiredTime { get; set; }

    }

}
