// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeMigrationJobDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("DataInitializationDetailList")]
        [Validation(Required=false)]
        public DescribeMigrationJobDetailResponseBodyDataInitializationDetailList DataInitializationDetailList { get; set; }
        public class DescribeMigrationJobDetailResponseBodyDataInitializationDetailList : TeaModel {
            [NameInMap("DataInitializationDetail")]
            [Validation(Required=false)]
            public List<DescribeMigrationJobDetailResponseBodyDataInitializationDetailListDataInitializationDetail> DataInitializationDetail { get; set; }
            public class DescribeMigrationJobDetailResponseBodyDataInitializationDetailListDataInitializationDetail : TeaModel {
                public string SourceOwnerDBName { get; set; }
                public string Status { get; set; }
                public string TableName { get; set; }
                public string ErrorMessage { get; set; }
                public string FinishRowNum { get; set; }
                public string MigrationTime { get; set; }
                public string DestinationOwnerDBName { get; set; }
                public string TotalRowNum { get; set; }
            }
        };

        [NameInMap("DataSynchronizationDetailList")]
        [Validation(Required=false)]
        public DescribeMigrationJobDetailResponseBodyDataSynchronizationDetailList DataSynchronizationDetailList { get; set; }
        public class DescribeMigrationJobDetailResponseBodyDataSynchronizationDetailList : TeaModel {
            [NameInMap("DataSynchronizationDetail")]
            [Validation(Required=false)]
            public List<DescribeMigrationJobDetailResponseBodyDataSynchronizationDetailListDataSynchronizationDetail> DataSynchronizationDetail { get; set; }
            public class DescribeMigrationJobDetailResponseBodyDataSynchronizationDetailListDataSynchronizationDetail : TeaModel {
                public string Status { get; set; }
                public string SourceOwnerDBName { get; set; }
                public string TableName { get; set; }
                public string ErrorMessage { get; set; }
                public string DestinationOwnerDBName { get; set; }
            }
        };

        [NameInMap("StructureInitializationDetailList")]
        [Validation(Required=false)]
        public DescribeMigrationJobDetailResponseBodyStructureInitializationDetailList StructureInitializationDetailList { get; set; }
        public class DescribeMigrationJobDetailResponseBodyStructureInitializationDetailList : TeaModel {
            [NameInMap("StructureInitializationDetail")]
            [Validation(Required=false)]
            public List<DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetail> StructureInitializationDetail { get; set; }
            public class DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetail : TeaModel {
                public string Status { get; set; }
                public string SourceOwnerDBName { get; set; }
                public string ObjectDefinition { get; set; }
                public string ObjectType { get; set; }
                public string ErrorMessage { get; set; }
                public string DestinationOwnerDBName { get; set; }
                public string ObjectName { get; set; }
                public DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetailConstraintList ConstraintList { get; set; }
                public class DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetailConstraintList : TeaModel {
                    [NameInMap("StructureInitializationDetail")]
                    [Validation(Required=false)]
                    public List<DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetailConstraintListStructureInitializationDetail> StructureInitializationDetail { get; set; }
                    public class DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetailConstraintListStructureInitializationDetail : TeaModel {
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

                }
            }
        };

    }

}
