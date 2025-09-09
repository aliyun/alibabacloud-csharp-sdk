// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CheckAccountExistRequest : TeaModel {
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<CheckAccountExistRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class CheckAccountExistRequestEcIdAccountIds : TeaModel {
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1004064243473974</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ToUserType")]
        [Validation(Required=false)]
        public int? ToUserType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12323</para>
        /// </summary>
        [NameInMap("TransferAccount")]
        [Validation(Required=false)]
        public string TransferAccount { get; set; }

    }

}
