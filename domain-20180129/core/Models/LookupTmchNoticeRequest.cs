// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class LookupTmchNoticeRequest : TeaModel {
        /// <summary>
        /// <para>The trademark claim key. Call the <a href="https://help.aliyun.com/document_detail/97210.htm?spm=a2c4g.11186623.0.0.4aec615fTVPYjt">CheckDomainSunriseClaim</a> operation to obtain this key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017092100/8/2/1/kDfu9htHGEx_y-LJ3XSlKMZ70000020001</para>
        /// </summary>
        [NameInMap("ClaimKey")]
        [Validation(Required=false)]
        public string ClaimKey { get; set; }

        /// <summary>
        /// <para>The language of the error messages that are returned by the API. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The user\&quot;s IP address. You can set this parameter to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
