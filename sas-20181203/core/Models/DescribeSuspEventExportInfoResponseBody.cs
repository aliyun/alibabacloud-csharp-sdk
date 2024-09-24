// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventExportInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The handling status for the exception. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>exporting</b>: in progress</description></item>
        /// <item><description><b>success</b>: successful</description></item>
        /// <item><description><b>failed</b>: failed</description></item>
        /// <item><description><b>pending</b>: pending</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ExportStatus")]
        [Validation(Required=false)]
        public string ExportStatus { get; set; }

        /// <summary>
        /// <para>The name of the exported file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>suspicious_event_20221221_1671590521234.zip</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The time when the export task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-20T15:18Z</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <para>The time when the export task was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-20T15:18Z</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// <para>The ID of the export task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public int? Id { get; set; }

        /// <summary>
        /// <para>The URL at which you can download the exported Excel file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://suspicious-xxxxxxx.oss-cn-shanghai.aliyuncs.com/xxxxxxxxxxx/suspicious_event_20221221_1671590525269.zip?Expires=1671594125&OSSAccessKeyId=LTAIxxxxxxxxxxxxxx&Signature=xxxxxxxxxxxxxxxxxx">http://suspicious-xxxxxxx.oss-cn-shanghai.aliyuncs.com/xxxxxxxxxxx/suspicious_event_20221221_1671590525269.zip?Expires=1671594125&amp;OSSAccessKeyId=LTAIxxxxxxxxxxxxxx&amp;Signature=xxxxxxxxxxxxxxxxxx</a></para>
        /// </summary>
        [NameInMap("Link")]
        [Validation(Required=false)]
        public string Link { get; set; }

        /// <summary>
        /// <para>The progress percentage of the export task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// <para>The exported parameters of exceptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id,eventSubType,eventDetail,level,status,ip,instanceName,desc,lastTime,operateTime,note</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public string Properties { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE120DAB-F4E7-4C53-ADC3-A97578AXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of exceptions exported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The type of the export task. The value is fixed as suspiciousEvent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>suspiciousEvent</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
