// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryAlertRulesRelationTypeFilter : TeaModel {
        /// <summary>
        /// <para>Matches any value in the set with OR semantics. Valid values: ALL, UMODEL_ENTITY, CLOUD_INSTANCE, GROUP_V1, GROUP_V2, and TAG.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ALL&quot;,&quot;CLOUD_INSTANCE&quot;]</para>
        /// </summary>
        [NameInMap("in")]
        [Validation(Required=false)]
        public List<string> In { get; set; }

        /// <summary>
        /// <para>Excludes any value in the set with NOT IN semantics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;TAG&quot;,&quot;GROUP_V1&quot;]</para>
        /// </summary>
        [NameInMap("notIn")]
        [Validation(Required=false)]
        public List<string> NotIn { get; set; }

    }

}
