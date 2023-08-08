/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20220930.Models
{
    public class CreateFileTransRequest : TeaModel {
        [NameInMap("AbilityParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> AbilityParams { get; set; }

        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("AsrParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> AsrParams { get; set; }

        [NameInMap("AudioLanguage")]
        [Validation(Required=false)]
        public string AudioLanguage { get; set; }

        [NameInMap("AudioOssBucket")]
        [Validation(Required=false)]
        public string AudioOssBucket { get; set; }

        [NameInMap("AudioOssPath")]
        [Validation(Required=false)]
        public string AudioOssPath { get; set; }

        [NameInMap("AudioOutputEnabled")]
        [Validation(Required=false)]
        public bool? AudioOutputEnabled { get; set; }

        [NameInMap("AudioOutputOssBucket")]
        [Validation(Required=false)]
        public string AudioOutputOssBucket { get; set; }

        [NameInMap("AudioOutputOssPath")]
        [Validation(Required=false)]
        public string AudioOutputOssPath { get; set; }

        [NameInMap("AudioRoleNum")]
        [Validation(Required=false)]
        public string AudioRoleNum { get; set; }

        [NameInMap("AudioSegmentsEnabled")]
        [Validation(Required=false)]
        public bool? AudioSegmentsEnabled { get; set; }

        [NameInMap("LabParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> LabParams { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        [NameInMap("TransKey")]
        [Validation(Required=false)]
        public string TransKey { get; set; }

        [NameInMap("TransResultOssBucket")]
        [Validation(Required=false)]
        public string TransResultOssBucket { get; set; }

        [NameInMap("TransResultOssPath")]
        [Validation(Required=false)]
        public string TransResultOssPath { get; set; }

        [NameInMap("VideoOutputEnabled")]
        [Validation(Required=false)]
        public bool? VideoOutputEnabled { get; set; }

        [NameInMap("VideoOutputOssBucket")]
        [Validation(Required=false)]
        public string VideoOutputOssBucket { get; set; }

        [NameInMap("VideoOutputOssPath")]
        [Validation(Required=false)]
        public string VideoOutputOssPath { get; set; }

    }

}
