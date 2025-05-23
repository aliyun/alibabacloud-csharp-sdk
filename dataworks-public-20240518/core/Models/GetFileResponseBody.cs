// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetFileResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileResponseBodyData Data { get; set; }
        public class GetFileResponseBodyData : TeaModel {
            [NameInMap("File")]
            [Validation(Required=false)]
            public GetFileResponseBodyDataFile File { get; set; }
            public class GetFileResponseBodyDataFile : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{\&quot;priority\&quot;:\&quot;1\&quot;,\&quot;ENABLE_SPARKSQL_JDBC\&quot;:false,\&quot;FLOW_SKIP_SQL_ANALYZE\&quot;:false,\&quot;queue\&quot;:\&quot;default\&quot;}</para>
                /// </summary>
                [NameInMap("AdvancedSettings")]
                [Validation(Required=false)]
                public string AdvancedSettings { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoParsing")]
                [Validation(Required=false)]
                public bool? AutoParsing { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000001</para>
                /// </summary>
                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000001</para>
                /// </summary>
                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public long? BusinessId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CommitStatus")]
                [Validation(Required=false)]
                public int? CommitStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>odps_source</para>
                /// </summary>
                [NameInMap("ConnectionName")]
                [Validation(Required=false)]
                public string ConnectionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SHOW TABLES;</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1593879116000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>424732****</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public int? CurrentVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RECYCLE</para>
                /// </summary>
                [NameInMap("DeletedStatus")]
                [Validation(Required=false)]
                public string DeletedStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>My first DataWorks file</para>
                /// </summary>
                [NameInMap("FileDescription")]
                [Validation(Required=false)]
                public string FileDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2735c2****</para>
                /// </summary>
                [NameInMap("FileFolderId")]
                [Validation(Required=false)]
                public string FileFolderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100000001</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ods_user_info_d</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public int? FileType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsMaxCompute")]
                [Validation(Required=false)]
                public bool? IsMaxCompute { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1593879116000</para>
                /// </summary>
                [NameInMap("LastEditTime")]
                [Validation(Required=false)]
                public long? LastEditTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>424732****</para>
                /// </summary>
                [NameInMap("LastEditUser")]
                [Validation(Required=false)]
                public string LastEditUser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>300001</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7775674356****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("UseType")]
                [Validation(Required=false)]
                public string UseType { get; set; }

            }

            [NameInMap("NodeConfiguration")]
            [Validation(Required=false)]
            public GetFileResponseBodyDataNodeConfiguration NodeConfiguration { get; set; }
            public class GetFileResponseBodyDataNodeConfiguration : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ApplyScheduleImmediately")]
                [Validation(Required=false)]
                public string ApplyScheduleImmediately { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>120000</para>
                /// </summary>
                [NameInMap("AutoRerunIntervalMillis")]
                [Validation(Required=false)]
                public int? AutoRerunIntervalMillis { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AutoRerunTimes")]
                [Validation(Required=false)]
                public int? AutoRerunTimes { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>00 05 00 * * ?</para>
                /// </summary>
                [NameInMap("CronExpress")]
                [Validation(Required=false)]
                public string CronExpress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DAY</para>
                /// </summary>
                [NameInMap("CycleType")]
                [Validation(Required=false)]
                public string CycleType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5,10,15,20</para>
                /// </summary>
                [NameInMap("DependentNodeIdList")]
                [Validation(Required=false)]
                public string DependentNodeIdList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>USER_DEFINE</para>
                /// </summary>
                [NameInMap("DependentType")]
                [Validation(Required=false)]
                public string DependentType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4155787800000</para>
                /// </summary>
                [NameInMap("EndEffectDate")]
                [Validation(Required=false)]
                public long? EndEffectDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IgnoreParentSkipRunningProperty")]
                [Validation(Required=false)]
                public string IgnoreParentSkipRunningProperty { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>m-bp1h4b5a8ogkbll2f3tr</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("InputList")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationInputList> InputList { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationInputList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>project.001_out</para>
                    /// </summary>
                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public string Input { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MANUAL</para>
                    /// </summary>
                    [NameInMap("ParseType")]
                    [Validation(Required=false)]
                    public string ParseType { get; set; }

                }

                [NameInMap("InputParameters")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationInputParameters> InputParameters { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationInputParameters : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>input</para>
                    /// </summary>
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public string ParameterName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>project_001.parent_node:outputs</para>
                    /// </summary>
                    [NameInMap("ValueSource")]
                    [Validation(Required=false)]
                    public string ValueSource { get; set; }

                }

                [NameInMap("OutputList")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationOutputList> OutputList { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationOutputList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dw_project.002_out</para>
                    /// </summary>
                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public string Output { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ods_user_info_d</para>
                    /// </summary>
                    [NameInMap("RefTableName")]
                    [Validation(Required=false)]
                    public string RefTableName { get; set; }

                }

                [NameInMap("OutputParameters")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationOutputParameters> OutputParameters { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationOutputParameters : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>It\&quot;s a context output parameter.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>output</para>
                    /// </summary>
                    [NameInMap("ParameterName")]
                    [Validation(Required=false)]
                    public string ParameterName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>${bizdate}</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>a=x b=y</para>
                /// </summary>
                [NameInMap("ParaValue")]
                [Validation(Required=false)]
                public string ParaValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ALL_ALLOWED</para>
                /// </summary>
                [NameInMap("RerunMode")]
                [Validation(Required=false)]
                public string RerunMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>375827434852437</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public long? ResourceGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>936923400000</para>
                /// </summary>
                [NameInMap("StartEffectDate")]
                [Validation(Required=false)]
                public long? StartEffectDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("StartImmediately")]
                [Validation(Required=false)]
                public bool? StartImmediately { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Stop")]
                [Validation(Required=false)]
                public bool? Stop { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

            }

            [NameInMap("ResourceDownloadLink")]
            [Validation(Required=false)]
            public GetFileResponseBodyDataResourceDownloadLink ResourceDownloadLink { get; set; }
            public class GetFileResponseBodyDataResourceDownloadLink : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://xx">http://xx</a></para>
                /// </summary>
                [NameInMap("downloadLink")]
                [Validation(Required=false)]
                public string DownloadLink { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The connection does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
