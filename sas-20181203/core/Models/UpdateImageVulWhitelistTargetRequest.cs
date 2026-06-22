// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateImageVulWhitelistTargetRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the vulnerability whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000083</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The reason for adding the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ignore</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The source of the whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image</b>: image</description></item>
        /// <item><description><b>agentless</b>: agentless.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The operation target. This parameter is in JSON format and contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>type</b>: The target type. Set to repo.</description></item>
        /// <item><description><b>target</b>: The target content. Format: namespace/image repository.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;type\&quot;:\&quot;repo\&quot;,\&quot;target\&quot;:[\&quot;sas_test/script_0209\&quot;,\&quot;sas_test/script\&quot;]}</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}
