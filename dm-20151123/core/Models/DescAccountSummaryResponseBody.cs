// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DescAccountSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The daily quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("DailyQuota")]
        [Validation(Required=false)]
        public int? DailyQuota { get; set; }

        /// <summary>
        /// <para>The remaining daily free quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DailyRemainFreeQuota")]
        [Validation(Required=false)]
        public int? DailyRemainFreeQuota { get; set; }

        /// <summary>
        /// <para>The status of Dayu. This parameter is deprecated and retained for compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DayuStatus")]
        [Validation(Required=false)]
        public int? DayuStatus { get; set; }

        /// <summary>
        /// <para>The number of domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public int? Domains { get; set; }

        /// <summary>
        /// <para>The effective period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EnableTimes")]
        [Validation(Required=false)]
        public int? EnableTimes { get; set; }

        /// <summary>
        /// <para>The type of the outbound IP channel.</para>
        /// <ol>
        /// <item><description><para>backup: A backup IP channel that is not actively maintained. Customers using this channel are advised to purchase a dedicated IP for better stability.</para>
        /// </description></item>
        /// <item><description><para>normal: A normal IP channel that is continuously maintained by the email delivery team to ensure stable and reliable service.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("IpChannelType")]
        [Validation(Required=false)]
        public string IpChannelType { get; set; }

        /// <summary>
        /// <para>The number of sender addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MailAddresses")]
        [Validation(Required=false)]
        public int? MailAddresses { get; set; }

        /// <summary>
        /// <para>The maximum reputation level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxQuotaLevel")]
        [Validation(Required=false)]
        public int? MaxQuotaLevel { get; set; }

        /// <summary>
        /// <para>The monthly quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60000</para>
        /// </summary>
        [NameInMap("MonthQuota")]
        [Validation(Required=false)]
        public int? MonthQuota { get; set; }

        /// <summary>
        /// <para>The reputation level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("QuotaLevel")]
        [Validation(Required=false)]
        public int? QuotaLevel { get; set; }

        /// <summary>
        /// <para>The number of recipients.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Receivers")]
        [Validation(Required=false)]
        public int? Receivers { get; set; }

        /// <summary>
        /// <para>The remaining free quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1910</para>
        /// </summary>
        [NameInMap("RemainFreeQuota")]
        [Validation(Required=false)]
        public int? RemainFreeQuota { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82B295BB-7E69-491F-9896-ECEAFF09E1A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. It is retained for compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SmsRecord")]
        [Validation(Required=false)]
        public int? SmsRecord { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. It is retained for compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SmsSign")]
        [Validation(Required=false)]
        public int? SmsSign { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated. It is retained for compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SmsTemplates")]
        [Validation(Required=false)]
        public int? SmsTemplates { get; set; }

        /// <summary>
        /// <para>The number of tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public int? Tags { get; set; }

        /// <summary>
        /// <para>The number of templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public int? Templates { get; set; }

        /// <summary>
        /// <para>The status of the user. Valid values: 0: Normal. 1: Freeze. 2: Overdue payment. 4: Outbound messages are restricted. 8: The user is logically deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public int? UserStatus { get; set; }

    }

}
