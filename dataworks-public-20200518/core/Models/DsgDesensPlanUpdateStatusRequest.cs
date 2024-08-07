// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgDesensPlanUpdateStatusRequest : TeaModel {
        /// <summary>
        /// A collection of IDs of the data masking rules of which the status you want to modify.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<int?> Ids { get; set; }

        /// <summary>
        /// The code of the level-1 data masking scenario to which the rule belongs. Valid values:
        /// 
        /// *   dataworks_display_desense_code: masking of displayed data in DataStudio and Data Map
        /// *   maxcompute_desense_code: data masking at the MaxCompute compute engine layer
        /// *   maxcompute_new_desense_code: data masking at the MaxCompute compute engine layer (new)
        /// *   hologres_display_desense_code: data masking at the Hologres compute engine layer
        /// *   dataworks_data_integration_desense_code: static data masking in Data Integration
        /// *   dataworks_analysis_desense_code: masking of displayed data in DataAnalysis
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// The status of the data masking rule. Valid values:
        /// 
        /// *   0: expired
        /// *   1: effective
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
