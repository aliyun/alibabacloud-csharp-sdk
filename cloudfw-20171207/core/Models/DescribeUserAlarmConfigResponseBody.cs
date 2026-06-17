// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserAlarmConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The alarm configuration.</para>
        /// </summary>
        [NameInMap("AlarmConfig")]
        [Validation(Required=false)]
        public List<DescribeUserAlarmConfigResponseBodyAlarmConfig> AlarmConfig { get; set; }
        public class DescribeUserAlarmConfigResponseBodyAlarmConfig : TeaModel {
            /// <summary>
            /// <para>The alarm threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlarmHour")]
            [Validation(Required=false)]
            public int? AlarmHour { get; set; }

            /// <summary>
            /// <para>The notification method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AlarmNotify")]
            [Validation(Required=false)]
            public int? AlarmNotify { get; set; }

            /// <summary>
            /// <para>The alarm period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("AlarmPeriod")]
            [Validation(Required=false)]
            public int? AlarmPeriod { get; set; }

            /// <summary>
            /// <para>The alarm type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bandwidth</para>
            /// </summary>
            [NameInMap("AlarmType")]
            [Validation(Required=false)]
            public string AlarmType { get; set; }

            /// <summary>
            /// <para>The value that triggers the alarm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("AlarmValue")]
            [Validation(Required=false)]
            public string AlarmValue { get; set; }

            /// <summary>
            /// <para>The alarm retry count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlarmWeekDay")]
            [Validation(Required=false)]
            public int? AlarmWeekDay { get; set; }

        }

        /// <summary>
        /// <para>The language of the alarm notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AlarmLang")]
        [Validation(Required=false)]
        public string AlarmLang { get; set; }

        /// <summary>
        /// <para>The contact information.</para>
        /// </summary>
        [NameInMap("ContactConfig")]
        [Validation(Required=false)]
        public List<DescribeUserAlarmConfigResponseBodyContactConfig> ContactConfig { get; set; }
        public class DescribeUserAlarmConfigResponseBodyContactConfig : TeaModel {
            /// <summary>
            /// <para>The email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1530811****@qq.com</para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The mobile number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("MobilePhone")]
            [Validation(Required=false)]
            public string MobilePhone { get; set; }

            /// <summary>
            /// <para>The contact name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1531123****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the contact. Valid values: <b>0</b> (Disabled) and <b>1</b> (Enabled).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>Information about the default alarm contact.</para>
        /// </summary>
        [NameInMap("DefaultContact")]
        [Validation(Required=false)]
        public DescribeUserAlarmConfigResponseBodyDefaultContact DefaultContact { get; set; }
        public class DescribeUserAlarmConfigResponseBodyDefaultContact : TeaModel {
            /// <summary>
            /// <para>The email address of the default contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1530811****@qq.com</para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The mobile number of the default contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1531123****</para>
            /// </summary>
            [NameInMap("MobilePhone")]
            [Validation(Required=false)]
            public string MobilePhone { get; set; }

            /// <summary>
            /// <para>The name of the default contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status. Valid values: <b>normal</b> (Normal) and <b>disable</b> (Disabled).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9D250177-4F11-58B8-9AFE-A4624FF1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
