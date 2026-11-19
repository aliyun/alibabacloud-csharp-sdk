// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDashboardNl2sqlResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46e537a5****,3dadsu****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The execution result of the API operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request succeeded.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryDashboardNl2sqlResponseBodyResult> Result { get; set; }
        public class QueryDashboardNl2sqlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The permissions on the dashboard NL2SQL resource. If this parameter has a value and contains READ, it indicates that the user has NL2SQL permissions on the dashboard NL2SQL resource.</para>
            /// </summary>
            [NameInMap("Authorities")]
            [Validation(Required=false)]
            public List<string> Authorities { get; set; }

            /// <summary>
            /// <para>The name of the dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>612b</para>
            /// </summary>
            [NameInMap("DashboardName")]
            [Validation(Required=false)]
            public string DashboardName { get; set; }

            /// <summary>
            /// <para>The NL2SQL resource ID of the dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sasdas****sawdau</para>
            /// </summary>
            [NameInMap("DashboardNl2sqlId")]
            [Validation(Required=false)]
            public string DashboardNl2sqlId { get; set; }

            /// <summary>
            /// <para>The user ID of the dashboard creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>46e5374665ba4b679ee22e2a2927****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether the request is successful. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>true: The request succeeded.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
