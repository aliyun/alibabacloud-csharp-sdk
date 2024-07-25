// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateAvatarTrainingJobRequest : TeaModel {
        [NameInMap("AvatarDescription")]
        [Validation(Required=false)]
        public string AvatarDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AvatarName")]
        [Validation(Required=false)]
        public string AvatarName { get; set; }

        [NameInMap("AvatarType")]
        [Validation(Required=false)]
        public string AvatarType { get; set; }

        [NameInMap("Portrait")]
        [Validation(Required=false)]
        public string Portrait { get; set; }

        [NameInMap("Thumbnail")]
        [Validation(Required=false)]
        public string Thumbnail { get; set; }

        [NameInMap("Transparent")]
        [Validation(Required=false)]
        public bool? Transparent { get; set; }

        [NameInMap("Video")]
        [Validation(Required=false)]
        public string Video { get; set; }

    }

}
