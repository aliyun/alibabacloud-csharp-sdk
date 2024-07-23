// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDemandRequest : TeaModel {
        /// <summary>
        /// <para>The number of instances. Valid values: 1 to 100000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the demand. The description must be 2 to 256 characters in length. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDemandDescription</para>
        /// </summary>
        [NameInMap("DemandDescription")]
        [Validation(Required=false)]
        public string DemandDescription { get; set; }

        /// <summary>
        /// <para>The ID of the demand that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ed-bp11n21kq00sl71p****</para>
        /// </summary>
        [NameInMap("DemandId")]
        [Validation(Required=false)]
        public string DemandId { get; set; }

        /// <summary>
        /// <para>The name of the demand. The name must be 2 to 128 characters in length. The name must start with a letter but cannot start with <a href="http://https://">http:// or https://</a>. It can contain letters, digits, colons (:), underscores (_), periods (.), and hyphens (-).</para>
        /// <para>The default value is the instance type name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDemandName</para>
        /// </summary>
        [NameInMap("DemandName")]
        [Validation(Required=false)]
        public string DemandName { get; set; }

        /// <summary>
        /// <para>The end time of the subscription period. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>standard in the yyyy-MM-dd HH:mm:ss format. The time must be in UTC.</para>
        /// <para>If the value of seconds (ss) is not 00, the time is automatically set to the beginning of the minute (mm).</para>
        /// <para>The value of EndTime must be later than the value of StartTime.</para>
        /// <para>in most cases, the interval between StartTime and EndTime cannot be more than 10 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-10 12:05:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription</description></item>
        /// <item><description>PostPaid (default): pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>. You can also call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to query the performance data of the specified instance type. To learn how to select instance types, see <a href="https://help.aliyun.com/document_detail/58291.html">Select instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The subscription period of the resource. Unit: month. You must specify this parameter. This parameter is valid only if you set <c>InstanceChargeType</c> to PrePaid. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Valid values when PeriodUnit is set to Week: 1, 2, 3, and 4.</description></item>
        /// <item><description>Valid values when PeriodUnit is set to Month: 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription period of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Day</description></item>
        /// <item><description>Week</description></item>
        /// <item><description>Month. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start time of the subscription period. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-dd HH:mm:ss format. The time must be in UTC.</para>
        /// <para>If the value of seconds (ss) is not 00, the time is automatically set to the beginning of the minute (mm).</para>
        /// <para>The value of EndTime must be later than the value of StartTime.</para>
        /// <para>In most cases, the interval between StartTime and EndTime cannot be more than 10 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-01 12:05:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a> operation to query the most recent zone list.</para>
        /// <para>This parameter is empty by default. If you leave this parameter empty, the system randomly selects a zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
