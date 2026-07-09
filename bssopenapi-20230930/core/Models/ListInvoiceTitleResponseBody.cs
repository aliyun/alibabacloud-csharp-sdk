// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListInvoiceTitleResponseBody : TeaModel {
        /// <summary>
        /// <para>Invoice title list</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListInvoiceTitleResponseBodyData> Data { get; set; }
        public class ListInvoiceTitleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Bank name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>招商银行</para>
            /// </summary>
            [NameInMap("AccountBankName")]
            [Validation(Required=false)]
            public string AccountBankName { get; set; }

            /// <summary>
            /// <para>Account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1990699401005016</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>Basic bank account number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890</para>
            /// </summary>
            [NameInMap("BankAccountNumber")]
            [Validation(Required=false)]
            public string BankAccountNumber { get; set; }

            /// <summary>
            /// <para>The time when the invoice title was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-01 00:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Invoice title ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Invoice title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx公司</para>
            /// </summary>
            [NameInMap("InvoiceTitle")]
            [Validation(Required=false)]
            public string InvoiceTitle { get; set; }

            /// <summary>
            /// <para>Registered address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京市朝阳区</para>
            /// </summary>
            [NameInMap("RegisteredAddress")]
            [Validation(Required=false)]
            public string RegisteredAddress { get; set; }

            /// <summary>
            /// <para>Registered landline number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>010-12345678</para>
            /// </summary>
            [NameInMap("RegisteredLandline")]
            [Validation(Required=false)]
            public string RegisteredLandline { get; set; }

            /// <summary>
            /// <para>Unified social credit code. 15, 17, 18, or 20 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111111111111111</para>
            /// </summary>
            [NameInMap("UnifiedSocialCreditCode")]
            [Validation(Required=false)]
            public string UnifiedSocialCreditCode { get; set; }

        }

        /// <summary>
        /// <para>Response metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6000EE23-274B-4E07-A697-FF2E999520A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
