// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileDetectResultRequest : TeaModel {
        /// <summary>
        /// <para>An array of up to 100 unique file identifiers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HashKeyList")]
        [Validation(Required=false)]
        public List<string> HashKeyList { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>183.46.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of file to detect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: malicious file detection</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: Skill compressed package detection</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
