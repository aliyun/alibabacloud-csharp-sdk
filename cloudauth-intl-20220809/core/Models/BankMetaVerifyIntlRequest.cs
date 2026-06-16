// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class BankMetaVerifyIntlRequest : TeaModel {
        /// <summary>
        /// <para>The bank card number.</para>
        /// <list type="bullet">
        /// <item><description>If paramType is set to normal, enter the bank card number in plaintext.</description></item>
        /// <item><description>If paramType is set to md5, provide the plaintext of all digits except the last 6 digits + the MD5 value (32-character lowercase) of the last 6 digits.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>● 明文：12345678******
        /// ● 密文：
        /// 12345678f8ee21920e37807b43e7e912ab829b6e</para>
        /// </summary>
        [NameInMap("BankCard")]
        [Validation(Required=false)]
        public string BankCard { get; set; }

        /// <summary>
        /// <para>The ID document number.</para>
        /// <list type="bullet">
        /// <item><description>If paramType is set to normal, enter the ID document number in plaintext.</description></item>
        /// <item><description>If paramType is set to md5:<list type="bullet">
        /// <item><description>For ID cards: the first 6 digits (plaintext) + date of birth (ciphertext) + the last 4 digits (plaintext).</description></item>
        /// <item><description>For other documents: the last 2 characters are MD5-encrypted.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>Important:
        /// This parameter is required when ProductType is set to one of the following values:</para>
        /// <list type="bullet">
        /// <item><description>BANK_CARD_3_META</description></item>
        /// <item><description>BANK_CARD_4_META.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>● 明文：429001********8211
        /// ● 密文：
        /// 42900132fa7bcd874161bea8ec8fd98f390ec98211</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>The ID document type. If left empty, the default value is ID card. For other document types, refer to the table below.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// <para>The phone number.</para>
        /// <list type="bullet">
        /// <item><description>If paramType is set to normal, enter the phone number in plaintext.</description></item>
        /// <item><description>If paramType is set to md5, enter the phone number in ciphertext.</description></item>
        /// </list>
        /// <para>Important:</para>
        /// <list type="bullet">
        /// <item><description>This parameter is required when ProductType is set to BANK_CARD_4_META.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>● 明文：186****2055
        /// ● 密文：
        /// 849169cd3b20621c1c78bd61a11a4fc2</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The encryption method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: no encryption</description></item>
        /// <item><description>md5: MD5 encryption</description></item>
        /// </list>
        /// <para>Important:</para>
        /// <list type="bullet">
        /// <item><description>All encrypted parameter values must be 32-character lowercase MD5 strings.</description></item>
        /// <item><description>Different MD5 tools may produce different ciphertext. If the API call succeeds before encryption but fails after encryption, try a different MD5 tool.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>Fixed value: BANK_CARD_N_META.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BANK_CARD_N_META</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The product type to call. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BANK_CARD_2_META: Bank card number + name verification.</description></item>
        /// <item><description>BANK_CARD_3_META: Bank card number + name + ID card number verification.</description></item>
        /// <item><description>BANK_CARD_4_META: Bank card number + name + ID card number + phone number verification.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BANK_CARD_4_META</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <list type="bullet">
        /// <item><description>If paramType is set to normal, enter the name in plaintext.</description></item>
        /// <item><description>If paramType is set to md5, provide the MD5-encrypted first character of the name (32-character lowercase MD5) + the plaintext of the remaining characters.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张*</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>VERIFY_BANK_CARD: bank card authentication mode. Indicates whether the provided bank card number matches the user\&quot;s real name, ID card number, and phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VERIFY_BANK_CARD</para>
        /// </summary>
        [NameInMap("VerifyMode")]
        [Validation(Required=false)]
        public string VerifyMode { get; set; }

    }

}
