// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListObjectScanEventRequest : TeaModel {
        /// <summary>
        /// <para>Batch operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sha256</b>: Same file content</description></item>
        /// <item><description><b>eventName</b>: Same alert type</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sha256</para>
        /// </summary>
        [NameInMap("BatchType")]
        [Validation(Required=false)]
        public string BatchType { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ltrbuck****</para>
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8925****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// <para>The name of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WebShell</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The MD5 hash value of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0552c44e243abdea1729d4507bce****</para>
        /// </summary>
        [NameInMap("Md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// <para>The key of the file that is stored in an OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1/2022/06/23/15/41/16559701077444693a0c6-33b2-4cc2-a99f-9f38b8b8****</para>
        /// </summary>
        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the alert that is generated for the package to which the subfile belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ParentEventId")]
        [Validation(Required=false)]
        public long? ParentEventId { get; set; }

        /// <summary>
        /// <para>The risk level of the alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>high</b></description></item>
        /// <item><description><b>medium</b></description></item>
        /// <item><description><b>low</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>low</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>The method that is used to detect the malicious file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>API</b>: uses API operations.</description></item>
        /// <item><description><b>OSS</b>: uses Object Storage Service (OSS) file check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>Event status. The values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Unprocessed </description></item>
        /// <item><description><b>1</b>: I have processed manually </description></item>
        /// <item><description><b>2</b>: Whitelisted </description></item>
        /// <item><description><b>3</b>: Ignored </description></item>
        /// <item><description><b>4</b>: Access denied</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The end of the time range during which the exception is detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683862286000</para>
        /// </summary>
        [NameInMap("TimeEnd")]
        [Validation(Required=false)]
        public long? TimeEnd { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which the exception is detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683603086000</para>
        /// </summary>
        [NameInMap("TimeStart")]
        [Validation(Required=false)]
        public long? TimeStart { get; set; }

    }

}
