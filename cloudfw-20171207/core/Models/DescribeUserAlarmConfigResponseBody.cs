// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserAlarmConfigResponseBody : TeaModel {
        [NameInMap("AlarmConfig")]
        [Validation(Required=false)]
        public List<DescribeUserAlarmConfigResponseBodyAlarmConfig> AlarmConfig { get; set; }
        public class DescribeUserAlarmConfigResponseBodyAlarmConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlarmHour")]
            [Validation(Required=false)]
            public int? AlarmHour { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AlarmNotify")]
            [Validation(Required=false)]
            public int? AlarmNotify { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("AlarmPeriod")]
            [Validation(Required=false)]
            public int? AlarmPeriod { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bandwidth</para>
            /// </summary>
            [NameInMap("AlarmType")]
            [Validation(Required=false)]
            public string AlarmType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("AlarmValue")]
            [Validation(Required=false)]
            public string AlarmValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlarmWeekDay")]
            [Validation(Required=false)]
            public int? AlarmWeekDay { get; set; }

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
        public List<DescribeUserAlarmConfigResponseBodyContactConfig> ContactConfig { get; set; }
        public class DescribeUserAlarmConfigResponseBodyContactConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1530811****@qq.com</para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("MobilePhone")]
            [Validation(Required=false)]
            public string MobilePhone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1531123****</para>
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
            public int? Status { get; set; }

        }

        [NameInMap("DefaultContact")]
        [Validation(Required=false)]
        public DescribeUserAlarmConfigResponseBodyDefaultContact DefaultContact { get; set; }
        public class DescribeUserAlarmConfigResponseBodyDefaultContact : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1530811****@qq.com</para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1531123****</para>
            /// </summary>
            [NameInMap("MobilePhone")]
            [Validation(Required=false)]
            public string MobilePhone { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("NotifyConfig")]
        [Validation(Required=false)]
        public List<DescribeUserAlarmConfigResponseBodyNotifyConfig> NotifyConfig { get; set; }
        public class DescribeUserAlarmConfigResponseBodyNotifyConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>mail</para>
            /// </summary>
            [NameInMap("NotifyType")]
            [Validation(Required=false)]
            public string NotifyType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NotifyValue")]
            [Validation(Required=false)]
            public string NotifyValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9D250177-4F11-58B8-9AFE-A4624FF1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
