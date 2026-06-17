// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class SetAutoProtectNewAssetsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic traffic redirection. Valid values:</para>
        /// <para><b>true****false</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoProtect")]
        [Validation(Required=false)]
        public bool? AutoProtect { get; set; }

        /// <summary>
        /// <para>The language. Valid values are zh (Chinese) and <b>en</b> (English). The default value is <b>zh</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The source IP address of the visitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60.182.79.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
