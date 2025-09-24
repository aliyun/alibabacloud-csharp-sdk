// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class AddressVerifyV2IntlRequest : TeaModel {
        /// <summary>
        /// <para>DeviceToken obtained via the client SDK</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tk9SSUQuMS*****************ZDNmNWY5NzQxOW1o</para>
        /// </summary>
        [NameInMap("DeviceToken")]
        [Validation(Required=false)]
        public string DeviceToken { get; set; }

        /// <summary>
        /// <para>Supported: Chinese mobile phone numbers</para>
        /// 
        /// <b>Example:</b>
        /// <para>1872334****</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>Fixed value: ADD_VERIFY_PRO</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADD_VERIFY_PRO</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>List of prohibited countries or regions</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Currently supported: USA</para>
        /// </summary>
        [NameInMap("RegCountry")]
        [Validation(Required=false)]
        public string RegCountry { get; set; }

        /// <summary>
        /// <para>Detailed address text content</para>
        /// 
        /// <b>Example:</b>
        /// <para>浙江省杭州市西湖区灯彩街云谷园区</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>Address verification method:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HOME</b>: Home address verification</para>
        /// </description></item>
        /// <item><description><para><b>WORK</b>: Work address verification</para>
        /// </description></item>
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
