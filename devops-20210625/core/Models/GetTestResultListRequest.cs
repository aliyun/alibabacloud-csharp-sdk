// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetTestResultListRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;conditionGroups\&quot;: [[{\&quot;fieldIdentifier\&quot;: \&quot;gmtModified\&quot;, \&quot;operator\&quot;: \&quot;MORE_THAN_AND_EQUAL\&quot;, \&quot;value\&quot;: [\&quot;2023-04-20 18:03:12.442140\&quot;], \&quot;className\&quot;: \&quot;dateTime\&quot;, \&quot;format\&quot;: \&quot;input\&quot;}]]}</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e27b8eace6501ce51cf5d56784</para>
        /// </summary>
        [NameInMap("directoryIdentifier")]
        [Validation(Required=false)]
        public string DirectoryIdentifier { get; set; }

    }

}
