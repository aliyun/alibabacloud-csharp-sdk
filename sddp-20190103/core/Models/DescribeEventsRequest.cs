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
        /// <para>The ID of the account that handled the anomalous activity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yundun-***</para>
        /// </summary>
        [NameInMap("DealUserId")]
        [Validation(Required=false)]
        public string DealUserId { get; set; }

        /// <summary>
        /// <para>The time when the detection of the anomalous activity ended. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698700000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The unique ID of the anomalous activity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>789026</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the data asset instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6yzvbc2tg90iuxk.l****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The language of the request and response. The default value is <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: English.</para>
        /// </description></item>
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
        /// <para>The service to which the data asset belongs. Valid values include MaxCompute, OSS, ADS, OTS, and <b>RDS</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The time when the anomalous activity occurred. This is the start time of the detection. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1657900000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The processing status of the anomalous activity.</para>
        /// <list type="bullet">
        /// <item><description><para>0: Unhandled.</para>
        /// </description></item>
        /// <item><description><para>1: Confirmed.</para>
        /// </description></item>
        /// <item><description><para>2: Dismissed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The name of the child type of the anomalous activity.</para>
        /// <remarks>
        /// <para>To query anomalous activities by the child type name, call the <b>DescribeEventTypes</b> operation to get the name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Abnormal data download volume</para>
        /// </summary>
        [NameInMap("SubTypeCode")]
        [Validation(Required=false)]
        public string SubTypeCode { get; set; }

        /// <summary>
        /// <para>The destination service for an anomalous data flow event. Valid values include MaxCompute, OSS, ADS, OTS, and <b>RDS</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("TargetProductCode")]
        [Validation(Required=false)]
        public string TargetProductCode { get; set; }

        /// <summary>
        /// <para>The code of the parent type of the anomalous activity.</para>
        /// <list type="bullet">
        /// <item><description><para>01: Anomalous permission access.</para>
        /// </description></item>
        /// <item><description><para>02: Anomalous data flow.</para>
        /// </description></item>
        /// <item><description><para>03: Anomalous data operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>02</para>
        /// </summary>
        [NameInMap("TypeCode")]
        [Validation(Required=false)]
        public string TypeCode { get; set; }

        /// <summary>
        /// <para>The ID of the account that performed the operation that triggered the anomalous activity.</para>
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
        /// <para>The risk level of the anomalous activity.</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Low.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Medium.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: High.</para>
        /// </description></item>
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
