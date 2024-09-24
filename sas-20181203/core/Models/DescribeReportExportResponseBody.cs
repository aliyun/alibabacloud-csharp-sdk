// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeReportExportResponseBody : TeaModel {
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
        /// <para>The time when the report was exported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-15</para>
        /// </summary>
        [NameInMap("ExportDate")]
        [Validation(Required=false)]
        public string ExportDate { get; set; }

        /// <summary>
        /// <para>The ID of the export task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ExportId")]
        [Validation(Required=false)]
        public long? ExportId { get; set; }

        /// <summary>
        /// <para>The status of the export task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: The export task fails.</description></item>
        /// <item><description><b>0</b>: The export task is being initialized.</description></item>
        /// <item><description><b>1</b>: The export task is being executed.</description></item>
        /// <item><description><b>2</b>: The export task is successful.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ExportStatus")]
        [Validation(Required=false)]
        public string ExportStatus { get; set; }

        /// <summary>
        /// <para>The ID of the report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>377665</para>
        /// </summary>
        [NameInMap("ReportId")]
        [Validation(Required=false)]
        public long? ReportId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79CFF74D-E967-5407-8A78-EE03B925FDAA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The timestamp when the download URL expires. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1660113647000</para>
        /// </summary>
        [NameInMap("UrlExpiredTime")]
        [Validation(Required=false)]
        public long? UrlExpiredTime { get; set; }

    }

}
