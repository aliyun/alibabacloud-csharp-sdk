// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ModifyQueryProcessorRequest : TeaModel {
        /// <summary>
        /// <para>The request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;domain&quot;: &quot;GENERAL&quot;,
        ///     &quot;category&quot;: &quot;&quot;,
        ///     &quot;processors&quot;: [
        ///         {
        ///             &quot;name&quot;: &quot;synonym&quot;,
        ///             &quot;useSystemDictionary&quot;: true
        ///         },
        ///         {
        ///             &quot;name&quot;: &quot;stop_word&quot;,
        ///             &quot;useSystemDictionary&quot;: true
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public object Body { get; set; }

        /// <summary>
        /// <para>Specifies whether the request is a dry run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
