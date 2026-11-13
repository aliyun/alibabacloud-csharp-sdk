// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgDesensPlanUpdateStatusShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the masking rules whose status you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string IdsShrink { get; set; }

        /// <summary>
        /// <para>The code of the level-1 masking scenario to which the masking rule belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>dataworks_display_desense_code: Data Studio and Data Map display masking.</description></item>
        /// <item><description>maxcompute_desense_code: MaxCompute engine layer masking.</description></item>
        /// <item><description>maxcompute_new_desense_code: MaxCompute engine layer masking (new).</description></item>
        /// <item><description>hologres_display_desense_code: Hologres engine layer masking.</description></item>
        /// <item><description>dataworks_data_integration_desense_code: Data Integration static data masking.</description></item>
        /// <item><description>dataworks_analysis_desense_code: Data Analysis display masking.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataworks_display_desense_code</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>The effective status of the masking rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Inactive.</description></item>
        /// <item><description>1: Active.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
