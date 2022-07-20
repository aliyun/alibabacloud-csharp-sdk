// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateImageSplicingTaskShrinkRequest : TeaModel {
        [NameInMap("Align")]
        [Validation(Required=false)]
        public long? Align { get; set; }

        [NameInMap("BackgroundColor")]
        [Validation(Required=false)]
        public string BackgroundColor { get; set; }

        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("ImageFormat")]
        [Validation(Required=false)]
        public string ImageFormat { get; set; }

        [NameInMap("Margin")]
        [Validation(Required=false)]
        public long? Margin { get; set; }

        [NameInMap("NotifyEndpoint")]
        [Validation(Required=false)]
        public string NotifyEndpoint { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("Padding")]
        [Validation(Required=false)]
        public long? Padding { get; set; }

        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Quality")]
        [Validation(Required=false)]
        public long? Quality { get; set; }

        [NameInMap("ScaleType")]
        [Validation(Required=false)]
        public string ScaleType { get; set; }

        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string SourcesShrink { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
