// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUserBaselineAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AF20EB0-EBBC-4B94-9B84-F3BAFAC53EDE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about whether Security Center is authorized to run configuration checks on cloud services.</para>
        /// </summary>
        [NameInMap("UserBaselineAuthorization")]
        [Validation(Required=false)]
        public DescribeUserBaselineAuthorizationResponseBodyUserBaselineAuthorization UserBaselineAuthorization { get; set; }
        public class DescribeUserBaselineAuthorizationResponseBodyUserBaselineAuthorization : TeaModel {
            /// <summary>
            /// <para>Indicates whether Security Center is authorized to run configuration checks on cloud services.</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: no. Security Center is not authorized to run configuration checks on cloud services.</description></item>
            /// <item><description><b>1</b>: yes. Security Center is authorized to run configuration checks on cloud services.</description></item>
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
