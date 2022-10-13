// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ModifyAsrConfigRequest : TeaModel {
        [NameInMap("AsrAcousticModelId")]
        [Validation(Required=false)]
        public string AsrAcousticModelId { get; set; }

        [NameInMap("AsrClassVocabularyId")]
        [Validation(Required=false)]
        public string AsrClassVocabularyId { get; set; }

        [NameInMap("AsrCustomizationId")]
        [Validation(Required=false)]
        public string AsrCustomizationId { get; set; }

        [NameInMap("AsrVocabularyId")]
        [Validation(Required=false)]
        public string AsrVocabularyId { get; set; }

        [NameInMap("ConfigLevel")]
        [Validation(Required=false)]
        public int? ConfigLevel { get; set; }

        [NameInMap("EntryId")]
        [Validation(Required=false)]
        public string EntryId { get; set; }

    }

}
