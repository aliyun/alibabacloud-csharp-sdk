// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs_workbench20251111.Models
{
    public class DescribeTerminalSettingsResponseBody : TeaModel {
        [NameInMap("PasswordlessLoginConfig")]
        [Validation(Required=false)]
        public DescribeTerminalSettingsResponseBodyPasswordlessLoginConfig PasswordlessLoginConfig { get; set; }
        public class DescribeTerminalSettingsResponseBodyPasswordlessLoginConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        /// <summary>
        /// <para>请求ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>47348885-C929-489A-93D7-B2E99D50D77B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
