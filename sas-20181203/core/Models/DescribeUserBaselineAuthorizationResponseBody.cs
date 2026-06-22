// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUserBaselineAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AF20EB0-EBBC-4B94-9B84-F3BAFAC53EDE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The authorization information for cloud baseline configuration check.</para>
        /// </summary>
        [NameInMap("UserBaselineAuthorization")]
        [Validation(Required=false)]
        public DescribeUserBaselineAuthorizationResponseBodyUserBaselineAuthorization UserBaselineAuthorization { get; set; }
        public class DescribeUserBaselineAuthorizationResponseBodyUserBaselineAuthorization : TeaModel {
            /// <summary>
            /// <para>The authorization status of the cloud platform configuration check. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Authorization is disabled. If authorization is disabled, you cannot use the cloud platform configuration check feature.</description></item>
            /// <item><description><b>1</b>: Authorization is enabled. If authorization is enabled, you can use the cloud platform configuration check feature.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
