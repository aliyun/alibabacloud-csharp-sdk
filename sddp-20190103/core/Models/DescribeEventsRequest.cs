// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeEventsRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the account that handles the anomalous event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yundun-***</para>
        /// </summary>
        [NameInMap("DealUserId")]
        [Validation(Required=false)]
        public string DealUserId { get; set; }

        /// <summary>
        /// <para>The end of the time range during which the anomalous events are detected. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698700000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The unique ID of the anomalous event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>789026</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the data asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6yzvbc2tg90iuxk.l****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese</description></item>
        /// <item><description><b>en_us</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the service to which the table belongs. Valid values include <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which the anomalous events are detected. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1657900000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The handling status of the anomalous event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: unhandled</description></item>
        /// <item><description>1: confirmed</description></item>
        /// <item><description>2: marked as false positive</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The name of the anomalous event subtype.</para>
        /// <remarks>
        /// <para>You can call the <b>DescribeEventTypes</b> operation to query the name of the anomalous event subtype.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Anomalous volume of downloaded data</para>
        /// </summary>
        [NameInMap("SubTypeCode")]
        [Validation(Required=false)]
        public string SubTypeCode { get; set; }

        /// <summary>
        /// <para>The name of the destination service in an anomalous data flow. Valid values include <b>MaxCompute, OSS, ADS, OTS, and RDS</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("TargetProductCode")]
        [Validation(Required=false)]
        public string TargetProductCode { get; set; }

        /// <summary>
        /// <para>The name of the anomalous event type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>01: anomalous permission usage</description></item>
        /// <item><description>02: anomalous data flow</description></item>
        /// <item><description>03: anomalous data operation</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>02</para>
        /// </summary>
        [NameInMap("TypeCode")]
        [Validation(Required=false)]
        public string TypeCode { get; set; }

        /// <summary>
        /// <para>The ID of the account that triggered the anomalous event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1978132506596***</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

        /// <summary>
        /// <para>The username of the RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The risk level of the alert that is triggered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: low</description></item>
        /// <item><description><b>2</b>: medium</description></item>
        /// <item><description><b>3</b>: high</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WarnLevel")]
        [Validation(Required=false)]
        public int? WarnLevel { get; set; }

    }

}
