// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateFundAccountPayRelationRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<CreateFundAccountPayRelationRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class CreateFundAccountPayRelationRequestEcIdAccountIds : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1501603440974415</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12332112</para>
        /// </summary>
        [NameInMap("FundAccountId")]
        [Validation(Required=false)]
        public string FundAccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}
