// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCustomLineRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The unique ID of the custom line.&lt;props=&quot;china&quot;&gt; Call <a href="https://help.aliyun.com/en/dns/api-alidns-2015-01-09-describecustomlines?spm=a2c4g.11186623.help-menu-search-29697.d_0">DescribeCustomLines</a> to obtain this ID.
        /// &lt;props=&quot;intl&quot;&gt;Call <a href="https://www.alibabacloud.com/help/en/dns/api-alidns-2015-01-09-describecustomlines?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeCustomLines</a> to obtain this ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5*****</para>
        /// </summary>
        [NameInMap("LineId")]
        [Validation(Required=false)]
        public long? LineId { get; set; }

    }

}
