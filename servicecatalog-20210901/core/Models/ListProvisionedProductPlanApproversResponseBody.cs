// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListProvisionedProductPlanApproversResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of reviewers.</para>
        /// </summary>
        [NameInMap("Approvers")]
        [Validation(Required=false)]
        public List<ListProvisionedProductPlanApproversResponseBodyApprovers> Approvers { get; set; }
        public class ListProvisionedProductPlanApproversResponseBodyApprovers : TeaModel {
            /// <summary>
            /// <para>The name of the reviewer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approver-1</para>
            /// </summary>
            [NameInMap("PrincipalName")]
            [Validation(Required=false)]
            public string PrincipalName { get; set; }

            /// <summary>
            /// <para>The type of the Resource Access Management (RAM) entity of the reviewer. Valid values:</para>
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
        /// <para>0FEEF92D-4052-5202-87D0-3D8EC16F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
