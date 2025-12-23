// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeSlowQueryStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C1C1C45-C64A-AD30-565F-140871D57E5E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The return result.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeSlowQueryStatusResponseBodyResult Result { get; set; }
        public class DescribeSlowQueryStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100298370</para>
            /// </summary>
            [NameInMap("appGroupId")]
            [Validation(Required=false)]
            public string AppGroupId { get; set; }

            /// <summary>
            /// <para>The network type of the slow query optimization service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>outer: the Internet</description></item>
            /// <item><description>internal: the internal network</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>internal</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The status of the slow query optimization service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled</description></item>
            /// <item><description>disabled</description></item>
            /// <item><description>n/a</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
