// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InvoiceAddRequest : TeaModel {
        /// <summary>
        /// <para>The registered address. This parameter is required when type is set to 2 (VAT special invoice).</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The name of the bank where the account is opened. This parameter is required when type is set to 2 (VAT special invoice).</para>
        /// 
        /// <b>Example:</b>
        /// <para>XX银行</para>
        /// </summary>
        [NameInMap("bank_name")]
        [Validation(Required=false)]
        public string BankName { get; set; }

        /// <summary>
        /// <para>The bank account number. This parameter is required when type is set to 2 (VAT special invoice).</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("bank_no")]
        [Validation(Required=false)]
        public string BankNo { get; set; }

        [NameInMap("mail_third_part_id")]
        [Validation(Required=false)]
        public string MailThirdPartId { get; set; }

        /// <summary>
        /// <para>The tax identification number. This parameter is required when unit_type is set to 1. This parameter is optional when unit_type is set to 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("tax_no")]
        [Validation(Required=false)]
        public string TaxNo { get; set; }

        /// <summary>
        /// <para>The company phone number. This parameter is required when type is set to 2 (VAT special invoice).</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("tel")]
        [Validation(Required=false)]
        public string Tel { get; set; }

        /// <summary>
        /// <para>The third-party invoice ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>340049</para>
        /// </summary>
        [NameInMap("third_part_id")]
        [Validation(Required=false)]
        public string ThirdPartId { get; set; }

        /// <summary>
        /// <para>The invoice header.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试发票</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The invoice type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: VAT general invoice.</description></item>
        /// <item><description>2: VAT special invoice.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>The entity type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Enterprise entity. The tax number is required.</description></item>
        /// <item><description>2: Non-enterprise entity. The tax number is optional.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("unit_type")]
        [Validation(Required=false)]
        public int? UnitType { get; set; }

    }

}
