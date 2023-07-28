// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateApplicationShrinkRequest : TeaModel {
        [NameInMap("AlarmConfig")]
        [Validation(Required=false)]
        public string AlarmConfigShrink { get; set; }

        [NameInMap("DeleteAlarmRulesBeforeUpdate")]
        [Validation(Required=false)]
        public bool? DeleteAlarmRulesBeforeUpdate { get; set; }

        /// <summary>
        /// The description to be updated for the application.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The application name.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region ID. Set the value to cn-hangzhou.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
