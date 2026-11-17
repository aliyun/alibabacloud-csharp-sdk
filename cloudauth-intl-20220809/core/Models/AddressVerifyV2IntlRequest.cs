// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class AddressVerifyV2IntlRequest : TeaModel {
        /// <summary>
        /// <para>The device token used for risk identification.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tk9SSUQuMS*****************ZDNmNWY5NzQxOW1o</para>
        /// </summary>
        [NameInMap("DeviceToken")]
        [Validation(Required=false)]
        public string DeviceToken { get; set; }

        /// <summary>
        /// <para>The mobile phone number. Only mobile phone numbers in the Chinese mainland are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1872334****</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The product code. Set the value to ADD_VERIFY_PRO.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADD_VERIFY_PRO</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The list of prohibited countries.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Currently supported: USA</para>
        /// </summary>
        [NameInMap("RegCountry")]
        [Validation(Required=false)]
        public string RegCountry { get; set; }

        /// <summary>
        /// <para>The detailed address text.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Jiangsu Province, Changzhou City, ******* Community</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>The address verification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HOME: Home address verification.</description></item>
        /// <item><description>WORK: Work address verification.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HOME</para>
        /// </summary>
        [NameInMap("VerifyType")]
        [Validation(Required=false)]
        public string VerifyType { get; set; }

    }

}
