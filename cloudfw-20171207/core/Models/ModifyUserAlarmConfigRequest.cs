// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyUserAlarmConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AlarmConfig")]
        [Validation(Required=false)]
        public List<ModifyUserAlarmConfigRequestAlarmConfig> AlarmConfig { get; set; }
        public class ModifyUserAlarmConfigRequestAlarmConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AlarmHour")]
            [Validation(Required=false)]
            public string AlarmHour { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlarmNotify")]
            [Validation(Required=false)]
            public string AlarmNotify { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlarmPeriod")]
            [Validation(Required=false)]
            public string AlarmPeriod { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bandwidth</para>
            /// </summary>
            [NameInMap("AlarmType")]
            [Validation(Required=false)]
            public string AlarmType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("AlarmValue")]
            [Validation(Required=false)]
            public string AlarmValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AlarmWeekDay")]
            [Validation(Required=false)]
            public string AlarmWeekDay { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AlarmLang")]
        [Validation(Required=false)]
        public string AlarmLang { get; set; }

        [NameInMap("ContactConfig")]
        [Validation(Required=false)]
        public List<ModifyUserAlarmConfigRequestContactConfig> ContactConfig { get; set; }
        public class ModifyUserAlarmConfigRequestContactConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>91632****@qq.com</para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1351234****</para>
            /// </summary>
            [NameInMap("MobilePhone")]
            [Validation(Required=false)]
            public string MobilePhone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Ben</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("NotifyConfig")]
        [Validation(Required=false)]
        public List<ModifyUserAlarmConfigRequestNotifyConfig> NotifyConfig { get; set; }
        public class ModifyUserAlarmConfigRequestNotifyConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>mail</para>
            /// </summary>
            [NameInMap("NotifyType")]
            [Validation(Required=false)]
            public string NotifyType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1351234****</para>
            /// </summary>
            [NameInMap("NotifyValue")]
            [Validation(Required=false)]
            public string NotifyValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>117.129.64.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UseDefaultContact")]
        [Validation(Required=false)]
        public int? UseDefaultContact { get; set; }

    }

}
