// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterInspectReportDetailRequest : TeaModel {
        /// <summary>
        /// <para>The category of the inspection item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>security: Security compliance</description></item>
        /// <item><description>performance: Performance efficiency</description></item>
        /// <item><description>stability: Business stability</description></item>
        /// <item><description>limitation: Service limits</description></item>
        /// <item><description>cost: Cost optimization</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cost</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>Inspection results filtering. If this parameter is set to true, only abnormal inspection items are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableFilter")]
        [Validation(Required=false)]
        public bool? EnableFilter { get; set; }

        /// <summary>
        /// <para>The query language.</para>
        /// <list type="bullet">
        /// <item><description>zh_CN</description></item>
        /// <item><description>en_US</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_CN</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The level of the inspection item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>advice: Suggestions</description></item>
        /// <item><description>warning: Low severity</description></item>
        /// <item><description>error: Medium severity</description></item>
        /// <item><description>critical: High severity</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to display the returned tags on multiple pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bb41e2bcb47b747389dce6c0d2</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The type of the inspection object. Only items that meet the targetType parameter are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NodePool</para>
        /// </summary>
        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
