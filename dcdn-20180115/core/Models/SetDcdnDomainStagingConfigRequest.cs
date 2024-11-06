// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class SetDcdnDomainStagingConfigRequest : TeaModel {
        /// <summary>
        /// <para>The accelerated domain name. Separate multiple accelerated domain names with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The list of features. Format: <c>[{&quot;functionArgs&quot;:[{&quot;argName&quot;:&quot;parameter key&quot;,&quot;argValue&quot;:&quot;parameter value&quot;},{&quot;argName&quot;:&quot;xx&quot;,&quot;argValue&quot;:&quot;xx&quot;}],&quot;functionName&quot;: feature name&quot;}]</c></para>
        /// <remarks>
        /// <para>Separate multiple parameters with commas (,).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;functionArgs\&quot;:[{\&quot;argName\&quot;:\&quot;enable\&quot;,\&quot;argValue\&quot;:\&quot;on\&quot;,\&quot;argName\&quot;:\&quot;pri\&quot;,\&quot;argValue\&quot;:\&quot;1\&quot;,\&quot;argName\&quot;:\&quot;rule\&quot;,\&quot;argValue\&quot;:\&quot;xxx\&quot;}],\&quot;functionName\&quot;:\&quot;edge_function\&quot;}]</para>
        /// </summary>
        [NameInMap("Functions")]
        [Validation(Required=false)]
        public string Functions { get; set; }

    }

}
