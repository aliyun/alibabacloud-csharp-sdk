// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetTestcaseListRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;conditionGroups\&quot;:[[{\&quot;fieldIdentifier\&quot;:\&quot;status\&quot;,\&quot;operator\&quot;:\&quot;CONTAINS\&quot;,\&quot;value\&quot;:[\&quot;cc961a18adf770c6e423ccc5\&quot;],\&quot;toValue\&quot;:null,,\&quot;className\&quot;:\&quot;status\&quot;,\&quot;format\&quot;:\&quot;list\&quot;}]]}</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>e27b8eace6501ce51cf5d56784</para>
        /// </summary>
        [NameInMap("directoryIdentifier")]
        [Validation(Required=false)]
        public string DirectoryIdentifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResult")]
        [Validation(Required=false)]
        public string MaxResult { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2591861102250c4522380b33a6</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6d5984c7d92b23fa53d4743c37</para>
        /// </summary>
        [NameInMap("spaceIdentifier")]
        [Validation(Required=false)]
        public string SpaceIdentifier { get; set; }

    }

}
