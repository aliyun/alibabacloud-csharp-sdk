// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class BankMetaVerifyRequest : TeaModel {
        /// <summary>
        /// <para>Bank card number.</para>
        /// <list type="bullet">
        /// <item><description>When <c>paramType</c> is <c>normal</c>, enter the plain text bank card number.</description></item>
        /// <item><description>When <c>paramType</c> is <c>md5</c>, enter the part of the card number except the last 6 digits in plain text + the last 6 digits encrypted with MD5 (32 lowercase).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>610*************1181</para>
        /// </summary>
        [NameInMap("BankCard")]
        [Validation(Required=false)]
        public string BankCard { get; set; }

        /// <summary>
        /// <para>ID number.</para>
        /// <list type="bullet">
        /// <item><description>When <c>ProductType</c> is <c>BANK_CARD_3_META</c>, this field is required.</description></item>
        /// <item><description>When <c>paramType</c> is <c>normal</c>, enter the plain text ID number.</description></item>
        /// <item><description>When <c>paramType</c> is <c>md5</c>, enter the first 6 digits of the ID number in plain text + the birth date encrypted with MD5 (32 lowercase MD5) + the last 4 digits of the ID number.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>429001********8211</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>Identity type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// <para>Mobile phone number.</para>
        /// <list type="bullet">
        /// <item><description>When <c>ProductType</c> is <c>BANK_CARD_4_META</c>, this field is required.</description></item>
        /// <item><description>When <c>paramType</c> is <c>normal</c>, enter the plain text mobile phone number.</description></item>
        /// <item><description>When <c>paramType</c> is <c>md5</c>, enter the mobile phone number (32 lowercase MD5).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>138******11</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>Parameter type:</para>
        /// <list type="bullet">
        /// <item><description>normal: Unencrypted.</description></item>
        /// <item><description>md5: MD5 encrypted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>Product type to call:</para>
        /// <list type="bullet">
        /// <item><description>BANK_CARD_2_META: Bank card number + name verification.</description></item>
        /// <item><description>BANK_CARD_3_META: Bank card number + name + ID number verification.</description></item>
        /// <item><description>BANK_CARD_4_META: Bank card number + name + ID number + mobile phone number verification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BANK_CARD_2_META</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>Name.</para>
        /// <list type="bullet">
        /// <item><description>When <c>paramType</c> is <c>normal</c>, enter the plain text name.</description></item>
        /// <item><description>When <c>paramType</c> is <c>md5</c>, encrypt the first character of the name with MD5 (32 lowercase MD5) + the rest of the name in plain text.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>张*</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>VERIFY_BANK_CARD: Bank card authentication mode. It indicates whether the provided bank card number matches the user\&quot;s real name, ID number, and mobile phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VERIFY_BANK_CARD</para>
        /// </summary>
        [NameInMap("VerifyMode")]
        [Validation(Required=false)]
        public string VerifyMode { get; set; }

    }

}
