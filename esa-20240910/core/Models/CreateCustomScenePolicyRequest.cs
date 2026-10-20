// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateCustomScenePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the policy.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
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
        /// <para>The IDs of the websites to be associated. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. Use the SiteIds parameter instead. If the SiteIds parameter is specified, the value of the SiteIds parameter takes precedence and the value of the Objects parameter does not take effect. To avoid ambiguity in update operations, you must specify at least one of the SiteIds and Objects parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7096621098****,7096621099****</para>
        /// </summary>
        [NameInMap("Objects")]
        [Validation(Required=false)]
        public string Objects { get; set; }

        /// <summary>
        /// <para>The IDs of the websites to be associated. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>7096621098****,7096621099****</para>
        /// </summary>
        [NameInMap("SiteIds")]
        [Validation(Required=false)]
        public string SiteIds { get; set; }

        /// <summary>
        /// <para>The start time of the policy.</para>
        /// <para>Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-07T17:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>promotion</b>: Important Activity.</description></item>
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
