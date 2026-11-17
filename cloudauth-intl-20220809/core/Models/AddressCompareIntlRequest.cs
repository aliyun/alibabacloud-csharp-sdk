// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class AddressCompareIntlRequest : TeaModel {
        /// <summary>
        /// <para>The country name.</para>
        /// <list type="bullet">
        /// <item><description>China</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fixed value: China</para>
        /// </summary>
        [NameInMap("DefaultCountry")]
        [Validation(Required=false)]
        public string DefaultCountry { get; set; }

        /// <summary>
        /// <para>ADD_VERIFY</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Fixed value: ADD_VERIFY</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The first address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Xixi Campus, Hangzhou</para>
        /// </summary>
        [NameInMap("Text1")]
        [Validation(Required=false)]
        public string Text1 { get; set; }

        /// <summary>
        /// <para>The second address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Building 1, No. 969 West Wenyi Road, Hangzhou</para>
        /// </summary>
        [NameInMap("Text2")]
        [Validation(Required=false)]
        public string Text2 { get; set; }

    }

}
