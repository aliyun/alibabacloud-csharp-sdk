// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class AddressVerifyIntlRequest : TeaModel {
        /// <summary>
        /// <para>The type of the address to verify. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>&quot;0&quot;: text address</description></item>
        /// <item><description>&quot;1&quot;: coordinates (longitude and latitude).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“0”</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The default city.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州市</para>
        /// </summary>
        [NameInMap("DefaultCity")]
        [Validation(Required=false)]
        public string DefaultCity { get; set; }

        /// <summary>
        /// <para>The country name. Currently, only China is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>中国</para>
        /// </summary>
        [NameInMap("DefaultCountry")]
        [Validation(Required=false)]
        public string DefaultCountry { get; set; }

        /// <summary>
        /// <para>The default district.</para>
        /// 
        /// <b>Example:</b>
        /// <para>余杭区</para>
        /// </summary>
        [NameInMap("DefaultDistrict")]
        [Validation(Required=false)]
        public string DefaultDistrict { get; set; }

        /// <summary>
        /// <para>The default province.</para>
        /// 
        /// <b>Example:</b>
        /// <para>浙江省</para>
        /// </summary>
        [NameInMap("DefaultProvince")]
        [Validation(Required=false)]
        public string DefaultProvince { get; set; }

        /// <summary>
        /// <para>The latitude.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“31.2304”</para>
        /// </summary>
        [NameInMap("Latitude")]
        [Validation(Required=false)]
        public string Latitude { get; set; }

        /// <summary>
        /// <para>The longitude.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“121.4737”</para>
        /// </summary>
        [NameInMap("Longitude")]
        [Validation(Required=false)]
        public string Longitude { get; set; }

        /// <summary>
        /// <para>Chinese mainland phone numbers are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1872334****</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>Fixed value: ADD_VERIFY_PRO.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADD_VERIFY_PRO</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The detailed address in text format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里巴巴西溪园区</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>The address verification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HOME: home address verification</description></item>
        /// <item><description>WORK: work address verification.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HOME</para>
        /// </summary>
        [NameInMap("VerifyType")]
        [Validation(Required=false)]
        public string VerifyType { get; set; }

    }

}
