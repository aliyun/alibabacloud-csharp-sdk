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
        /// <item><description>If paramType is set to normal, enter the plaintext bank card number.</description></item>
        /// <item><description>If paramType is set to md5, enter the plaintext of the bank card number except the last 6 digits, followed by the 32-character lowercase MD5 hash of the last 6 digits.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>● Plaintext: 12345678******
        /// ● Ciphertext:
        /// 12345678f8ee21920e37807b43e7e912ab829b6e</para>
        /// </summary>
        [NameInMap("BankCard")]
        [Validation(Required=false)]
        public string BankCard { get; set; }

        /// <summary>
        /// <para>The identification document number.</para>
        /// <list type="bullet">
        /// <item><description>If paramType is set to normal, enter the plaintext identification document number.</description></item>
        /// <item><description>If paramType is set to md5:<list type="bullet">
        /// <item><description>For an ID card, enter the first 6 digits in plaintext, followed by the ciphertext of the date of birth, and then the last 4 digits in plaintext.</description></item>
        /// <item><description>For other identification documents, encrypt the last two characters by using MD5.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>Important:
        /// This parameter is required if ProductType is set to one of the following values:</para>
        /// <list type="bullet">
        /// <item><description>BANK_CARD_3_META</description></item>
        /// <item><description>BANK_CARD_4_META</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>● Plaintext: 429001********8211
        /// ● Ciphertext:
        /// 42900132fa7bcd874161bea8ec8fd98f390ec98211</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>The type of the identification document. If you leave this parameter empty, the default value is ID card. For other types of identification documents, see the following table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// <para>The mobile phone number.</para>
        /// <list type="bullet">
        /// <item><description>If paramType is set to normal, enter the plaintext mobile phone number.</description></item>
        /// <item><description>If paramType is set to md5, enter the ciphertext mobile phone number.</description></item>
        /// </list>
        /// <para>Important:</para>
        /// <list type="bullet">
        /// <item><description>This parameter is required if ProductType is set to BANK_CARD_4_META.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>● Plaintext: 186****2055
        /// ● Ciphertext:
        /// 849169cd3b20621c1c78bd61a11a4fc2</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The encryption method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: No encryption.</description></item>
        /// <item><description>md5: MD5 encryption.</description></item>
        /// </list>
        /// <para>Important:</para>
        /// <list type="bullet">
        /// <item><description>The ciphertext of all parameters must be a 32-character lowercase MD5 string.</description></item>
        /// <item><description>Different MD5 tools may generate different ciphertexts. If the API call succeeds before encryption but fails after encryption, try using a different MD5 tool.</description></item>
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
        /// <para>The fixed value. Valid value: BANK_CARD_N_META.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BANK_CARD_N_META</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BANK_CARD_2_META: Verifies the bank card number and name.</description></item>
        /// <item><description>BANK_CARD_3_META: Verifies the bank card number, name, and ID card number.</description></item>
        /// <item><description>BANK_CARD_4_META: Verifies the bank card number, name, ID card number, and mobile phone number.</description></item>
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
        /// <item><description>If paramType is set to normal, enter the plaintext name.</description></item>
        /// <item><description>If paramType is set to md5, enter the 32-character lowercase MD5 hash of the first character of the name, followed by the plaintext of the remaining characters.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang*</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The verification mode. Valid value: VERIFY_BANK_CARD. This value indicates the bank card authentication mode, which verifies whether the provided bank card number matches the real name, ID card number, and mobile phone number of the user.</para>
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
