// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgDesensPlanDeleteRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the masking rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<int?> Ids { get; set; }

        /// <summary>
        /// <para>The code of the level-1 masking scenario to which the masking rule belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>dataworks_display_desense_code: Data Studio and Data Map display masking</description></item>
        /// <item><description>maxcompute_desense_code: MaxCompute engine-level masking</description></item>
        /// <item><description>maxcompute_new_desense_code: MaxCompute engine-level masking (new)</description></item>
        /// <item><description>hologres_display_desense_code: Hologres engine-level masking</description></item>
        /// <item><description>dataworks_data_integration_desense_code: Data Integration static data masking</description></item>
        /// <item><description>dataworks_analysis_desense_code: Data Analysis display masking</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dataworks_display_desense_code</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

    }

}
