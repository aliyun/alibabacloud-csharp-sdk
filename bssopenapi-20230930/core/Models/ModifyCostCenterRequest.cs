// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ModifyCostCenterRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CostCenterEntityList")]
        [Validation(Required=false)]
        public List<ModifyCostCenterRequestCostCenterEntityList> CostCenterEntityList { get; set; }
        public class ModifyCostCenterRequestCostCenterEntityList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>485938</para>
            /// </summary>
            [NameInMap("CostCenterId")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("CostCenterName")]
            [Validation(Required=false)]
            public string CostCenterName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1314839403940987</para>
            /// </summary>
            [NameInMap("OwnerAccountId")]
            [Validation(Required=false)]
            public long? OwnerAccountId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}
