// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDashboardNl2sqlResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>46e537a5****,3dadsu****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryDashboardNl2sqlResponseBodyResult> Result { get; set; }
        public class QueryDashboardNl2sqlResponseBodyResult : TeaModel {
            [NameInMap("Authorities")]
            [Validation(Required=false)]
            public List<string> Authorities { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>612b</para>
            /// </summary>
            [NameInMap("DashboardName")]
            [Validation(Required=false)]
            public string DashboardName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sasdas****sawdau</para>
            /// </summary>
            [NameInMap("DashboardNl2sqlId")]
            [Validation(Required=false)]
            public string DashboardNl2sqlId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>46e5374665ba4b679ee22e2a2927****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
