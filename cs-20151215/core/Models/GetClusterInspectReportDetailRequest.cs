// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterInspectReportDetailRequest : Darabonba.Model {
        /// <summary>
        /// <para>The category of the inspection item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>security: security and compliance</description></item>
        /// <item><description>performance: performance and efficiency </description></item>
        /// <item><description>stability: business stability</description></item>
        /// <item><description>limitation: service limits </description></item>
        /// <item><description>cost: cost optimization</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cost</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter inspection items. If set to true, only abnormal inspection items with a result of true are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableFilter")]
        [Validation(Required=false)]
        public bool? EnableFilter { get; set; }

        /// <summary>
        /// <para>The query language. Valid values:</para>
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
        /// <item><description>advice: advice</description></item>
        /// <item><description>warning: low risk</description></item>
        /// <item><description>error: medium risk</description></item>
        /// <item><description>critical: high risk</description></item>
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
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bb41e2bcb47b747389dce6c0d2</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The object type. Only check items that match the object type are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NodePool</para>
        /// </summary>
        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}

