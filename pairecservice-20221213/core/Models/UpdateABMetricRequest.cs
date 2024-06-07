// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateABMetricRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LeftMetricId")]
        [Validation(Required=false)]
        public string LeftMetricId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Realtime")]
        [Validation(Required=false)]
        public bool? Realtime { get; set; }

        [NameInMap("ResultResourceId")]
        [Validation(Required=false)]
        public string ResultResourceId { get; set; }

        [NameInMap("RightMetricId")]
        [Validation(Required=false)]
        public string RightMetricId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        [NameInMap("StatisticsCycle")]
        [Validation(Required=false)]
        public int? StatisticsCycle { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TableMetaId")]
        [Validation(Required=false)]
        public string TableMetaId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
