// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class EditRoutineConfShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the routine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>the description of this routine</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The configurations of the specified environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;staging&quot;:{&quot;SpecName&quot;:&quot;50ms&quot;,&quot;AllowedHosts&quot;:[&quot;test-a.alicdn.com&quot;,&quot;test-b.alicdn.com&quot;]},&quot;production&quot;:{&quot;SpecName&quot;:&quot;50ms&quot;,&quot;AllowedHosts&quot;:[&quot;test-c.alicdn.com&quot;,&quot;test-d.alicdn.com&quot;]},&quot;presetCanaryZhejiang&quot;:{&quot;SpecName&quot;:&quot;100ms&quot;,&quot;AllowedHosts&quot;:[&quot;test-e.alicdn.com&quot;,&quot;test-f.alicdn.com&quot;]},&quot;presetCanaryBeijing&quot;:{&quot;SpecName&quot;:&quot;5ms&quot;,&quot;AllowedHosts&quot;:[&quot;test-g.alicdn.com&quot;,&quot;test-h.alicdn.com&quot;]},&quot;presetCanaryNotExist&quot;:{&quot;SpecName&quot;:&quot;5ms&quot;,&quot;CodeRev&quot;:&quot;1622446907645949975&quot;,&quot;AllowedHosts&quot;:[&quot;error hosts&quot;]}}</para>
        /// </summary>
        [NameInMap("EnvConf")]
        [Validation(Required=false)]
        public string EnvConfShrink { get; set; }

        /// <summary>
        /// <para>The name of the routine. The name must be unique among the routines that belong to the same Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-slc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
