// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DescAccountSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>Daily quota</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("DailyQuota")]
        [Validation(Required=false)]
        public int? DailyQuota { get; set; }

        /// <summary>
        /// <para>remaining amount of daily free quota</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DailyRemainFreeQuota")]
        [Validation(Required=false)]
        public int? DailyRemainFreeQuota { get; set; }

        /// <summary>
        /// <para>Dayu status (deprecated, retained for compatibility reasons.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DayuStatus")]
        [Validation(Required=false)]
        public int? DayuStatus { get; set; }

        /// <summary>
        /// <para>Number of domains</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public int? Domains { get; set; }

        /// <summary>
        /// <para>Effective time</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EnableTimes")]
        [Validation(Required=false)]
        public int? EnableTimes { get; set; }

        /// <summary>
        /// <para>Number of sending addresses</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MailAddresses")]
        [Validation(Required=false)]
        public int? MailAddresses { get; set; }

        /// <summary>
        /// <para>Maximum level</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxQuotaLevel")]
        [Validation(Required=false)]
        public int? MaxQuotaLevel { get; set; }

        /// <summary>
        /// <para>Monthly quota</para>
        /// 
        /// <b>Example:</b>
        /// <para>60000</para>
        /// </summary>
        [NameInMap("MonthQuota")]
        [Validation(Required=false)]
        public int? MonthQuota { get; set; }

        /// <summary>
        /// <para>Credit level</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("QuotaLevel")]
        [Validation(Required=false)]
        public int? QuotaLevel { get; set; }

        /// <summary>
        /// <para>Number of recipients</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Receivers")]
        [Validation(Required=false)]
        public int? Receivers { get; set; }

        /// <summary>
        /// <para>Remaining amount of total free quota</para>
        /// 
        /// <b>Example:</b>
        /// <para>1910</para>
        /// </summary>
        [NameInMap("RemainFreeQuota")]
        [Validation(Required=false)]
        public int? RemainFreeQuota { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>82B295BB-7E69-491F-9896-ECEAFF09E1A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Deprecated, retained for compatibility reasons.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SmsRecord")]
        [Validation(Required=false)]
        public int? SmsRecord { get; set; }

        /// <summary>
        /// <para>Deprecated, retained for compatibility reasons.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SmsSign")]
        [Validation(Required=false)]
        public int? SmsSign { get; set; }

        /// <summary>
        /// <para>Deprecated, retained for compatibility reasons.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SmsTemplates")]
        [Validation(Required=false)]
        public int? SmsTemplates { get; set; }

        /// <summary>
        /// <para>Number of tags</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public int? Tags { get; set; }

        /// <summary>
        /// <para>Number of templates</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public int? Templates { get; set; }

        /// <summary>
        /// <para>User status:
        /// 1 Frozen
        /// 2 In arrears
        /// 4 Restricted from sending
        /// 8 Logically deleted</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("UserStatus")]
        [Validation(Required=false)]
        public int? UserStatus { get; set; }

    }

}
