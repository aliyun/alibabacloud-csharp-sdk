// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeMigrationJobDetailResponseBody : TeaModel {
        [NameInMap("DataInitializationDetailList")]
        [Validation(Required=false)]
        public DescribeMigrationJobDetailResponseBodyDataInitializationDetailList DataInitializationDetailList { get; set; }
        public class DescribeMigrationJobDetailResponseBodyDataInitializationDetailList : TeaModel {
            [NameInMap("DataInitializationDetail")]
            [Validation(Required=false)]
            public List<DescribeMigrationJobDetailResponseBodyDataInitializationDetailListDataInitializationDetail> DataInitializationDetail { get; set; }
            public class DescribeMigrationJobDetailResponseBodyDataInitializationDetailListDataInitializationDetail : TeaModel {
                [NameInMap("DestinationOwnerDBName")]
                [Validation(Required=false)]
                public string DestinationOwnerDBName { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("FinishRowNum")]
                [Validation(Required=false)]
                public string FinishRowNum { get; set; }

                [NameInMap("MigrationTime")]
                [Validation(Required=false)]
                public string MigrationTime { get; set; }

                [NameInMap("SourceOwnerDBName")]
                [Validation(Required=false)]
                public string SourceOwnerDBName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("TotalRowNum")]
                [Validation(Required=false)]
                public string TotalRowNum { get; set; }

            }

        }

        [NameInMap("DataSynchronizationDetailList")]
        [Validation(Required=false)]
        public DescribeMigrationJobDetailResponseBodyDataSynchronizationDetailList DataSynchronizationDetailList { get; set; }
        public class DescribeMigrationJobDetailResponseBodyDataSynchronizationDetailList : TeaModel {
            [NameInMap("DataSynchronizationDetail")]
            [Validation(Required=false)]
            public List<DescribeMigrationJobDetailResponseBodyDataSynchronizationDetailListDataSynchronizationDetail> DataSynchronizationDetail { get; set; }
            public class DescribeMigrationJobDetailResponseBodyDataSynchronizationDetailListDataSynchronizationDetail : TeaModel {
                [NameInMap("DestinationOwnerDBName")]
                [Validation(Required=false)]
                public string DestinationOwnerDBName { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("SourceOwnerDBName")]
                [Validation(Required=false)]
                public string SourceOwnerDBName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of migration instances that can be displayed on one page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AE3CD0B-4148-426F-A90E-952467CC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StructureInitializationDetailList")]
        [Validation(Required=false)]
        public DescribeMigrationJobDetailResponseBodyStructureInitializationDetailList StructureInitializationDetailList { get; set; }
        public class DescribeMigrationJobDetailResponseBodyStructureInitializationDetailList : TeaModel {
            [NameInMap("StructureInitializationDetail")]
            [Validation(Required=false)]
            public List<DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetail> StructureInitializationDetail { get; set; }
            public class DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetail : TeaModel {
                [NameInMap("ConstraintList")]
                [Validation(Required=false)]
                public DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetailConstraintList ConstraintList { get; set; }
                public class DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetailConstraintList : TeaModel {
                    [NameInMap("StructureInitializationDetail")]
                    [Validation(Required=false)]
                    public List<DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetailConstraintListStructureInitializationDetail> StructureInitializationDetail { get; set; }
                    public class DescribeMigrationJobDetailResponseBodyStructureInitializationDetailListStructureInitializationDetailConstraintListStructureInitializationDetail : TeaModel {
                        [NameInMap("DestinationOwnerDBName")]
                        [Validation(Required=false)]
                        public string DestinationOwnerDBName { get; set; }

                        [NameInMap("ErrorMessage")]
                        [Validation(Required=false)]
                        public string ErrorMessage { get; set; }

                        [NameInMap("ObjectDefinition")]
                        [Validation(Required=false)]
                        public string ObjectDefinition { get; set; }

                        [NameInMap("ObjectName")]
                        [Validation(Required=false)]
                        public string ObjectName { get; set; }

                        [NameInMap("ObjectType")]
                        [Validation(Required=false)]
                        public string ObjectType { get; set; }

                        [NameInMap("SourceOwnerDBName")]
                        [Validation(Required=false)]
                        public string SourceOwnerDBName { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                [NameInMap("DestinationOwnerDBName")]
                [Validation(Required=false)]
                public string DestinationOwnerDBName { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("ObjectDefinition")]
                [Validation(Required=false)]
                public string ObjectDefinition { get; set; }

                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

                [NameInMap("SourceOwnerDBName")]
                [Validation(Required=false)]
                public string SourceOwnerDBName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
