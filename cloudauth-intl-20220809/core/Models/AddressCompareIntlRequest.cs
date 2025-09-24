// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class AddressCompareIntlRequest : TeaModel {
        /// <summary>
        /// <para>Country name</para>
        /// <list type="bullet">
        /// <item><description>China</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fixed value：中国</para>
        /// </summary>
        [NameInMap("DefaultCountry")]
        [Validation(Required=false)]
        public string DefaultCountry { get; set; }

        /// <summary>
        /// <para>ADD_VERIFY</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fixed value：ADD_VERIFY</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Address 1</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州市阿里巴巴西溪园区</para>
        /// </summary>
        [NameInMap("Text1")]
        [Validation(Required=false)]
        public string Text1 { get; set; }

        /// <summary>
        /// <para>Address 2</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州市文一西路969号1号楼</para>
        /// </summary>
        [NameInMap("Text2")]
        [Validation(Required=false)]
        public string Text2 { get; set; }

    }

}
