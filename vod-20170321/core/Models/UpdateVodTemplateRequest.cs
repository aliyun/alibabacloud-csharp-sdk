// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateVodTemplateRequest : TeaModel {
        /// <summary>
        /// The name of the template.
        /// 
        /// *   The name can be up to 128 bytes in length.
        /// *   The value must be encoded in UTF-8.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The configurations of the snapshot template. The value is a JSON-formatted string. For more information about the data structure, see the "SnapshotTemplateConfig" section of the [Media processing parameters](~~98618~~) topic.
        /// </summary>
        [NameInMap("TemplateConfig")]
        [Validation(Required=false)]
        public string TemplateConfig { get; set; }

        /// <summary>
        /// The ID of the snapshot template.
        /// </summary>
        [NameInMap("VodTemplateId")]
        [Validation(Required=false)]
        public string VodTemplateId { get; set; }

    }

}
