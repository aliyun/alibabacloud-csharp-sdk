// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class GetPolicyEnableStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C8DF1B1-C65F-5D3A-9FDA-26A4683BB36B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the Tag Policy feature.</para>
        /// </summary>
        [NameInMap("StatusModels")]
        [Validation(Required=false)]
        public List<GetPolicyEnableStatusResponseBodyStatusModels> StatusModels { get; set; }
        public class GetPolicyEnableStatusResponseBodyStatusModels : TeaModel {
            /// <summary>
            /// <para>The status of the Tag Policy feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PendingEnable: The feature is being enabled.</description></item>
            /// <item><description>Enabled: The feature is enabled.</description></item>
            /// <item><description>Closing: The feature is being disabled.</description></item>
            /// <item><description>Disabled: The feature is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The mode of the Tag Policy feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>USER: single-account mode</description></item>
            /// <item><description>RD: multi-account mode</description></item>
            /// </list>
            /// <para>For more information about the modes of the Tag Policy feature, see <a href="https://help.aliyun.com/document_detail/417434.html">Modes of the Tag Policy feature</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RD</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

    }

}
