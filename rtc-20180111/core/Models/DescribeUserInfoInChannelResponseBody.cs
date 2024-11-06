// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeUserInfoInChannelResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsChannelExist")]
        [Validation(Required=false)]
        public bool? IsChannelExist { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsInChannel")]
        [Validation(Required=false)]
        public bool? IsInChannel { get; set; }

        [NameInMap("Property")]
        [Validation(Required=false)]
        public List<DescribeUserInfoInChannelResponseBodyProperty> Property { get; set; }
        public class DescribeUserInfoInChannelResponseBodyProperty : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1557909133</para>
            /// </summary>
            [NameInMap("Join")]
            [Validation(Required=false)]
            public int? Join { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public int? Role { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xa744sxx8rtobgj****</para>
            /// </summary>
            [NameInMap("Session")]
            [Validation(Required=false)]
            public string Session { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6159ba01-6687-4fb2-a831-f0cd8d188648</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1557909133</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public int? Timestamp { get; set; }

    }

}
