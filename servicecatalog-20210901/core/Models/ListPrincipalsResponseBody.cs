// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListPrincipalsResponseBody : TeaModel {
        /// <summary>
        /// <para>The RAM entities.</para>
        /// </summary>
        [NameInMap("Principals")]
        [Validation(Required=false)]
        public List<ListPrincipalsResponseBodyPrincipals> Principals { get; set; }
        public class ListPrincipalsResponseBodyPrincipals : TeaModel {
            /// <summary>
            /// <para>The ID of the RAM entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>24477111603637****</para>
            /// </summary>
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            [NameInMap("PrincipalPattern")]
            [Validation(Required=false)]
            public string PrincipalPattern { get; set; }

            /// <summary>
            /// <para>The type of the RAM entity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RamUser: a RAM user</description></item>
            /// <item><description>RamRole: a RAM role</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RamUser</para>
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FEEF92D-4052-5202-87D0-3D8EC16F81BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
