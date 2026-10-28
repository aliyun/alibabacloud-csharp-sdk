// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class QuotaUser : TeaModel {
        /// <summary>
        /// <para>The resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public QuotaUserResources Resources { get; set; }
        public class QuotaUserResources : TeaModel {
            /// <summary>
            /// <para>The submitted resources.</para>
            /// </summary>
            [NameInMap("Submitted")]
            [Validation(Required=false)]
            public ResourceAmount Submitted { get; set; }

            /// <summary>
            /// <para>The used resources.</para>
            /// </summary>
            [NameInMap("Used")]
            [Validation(Required=false)]
            public ResourceAmount Used { get; set; }

        }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The workload count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("WorkloadCount")]
        [Validation(Required=false)]
        public int? WorkloadCount { get; set; }

    }

}
