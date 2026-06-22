// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileProtectClientRuleDashboardResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned when the API call is successful.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileProtectClientRuleDashboardResponseBodyData Data { get; set; }
        public class GetFileProtectClientRuleDashboardResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total number of web tamper-proofing licenses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("AuthTotal")]
            [Validation(Required=false)]
            public string AuthTotal { get; set; }

            /// <summary>
            /// <para>The number of bound tamper-proofing licenses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("BindCount")]
            [Validation(Required=false)]
            public int? BindCount { get; set; }

            /// <summary>
            /// <para>The total number of web tamper-proofing rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ProtectedDirectoriesCount")]
            [Validation(Required=false)]
            public int? ProtectedDirectoriesCount { get; set; }

            /// <summary>
            /// <para>The total number of online web tamper-proofing clients.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("ProtectedInstancesCount")]
            [Validation(Required=false)]
            public int? ProtectedInstancesCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>69BFFCDE-37D6-5A49-A8BC-BB03AC83****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
