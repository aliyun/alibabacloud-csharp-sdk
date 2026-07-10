// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class BankMetaVerifyRequest : TeaModel {
        /// <summary>
        /// <para>The bank card number.</para>
        /// <list type="bullet">
        /// <item><description>If paramType is set to normal, enter the bank card number in plaintext.</description></item>
        /// <item><description>If paramType is set to md5, enter the card number excluding the last 6 digits in plaintext + the MD5 hash (32-bit lowercase) of the last 6 digits.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>610*************1181</para>
        /// </summary>
        [NameInMap("BankCard")]
        [Validation(Required=false)]
        public string BankCard { get; set; }

        /// <summary>
        /// <para>The ID card number.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is required if ProductType is set to BANK_CARD_3_META.</description></item>
        /// <item><description>If paramType is set to normal, enter the ID card number in plaintext.</description></item>
        /// <item><description>If paramType is set to md5, enter the first 6 digits of the ID card number in plaintext + the MD5 hash (32-bit lowercase) of the date of birth + the last 4 digits of the ID card number.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>429001********8211</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>The identity document type.</para>
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
        /// <item><description>This parameter is required if ProductType is set to BANK_CARD_4_META.</description></item>
        /// <item><description>If paramType is set to normal, enter the phone number in plaintext.</description></item>
        /// <item><description>If paramType is set to md5, enter the MD5 hash (32-bit lowercase) of the phone number.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>138******11</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The parameter type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: not encrypted.</description></item>
        /// <item><description>md5: MD5-encrypted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>The product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BANK_CARD_2_META: bank card number + name verification.</description></item>
        /// <item><description>BANK_CARD_3_META: bank card number + name + ID card number verification.</description></item>
        /// <item><description>BANK_CARD_4_META: bank card number + name + ID card number + phone number verification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BANK_CARD_2_META</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <list type="bullet">
        /// <item><description>If paramType is set to normal, enter the name in plaintext.</description></item>
        /// <item><description>If paramType is set to md5, enter the MD5 hash (32-bit lowercase) of the first character of the name + the remaining characters of the name in plaintext.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>张*</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>VERIFY_BANK_CARD: bank card verification mode. Specifies whether the provided bank card number matches the real name, ID card number, and phone number of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VERIFY_BANK_CARD</para>
        /// </summary>
        [NameInMap("VerifyMode")]
        [Validation(Required=false)]
        public string VerifyMode { get; set; }

    }

}
