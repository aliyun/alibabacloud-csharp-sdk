// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyUserAlarmConfigRequest : TeaModel {
        /// <summary>
        /// <para>Alert configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AlarmConfig")]
        [Validation(Required=false)]
        public List<ModifyUserAlarmConfigRequestAlarmConfig> AlarmConfig { get; set; }
        public class ModifyUserAlarmConfigRequestAlarmConfig : TeaModel {
            /// <summary>
            /// <para>Hour for alert notifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AlarmHour")]
            [Validation(Required=false)]
            public string AlarmHour { get; set; }

            /// <summary>
            /// <para>Notification method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlarmNotify")]
            [Validation(Required=false)]
            public string AlarmNotify { get; set; }

            /// <summary>
            /// <para>Alert period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlarmPeriod")]
            [Validation(Required=false)]
            public string AlarmPeriod { get; set; }

            /// <summary>
            /// <para>Alarm metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bandwidth</para>
            /// </summary>
            [NameInMap("AlarmType")]
            [Validation(Required=false)]
            public string AlarmType { get; set; }

            /// <summary>
            /// <para>Alert notification message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("AlarmValue")]
            [Validation(Required=false)]
            public string AlarmValue { get; set; }

            /// <summary>
            /// <para>Day of the week for alert notifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AlarmWeekDay")]
            [Validation(Required=false)]
            public string AlarmWeekDay { get; set; }

        }

        /// <summary>
        /// <para>Language for message notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AlarmLang")]
        [Validation(Required=false)]
        public string AlarmLang { get; set; }

        /// <summary>
        /// <para>Contact configuration.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("ContactConfig")]
        [Validation(Required=false)]
        public List<ModifyUserAlarmConfigRequestContactConfig> ContactConfig { get; set; }
        public class ModifyUserAlarmConfigRequestContactConfig : TeaModel {
            /// <summary>
            /// <para>Mailbox.</para>
            /// 
            /// <b>Example:</b>
            /// <para>91632****@qq.com</para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Mobile number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1351234****</para>
            /// </summary>
            [NameInMap("MobilePhone")]
            [Validation(Required=false)]
            public string MobilePhone { get; set; }

            /// <summary>
            /// <para>Alert notification recipient.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Ben</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Alert status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>Language used for requests and responses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Source IP address of the requester.</para>
        /// 
        /// <b>Example:</b>
        /// <para>117.129.64.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>Use default contact method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UseDefaultContact")]
        [Validation(Required=false)]
        public int? UseDefaultContact { get; set; }

    }

}
