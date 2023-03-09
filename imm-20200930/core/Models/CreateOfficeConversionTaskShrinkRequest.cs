// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateOfficeConversionTaskShrinkRequest : TeaModel {
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        [NameInMap("EndPage")]
        [Validation(Required=false)]
        public long? EndPage { get; set; }

        [NameInMap("FirstPage")]
        [Validation(Required=false)]
        public bool? FirstPage { get; set; }

        [NameInMap("FitToHeight")]
        [Validation(Required=false)]
        public bool? FitToHeight { get; set; }

        [NameInMap("FitToWidth")]
        [Validation(Required=false)]
        public bool? FitToWidth { get; set; }

        [NameInMap("HoldLineFeed")]
        [Validation(Required=false)]
        public bool? HoldLineFeed { get; set; }

        [NameInMap("ImageDPI")]
        [Validation(Required=false)]
        public long? ImageDPI { get; set; }

        [NameInMap("LongPicture")]
        [Validation(Required=false)]
        public bool? LongPicture { get; set; }

        [NameInMap("LongText")]
        [Validation(Required=false)]
        public bool? LongText { get; set; }

        [NameInMap("MaxSheetColumn")]
        [Validation(Required=false)]
        public long? MaxSheetColumn { get; set; }

        [NameInMap("MaxSheetRow")]
        [Validation(Required=false)]
        public long? MaxSheetRow { get; set; }

        [NameInMap("Notification")]
        [Validation(Required=false)]
        public string NotificationShrink { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("Pages")]
        [Validation(Required=false)]
        public string Pages { get; set; }

        [NameInMap("PaperHorizontal")]
        [Validation(Required=false)]
        public bool? PaperHorizontal { get; set; }

        [NameInMap("PaperSize")]
        [Validation(Required=false)]
        public string PaperSize { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Quality")]
        [Validation(Required=false)]
        public long? Quality { get; set; }

        [NameInMap("ScalePercentage")]
        [Validation(Required=false)]
        public long? ScalePercentage { get; set; }

        [NameInMap("SheetCount")]
        [Validation(Required=false)]
        public long? SheetCount { get; set; }

        [NameInMap("SheetIndex")]
        [Validation(Required=false)]
        public long? SheetIndex { get; set; }

        [NameInMap("ShowComments")]
        [Validation(Required=false)]
        public bool? ShowComments { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        [NameInMap("StartPage")]
        [Validation(Required=false)]
        public long? StartPage { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        [NameInMap("TargetURI")]
        [Validation(Required=false)]
        public string TargetURI { get; set; }

        [NameInMap("TargetURIPrefix")]
        [Validation(Required=false)]
        public string TargetURIPrefix { get; set; }

        [NameInMap("TrimPolicy")]
        [Validation(Required=false)]
        public string TrimPolicyShrink { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
