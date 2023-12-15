// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeChaincodeDefinitionTaskResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeChaincodeDefinitionTaskResponseBodyResult Result { get; set; }
        public class DescribeChaincodeDefinitionTaskResponseBodyResult : TeaModel {
            [NameInMap("Approvers")]
            [Validation(Required=false)]
            public List<string> Approvers { get; set; }

            [NameInMap("ChannelName")]
            [Validation(Required=false)]
            public string ChannelName { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public DescribeChaincodeDefinitionTaskResponseBodyResultContent Content { get; set; }
            public class DescribeChaincodeDefinitionTaskResponseBodyResultContent : TeaModel {
                [NameInMap("ChaincodeDefinition")]
                [Validation(Required=false)]
                public DescribeChaincodeDefinitionTaskResponseBodyResultContentChaincodeDefinition ChaincodeDefinition { get; set; }
                public class DescribeChaincodeDefinitionTaskResponseBodyResultContentChaincodeDefinition : TeaModel {
                    [NameInMap("ChaincodePackageId")]
                    [Validation(Required=false)]
                    public string ChaincodePackageId { get; set; }

                    [NameInMap("CollectionConfig")]
                    [Validation(Required=false)]
                    public string CollectionConfig { get; set; }

                    [NameInMap("EndorsementPolicy")]
                    [Validation(Required=false)]
                    public string EndorsementPolicy { get; set; }

                    [NameInMap("InitRequired")]
                    [Validation(Required=false)]
                    public bool? InitRequired { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Sequence")]
                    [Validation(Required=false)]
                    public long? Sequence { get; set; }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
