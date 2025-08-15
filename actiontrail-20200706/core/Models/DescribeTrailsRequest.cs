// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeTrailsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query the information about multi-account trails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeOrganizationTrail")]
        [Validation(Required=false)]
        public bool? IncludeOrganizationTrail { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the information about shadow trails. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Do not return the information about shadow trails. It is the default value.</description></item>
        /// <item><description>true: Return the information about shadow trails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeShadowTrails")]
        [Validation(Required=false)]
        public bool? IncludeShadowTrails { get; set; }

        /// <summary>
        /// <para>The names of the trails whose information you want to query. Separate multiple trail names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc,def</para>
        /// </summary>
        [NameInMap("NameList")]
        [Validation(Required=false)]
        public string NameList { get; set; }

    }

}
