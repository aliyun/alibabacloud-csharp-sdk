// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ModifyAudioFileRequest : TeaModel {
        [NameInMap("AudioFileName")]
        [Validation(Required=false)]
        public string AudioFileName { get; set; }

        [NameInMap("AudioResourceId")]
        [Validation(Required=false)]
        public string AudioResourceId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OssFileKey")]
        [Validation(Required=false)]
        public string OssFileKey { get; set; }

        [NameInMap("Usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

    }

}
