// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateCustomScenePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The policy end time.</para>
        /// <para>The time must be in UTC and in ISO 8601 format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-07T18:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The IDs of the sites to associate with the policy. Separate multiple site IDs with commas.</para>
        /// <remarks>
        /// <para>This parameter is deprecated. Use <c>SiteIds</c> instead. If <c>SiteIds</c> is specified, the value of this parameter is ignored. To prevent ambiguity, specify a value for either <c>SiteIds</c> or <c>Objects</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7096621098****,7096621099****</para>
        /// </summary>
        [NameInMap("Objects")]
        [Validation(Required=false)]
        public string Objects { get; set; }

        /// <summary>
        /// <para>The IDs of the sites to associate with the policy. Separate multiple site IDs with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7096621098****,7096621099****</para>
        /// </summary>
        [NameInMap("SiteIds")]
        [Validation(Required=false)]
        public string SiteIds { get; set; }

        /// <summary>
        /// <para>The policy start time.</para>
        /// <para>The time must be in UTC and in ISO 8601 format: <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-07T17:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The template name. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>promotion</b>: a policy for major events.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>promotion</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
