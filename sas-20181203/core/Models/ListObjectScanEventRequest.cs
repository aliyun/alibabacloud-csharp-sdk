// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListObjectScanEventRequest : TeaModel {
        /// <summary>
        /// <para>The batch operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>sha256</b>: same file content</para>
        /// </description></item>
        /// <item><description><para><b>eventName</b>: same alerting type.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sha256</para>
        /// </summary>
        [NameInMap("BatchType")]
        [Validation(Required=false)]
        public string BatchType { get; set; }

        /// <summary>
        /// <para>The bucket name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ltrbuck****</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The page number of the current page when you perform a paged query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8925****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// <para>The alert name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WebShell</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The MD5 hash of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0552c44e243abdea1729d4507bce****</para>
        /// </summary>
        [NameInMap("Md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// <para>The storage key of the file in the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1/2022/06/23/15/41/16559701077444693a0c6-33b2-4cc2-a99f-9f38b8b8****</para>
        /// </summary>
        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page when you perform a paged query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>If the file is a sub-file within a compressed archive, <b>ParentEventId</b> specifies the event ID of the alert for the compressed archive itself.</para>
        /// <para>To retrieve and query alert events for sub-files within a compressed archive:</para>
        /// <ol>
        /// <item><description>Call this operation and check the <b>HasSubEvent</b> response parameter. If the value is <b>true</b>, the corresponding <b>EventId</b> is the event ID of the alert for the compressed archive itself.</description></item>
        /// <item><description>Call this operation again and pass the <b>EventId</b> value to <b>ParentEventId</b> to view the alert events for the sub-files within the compressed archive.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ParentEventId")]
        [Validation(Required=false)]
        public long? ParentEventId { get; set; }

        /// <summary>
        /// <para>The risk level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>high</b>: high risk</para>
        /// </description></item>
        /// <item><description><para><b>medium</b>: medium risk</para>
        /// </description></item>
        /// <item><description><para><b>low</b>: low risk.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>low</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>The data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>API</b>: API detection</description></item>
        /// <item><description><b>OSS</b>: OSS detection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The event status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: unhandled </description></item>
        /// <item><description>1: manually handled</description></item>
        /// <item><description>2: whitelisted</description></item>
        /// <item><description>3: ignored</description></item>
        /// <item><description>4: access denied.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The end time of the time range during which the exception event occurred.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683862286000</para>
        /// </summary>
        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public long? TimeEnd { get; set; }

        /// <summary>
        /// <para>The start time of the time range during which the exception event occurred.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683603086000</para>
        /// </summary>
        [NameInMap("TimeStart")]
        [Validation(Required=false)]
        public long? TimeStart { get; set; }

    }

}
