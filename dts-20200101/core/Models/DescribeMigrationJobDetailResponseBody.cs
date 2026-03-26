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
        /// <para>Specifies whether to query the details of incremental data migration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: yes</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: no</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>false</b></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the details of full data migration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: yes</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: no</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>false</b></para>
        /// </remarks>
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
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
