// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgDesensPlanDeleteRequest : TeaModel {
        /// <summary>
        /// <para>A collection of data masking rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<int?> Ids { get; set; }

        /// <summary>
        /// <para>The code of the level-1 data masking scenario to which the rule belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>dataworks_display_desense_code: masking of displayed data in DataStudio and Data Map</description></item>
        /// <item><description>maxcompute_desense_code: data masking at the MaxCompute compute engine layer</description></item>
        /// <item><description>maxcompute_new_desense_code: data masking at the MaxCompute compute engine layer (new)</description></item>
        /// <item><description>hologres_display_desense_code: data masking at the Hologres compute engine layer</description></item>
        /// <item><description>dataworks_data_integration_desense_code: static data masking in Data Integration</description></item>
        /// <item><description>dataworks_analysis_desense_code: masking of displayed data in DataAnalysis</description></item>
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
