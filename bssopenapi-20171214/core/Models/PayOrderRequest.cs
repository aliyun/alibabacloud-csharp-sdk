// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class PayOrderRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1178418164369806</para>
        /// </summary>
        [NameInMap("BuyerId")]
        [Validation(Required=false)]
        public long? BuyerId { get; set; }

        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<PayOrderRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class PayOrderRequestEcIdAccountIds : TeaModel {
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>26888345</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>260591304500425</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>201437655683478597</para>
        /// </summary>
        [NameInMap("PaySubmitUid")]
        [Validation(Required=false)]
        public long? PaySubmitUid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>201437655683478597</para>
        /// </summary>
        [NameInMap("PayerId")]
        [Validation(Required=false)]
        public long? PayerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJwYWdlTnVtIjoyLCJwYWdlU2l6ZSI6MTB9</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
