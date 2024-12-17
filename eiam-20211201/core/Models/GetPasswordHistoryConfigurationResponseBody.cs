// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetPasswordHistoryConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The password history configurations.</para>
        /// </summary>
        [NameInMap("PasswordHistoryConfiguration")]
        [Validation(Required=false)]
        public GetPasswordHistoryConfigurationResponseBodyPasswordHistoryConfiguration PasswordHistoryConfiguration { get; set; }
        public class GetPasswordHistoryConfigurationResponseBodyPasswordHistoryConfiguration : TeaModel {
            /// <summary>
            /// <para>The maximum number of recent passwords that are retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("PasswordHistoryMaxRetention")]
            [Validation(Required=false)]
            public int? PasswordHistoryMaxRetention { get; set; }

            /// <summary>
            /// <para>Indicates whether the password history feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled</description></item>
            /// <item><description>disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("PasswordHistoryStatus")]
            [Validation(Required=false)]
            public string PasswordHistoryStatus { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
