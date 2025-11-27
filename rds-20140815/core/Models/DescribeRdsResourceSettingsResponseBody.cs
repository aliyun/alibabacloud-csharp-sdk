// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRdsResourceSettingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about notification settings for an instance.</para>
        /// </summary>
        [NameInMap("RdsInstanceResourceSettings")]
        [Validation(Required=false)]
        public DescribeRdsResourceSettingsResponseBodyRdsInstanceResourceSettings RdsInstanceResourceSettings { get; set; }
        public class DescribeRdsResourceSettingsResponseBodyRdsInstanceResourceSettings : TeaModel {
            [NameInMap("RdsInstanceResourceSetting")]
            [Validation(Required=false)]
            public List<DescribeRdsResourceSettingsResponseBodyRdsInstanceResourceSettingsRdsInstanceResourceSetting> RdsInstanceResourceSetting { get; set; }
            public class DescribeRdsResourceSettingsResponseBodyRdsInstanceResourceSettingsRdsInstanceResourceSetting : TeaModel {
                /// <summary>
                /// <para>The end date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-04-25</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <para>Specifies whether to pin the notification at the top.</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsTop")]
                [Validation(Required=false)]
                public string IsTop { get; set; }

                /// <summary>
                /// <para>The notification text.</para>
                /// </summary>
                [NameInMap("NoticeBarContent")]
                [Validation(Required=false)]
                public string NoticeBarContent { get; set; }

                /// <summary>
                /// <para>The text of the popup button.</para>
                /// </summary>
                [NameInMap("PoppedUpButtonText")]
                [Validation(Required=false)]
                public string PoppedUpButtonText { get; set; }

                /// <summary>
                /// <para>The type of the popup button.</para>
                /// <list type="bullet">
                /// <item><description>BUY</description></item>
                /// <item><description>RENEW</description></item>
                /// <item><description>UPGRADE</description></item>
                /// </list>
                /// </summary>
                [NameInMap("PoppedUpButtonType")]
                [Validation(Required=false)]
                public string PoppedUpButtonType { get; set; }

                /// <summary>
                /// <para>The link of the popup button.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.example.com/subscribe">https://www.example.com/subscribe</a></para>
                /// </summary>
                [NameInMap("PoppedUpButtonUrl")]
                [Validation(Required=false)]
                public string PoppedUpButtonUrl { get; set; }

                /// <summary>
                /// <para>The text of the popup.</para>
                /// </summary>
                [NameInMap("PoppedUpContent")]
                [Validation(Required=false)]
                public string PoppedUpContent { get; set; }

                /// <summary>
                /// <para>The location of the notification.</para>
                /// </summary>
                [NameInMap("ResourceNiche")]
                [Validation(Required=false)]
                public string ResourceNiche { get; set; }

                /// <summary>
                /// <para>The effective date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-04-21</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>76364A52-E0AB-5CC8-xxxx-CF1DC482C092</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
