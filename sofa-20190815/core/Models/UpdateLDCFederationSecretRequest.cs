// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLDCFederationSecretRequest : TeaModel {
        [NameInMap("CellsRepeatList")]
        [Validation(Required=false)]
        public List<string> CellsRepeatList { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<UpdateLDCFederationSecretRequestData> Data { get; set; }
        public class UpdateLDCFederationSecretRequestData : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<UpdateLDCFederationSecretRequestLabels> Labels { get; set; }
        public class UpdateLDCFederationSecretRequestLabels : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("OverridesJsonStr")]
        [Validation(Required=false)]
        public string OverridesJsonStr { get; set; }

        [NameInMap("WorkspaceGroupName")]
        [Validation(Required=false)]
        public string WorkspaceGroupName { get; set; }

    }

}
