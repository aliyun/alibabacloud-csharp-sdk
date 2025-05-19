// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateSampleConsistencyJobRequest : TeaModel {
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        [NameInMap("EasModelServiceName")]
        [Validation(Required=false)]
        public string EasModelServiceName { get; set; }

        [NameInMap("FeatureSaveResourceId")]
        [Validation(Required=false)]
        public string FeatureSaveResourceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ItemIdField")]
        [Validation(Required=false)]
        public string ItemIdField { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PartitionField")]
        [Validation(Required=false)]
        public string PartitionField { get; set; }

        [NameInMap("PartitionFieldFormat")]
        [Validation(Required=false)]
        public string PartitionFieldFormat { get; set; }

        [NameInMap("RequestIdField")]
        [Validation(Required=false)]
        public string RequestIdField { get; set; }

        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public string SampleRate { get; set; }

        [NameInMap("SampleTableName")]
        [Validation(Required=false)]
        public string SampleTableName { get; set; }

        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        [NameInMap("UserIdField")]
        [Validation(Required=false)]
        public string UserIdField { get; set; }

    }

}
