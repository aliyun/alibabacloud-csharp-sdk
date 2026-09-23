// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateCostCenterRequest : TeaModel {
        /// <summary>
        /// <para>The list of cost center entities.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CostCenterEntityList")]
        [Validation(Required=false)]
        public List<CreateCostCenterRequestCostCenterEntityList> CostCenterEntityList { get; set; }
        public class CreateCostCenterRequestCostCenterEntityList : TeaModel {
            /// <summary>
            /// <para>The cost center name. The name must be unique within the same account.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceGroup</para>
            /// </summary>
            [NameInMap("CostCenterName")]
            [Validation(Required=false)]
            public string CostCenterName { get; set; }

            /// <summary>
            /// <para>The owner user ID of the new cost center.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1314839403940987</para>
            /// </summary>
            [NameInMap("OwnerAccountId")]
            [Validation(Required=false)]
            public long? OwnerAccountId { get; set; }

            /// <summary>
            /// <para>The parent cost center ID. A value of -1 indicates the root cost center.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("ParentCostCenterId")]
            [Validation(Required=false)]
            public long? ParentCostCenterId { get; set; }

        }

        /// <summary>
        /// <para>The primary marketplace ID. If this parameter is left empty, the marketplace ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2084210001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}
