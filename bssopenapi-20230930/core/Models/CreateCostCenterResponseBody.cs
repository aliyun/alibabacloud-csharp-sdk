// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateCostCenterResponseBody : TeaModel {
        /// <summary>
        /// <para>Data list</para>
        /// </summary>
        [NameInMap("CostCenterDtoList")]
        [Validation(Required=false)]
        public List<CreateCostCenterResponseBodyCostCenterDtoList> CostCenterDtoList { get; set; }
        public class CreateCostCenterResponseBodyCostCenterDtoList : TeaModel {
            /// <summary>
            /// <para>Cost center ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>485938</para>
            /// </summary>
            [NameInMap("CostCenterId")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <para>Cost center name (must be unique within the same account)</para>
            /// 
            /// <b>Example:</b>
            /// <para>资源组</para>
            /// </summary>
            [NameInMap("CostCenterName")]
            [Validation(Required=false)]
            public string CostCenterName { get; set; }

            /// <summary>
            /// <para>Owner user ID of the cost center</para>
            /// 
            /// <b>Example:</b>
            /// <para>1314839403940987</para>
            /// </summary>
            [NameInMap("OwnerAccountId")]
            [Validation(Required=false)]
            public long? OwnerAccountId { get; set; }

            /// <summary>
            /// <para>Parent cost center ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("ParentCostCenterId")]
            [Validation(Required=false)]
            public long? ParentCostCenterId { get; set; }

        }

        /// <summary>
        /// <para>Response metadata</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>C1BD134E-D914-6AE0-1901-AEB2A99FA205</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
