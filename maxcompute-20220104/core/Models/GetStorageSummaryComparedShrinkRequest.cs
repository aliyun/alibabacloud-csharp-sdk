// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class GetStorageSummaryComparedShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The start date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250601</para>
        /// </summary>
        [NameInMap("beginDate")]
        [Validation(Required=false)]
        public string BeginDate { get; set; }

        /// <summary>
        /// <para>The end date.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250604</para>
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The list of projects.</para>
        /// </summary>
        [NameInMap("projects")]
        [Validation(Required=false)]
        public string ProjectsShrink { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can log on to the MaxCompute console and choose <b>Tenant Property</b> in the navigation pane on the left to view the tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>483212237127906</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
