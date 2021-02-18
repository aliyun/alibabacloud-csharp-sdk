// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeInitializationStatusResponseBody : TeaModel {
        [NameInMap("StructureInitializationDetails")]
        [Validation(Required=false)]
        public List<DescribeInitializationStatusResponseBodyStructureInitializationDetails> StructureInitializationDetails { get; set; }
        public class DescribeInitializationStatusResponseBodyStructureInitializationDetails : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SourceOwnerDBName")]
            [Validation(Required=false)]
            public string SourceOwnerDBName { get; set; }

            [NameInMap("ObjectDefinition")]
            [Validation(Required=false)]
            public string ObjectDefinition { get; set; }

            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public List<DescribeInitializationStatusResponseBodyStructureInitializationDetailsConstraints> Constraints { get; set; }
            public class DescribeInitializationStatusResponseBodyStructureInitializationDetailsConstraints : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SourceOwnerDBName")]
                [Validation(Required=false)]
                public string SourceOwnerDBName { get; set; }

                [NameInMap("ObjectDefinition")]
                [Validation(Required=false)]
                public string ObjectDefinition { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("DestinationOwnerDBName")]
                [Validation(Required=false)]
                public string DestinationOwnerDBName { get; set; }

                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

            }

            [NameInMap("DestinationOwnerDBName")]
            [Validation(Required=false)]
            public string DestinationOwnerDBName { get; set; }

            [NameInMap("ObjectName")]
            [Validation(Required=false)]
            public string ObjectName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DataInitializationDetails")]
        [Validation(Required=false)]
        public List<DescribeInitializationStatusResponseBodyDataInitializationDetails> DataInitializationDetails { get; set; }
        public class DescribeInitializationStatusResponseBodyDataInitializationDetails : TeaModel {
            [NameInMap("SourceOwnerDBName")]
            [Validation(Required=false)]
            public string SourceOwnerDBName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UsedTime")]
            [Validation(Required=false)]
            public string UsedTime { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("FinishRowNum")]
            [Validation(Required=false)]
            public string FinishRowNum { get; set; }

            [NameInMap("DestinationOwnerDBName")]
            [Validation(Required=false)]
            public string DestinationOwnerDBName { get; set; }

            [NameInMap("TotalRowNum")]
            [Validation(Required=false)]
            public string TotalRowNum { get; set; }

        }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("DataSynchronizationDetails")]
        [Validation(Required=false)]
        public List<DescribeInitializationStatusResponseBodyDataSynchronizationDetails> DataSynchronizationDetails { get; set; }
        public class DescribeInitializationStatusResponseBodyDataSynchronizationDetails : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SourceOwnerDBName")]
            [Validation(Required=false)]
            public string SourceOwnerDBName { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("DestinationOwnerDBName")]
            [Validation(Required=false)]
            public string DestinationOwnerDBName { get; set; }

        }

    }

}
