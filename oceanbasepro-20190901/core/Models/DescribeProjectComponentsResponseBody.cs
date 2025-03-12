// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeProjectComponentsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Contact the administrator.</para>
        /// </summary>
        [NameInMap("Advice")]
        [Validation(Required=false)]
        public string Advice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INNER_ERROR</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>48</para>
        /// </summary>
        [NameInMap("Cost")]
        [Validation(Required=false)]
        public string Cost { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeProjectComponentsResponseBodyData Data { get; set; }
        public class DescribeProjectComponentsResponseBodyData : TeaModel {
            [NameInMap("FullImportComponents")]
            [Validation(Required=false)]
            public List<DescribeProjectComponentsResponseBodyDataFullImportComponents> FullImportComponents { get; set; }
            public class DescribeProjectComponentsResponseBodyDataFullImportComponents : TeaModel {
                [NameInMap("ErrorDetails")]
                [Validation(Required=false)]
                public List<DescribeProjectComponentsResponseBodyDataFullImportComponentsErrorDetails> ErrorDetails { get; set; }
                public class DescribeProjectComponentsResponseBodyDataFullImportComponentsErrorDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CM-RESOAT1111</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("ExtraContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtraContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ERROR</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>A system error occurred.</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("MessageMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> MessageMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("MessageMcmsKey")]
                    [Validation(Required=false)]
                    public string MessageMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Proposal")]
                    [Validation(Required=false)]
                    public string Proposal { get; set; }

                    [NameInMap("ProposalMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ProposalMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("ProposalMcmsKey")]
                    [Validation(Required=false)]
                    public string ProposalMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    [NameInMap("ReasonMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ReasonMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("ReasonMcmsKey")]
                    [Validation(Required=false)]
                    public string ReasonMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("UpstreamErrorDetail")]
                    [Validation(Required=false)]
                    public object UpstreamErrorDetail { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-13T18:04:36</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-13T18:04:36</para>
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>p_4w8v****</para>
                /// </summary>
                [NameInMap("Identity")]
                [Validation(Required=false)]
                public string Identity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.xxx.xxx.1</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.xxx.xxx.1-9000:connector_v2:np_4w8v****c-full_trans-1-0:0000000276</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("FullVerifyComponents")]
            [Validation(Required=false)]
            public List<DescribeProjectComponentsResponseBodyDataFullVerifyComponents> FullVerifyComponents { get; set; }
            public class DescribeProjectComponentsResponseBodyDataFullVerifyComponents : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ConsistentQuantity")]
                [Validation(Required=false)]
                public long? ConsistentQuantity { get; set; }

                [NameInMap("ErrorDetails")]
                [Validation(Required=false)]
                public List<DescribeProjectComponentsResponseBodyDataFullVerifyComponentsErrorDetails> ErrorDetails { get; set; }
                public class DescribeProjectComponentsResponseBodyDataFullVerifyComponentsErrorDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CM-RESOAT1111</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("ExtraContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtraContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ERROR</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>A system error occurred.</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("MessageMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> MessageMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("MessageMcmsKey")]
                    [Validation(Required=false)]
                    public string MessageMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Proposal")]
                    [Validation(Required=false)]
                    public string Proposal { get; set; }

                    [NameInMap("ProposalMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ProposalMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("ProposalMcmsKey")]
                    [Validation(Required=false)]
                    public string ProposalMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    [NameInMap("ReasonMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ReasonMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("ReasonMcmsKey")]
                    [Validation(Required=false)]
                    public string ReasonMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("UpstreamErrorDetail")]
                    [Validation(Required=false)]
                    public object UpstreamErrorDetail { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("InconsistentQuantity")]
                [Validation(Required=false)]
                public long? InconsistentQuantity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.xxx.xxx.1</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.xxx.xxx.1-9000:90247:0000000033</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("RecordProgress")]
                [Validation(Required=false)]
                public int? RecordProgress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1345***</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

            }

            [NameInMap("IncrSyncComponents")]
            [Validation(Required=false)]
            public List<DescribeProjectComponentsResponseBodyDataIncrSyncComponents> IncrSyncComponents { get; set; }
            public class DescribeProjectComponentsResponseBodyDataIncrSyncComponents : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-13T09:19:53</para>
                /// </summary>
                [NameInMap("Checkpoint")]
                [Validation(Required=false)]
                public string Checkpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1689250071</para>
                /// </summary>
                [NameInMap("CheckpointSampleTimestamp")]
                [Validation(Required=false)]
                public long? CheckpointSampleTimestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Delay")]
                [Validation(Required=false)]
                public long? Delay { get; set; }

                [NameInMap("ErrorDetails")]
                [Validation(Required=false)]
                public List<DescribeProjectComponentsResponseBodyDataIncrSyncComponentsErrorDetails> ErrorDetails { get; set; }
                public class DescribeProjectComponentsResponseBodyDataIncrSyncComponentsErrorDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CM-RESOAT1111</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("ExtraContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtraContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ERROR</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>A system error occurred.</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("MessageMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> MessageMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("MessageMcmsKey")]
                    [Validation(Required=false)]
                    public string MessageMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Proposal")]
                    [Validation(Required=false)]
                    public string Proposal { get; set; }

                    [NameInMap("ProposalMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ProposalMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("ProposalMcmsKey")]
                    [Validation(Required=false)]
                    public string ProposalMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    [NameInMap("ReasonMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ReasonMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("ReasonMcmsKey")]
                    [Validation(Required=false)]
                    public string ReasonMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("UpstreamErrorDetail")]
                    [Validation(Required=false)]
                    public object UpstreamErrorDetail { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-13T18:04:36</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-13T18:04:36</para>
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>np_4w***</para>
                /// </summary>
                [NameInMap("Identity")]
                [Validation(Required=false)]
                public string Identity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.xxx.xxx.1</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.xxx.xxx.1-9000:connector_v2:np_4w****jxc-incr_trans-1-0:0000000277</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-zhangjiakou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Subtopics")]
                [Validation(Required=false)]
                public List<string> Subtopics { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Tps")]
                [Validation(Required=false)]
                public long? Tps { get; set; }

            }

            [NameInMap("ReverseIncrSyncComponents")]
            [Validation(Required=false)]
            public List<DescribeProjectComponentsResponseBodyDataReverseIncrSyncComponents> ReverseIncrSyncComponents { get; set; }
            public class DescribeProjectComponentsResponseBodyDataReverseIncrSyncComponents : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-13T09:19:53</para>
                /// </summary>
                [NameInMap("Checkpoint")]
                [Validation(Required=false)]
                public string Checkpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1689250049</para>
                /// </summary>
                [NameInMap("CheckpointSampleTimestamp")]
                [Validation(Required=false)]
                public long? CheckpointSampleTimestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Delay")]
                [Validation(Required=false)]
                public long? Delay { get; set; }

                [NameInMap("ErrorDetails")]
                [Validation(Required=false)]
                public List<DescribeProjectComponentsResponseBodyDataReverseIncrSyncComponentsErrorDetails> ErrorDetails { get; set; }
                public class DescribeProjectComponentsResponseBodyDataReverseIncrSyncComponentsErrorDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CM-RESOAT1111</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("ExtraContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtraContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ERROR</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>A system error occurred.</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("MessageMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> MessageMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("MessageMcmsKey")]
                    [Validation(Required=false)]
                    public string MessageMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Proposal")]
                    [Validation(Required=false)]
                    public string Proposal { get; set; }

                    [NameInMap("ProposalMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ProposalMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("ProposalMcmsKey")]
                    [Validation(Required=false)]
                    public string ProposalMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    [NameInMap("ReasonMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ReasonMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("ReasonMcmsKey")]
                    [Validation(Required=false)]
                    public string ReasonMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("UpstreamErrorDetail")]
                    [Validation(Required=false)]
                    public object UpstreamErrorDetail { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-13T18:04:36</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-13T18:04:36</para>
                /// </summary>
                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>np_4w8****</para>
                /// </summary>
                [NameInMap("Identity")]
                [Validation(Required=false)]
                public string Identity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.xxx.xxx.1</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.xxx.xxx.1-9000:connector_v2:np_4w8****9jxc-incr_trans-1-0:0000000277</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Subtopics")]
                [Validation(Required=false)]
                public List<string> Subtopics { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Tps")]
                [Validation(Required=false)]
                public long? Tps { get; set; }

            }

            [NameInMap("ReverseStoreList")]
            [Validation(Required=false)]
            public List<DescribeProjectComponentsResponseBodyDataReverseStoreList> ReverseStoreList { get; set; }
            public class DescribeProjectComponentsResponseBodyDataReverseStoreList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-13T09:19:53</para>
                /// </summary>
                [NameInMap("BeginCheckpoint")]
                [Validation(Required=false)]
                public string BeginCheckpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Conn")]
                [Validation(Required=false)]
                public long? Conn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Delay")]
                [Validation(Required=false)]
                public long? Delay { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-13T09:19:53</para>
                /// </summary>
                [NameInMap("EndCheckpoint")]
                [Validation(Required=false)]
                public string EndCheckpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                [NameInMap("ErrorDetails")]
                [Validation(Required=false)]
                public List<DescribeProjectComponentsResponseBodyDataReverseStoreListErrorDetails> ErrorDetails { get; set; }
                public class DescribeProjectComponentsResponseBodyDataReverseStoreListErrorDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CM-RESOAT1111</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("ExtraContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtraContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ERROR</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>A system error occurred.</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("MessageMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> MessageMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("MessageMcmsKey")]
                    [Validation(Required=false)]
                    public string MessageMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Proposal")]
                    [Validation(Required=false)]
                    public string Proposal { get; set; }

                    [NameInMap("ProposalMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ProposalMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("ProposalMcmsKey")]
                    [Validation(Required=false)]
                    public string ProposalMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    [NameInMap("ReasonMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ReasonMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("ReasonMcmsKey")]
                    [Validation(Required=false)]
                    public string ReasonMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("UpstreamErrorDetail")]
                    [Validation(Required=false)]
                    public object UpstreamErrorDetail { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1689250071</para>
                /// </summary>
                [NameInMap("Gmt")]
                [Validation(Required=false)]
                public long? Gmt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-13T18:04:36</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-13T18:04:36</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.xxx.xxx.1</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1689250071</para>
                /// </summary>
                [NameInMap("LatelyHeartbeatTimeSec")]
                [Validation(Required=false)]
                public long? LatelyHeartbeatTimeSec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.xxx.xxx.1-9000:connector_v2:np_4w****9jxc-incr_trans-1-0:0000000277</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2883</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shenzhen</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EXCEPTION</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2882</para>
                /// </summary>
                [NameInMap("StorePort")]
                [Validation(Required=false)]
                public int? StorePort { get; set; }

                /// <summary>
                /// <para>SubTopic。</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Subtopic")]
                [Validation(Required=false)]
                public string Subtopic { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ToSwitch")]
                [Validation(Required=false)]
                public bool? ToSwitch { get; set; }

                /// <summary>
                /// <para>Topic。</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Tps")]
                [Validation(Required=false)]
                public long? Tps { get; set; }

            }

            [NameInMap("StoreList")]
            [Validation(Required=false)]
            public List<DescribeProjectComponentsResponseBodyDataStoreList> StoreList { get; set; }
            public class DescribeProjectComponentsResponseBodyDataStoreList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-13T09:19:53</para>
                /// </summary>
                [NameInMap("BeginCheckpoint")]
                [Validation(Required=false)]
                public string BeginCheckpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Conn")]
                [Validation(Required=false)]
                public long? Conn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("Delay")]
                [Validation(Required=false)]
                public long? Delay { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-13T09:19:53</para>
                /// </summary>
                [NameInMap("EndCheckpoint")]
                [Validation(Required=false)]
                public string EndCheckpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ErrMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                [NameInMap("ErrorDetails")]
                [Validation(Required=false)]
                public List<DescribeProjectComponentsResponseBodyDataStoreListErrorDetails> ErrorDetails { get; set; }
                public class DescribeProjectComponentsResponseBodyDataStoreListErrorDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CM-RESOAT1111</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("ExtraContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtraContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ERROR</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>A system error occurred.</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("MessageMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> MessageMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("MessageMcmsKey")]
                    [Validation(Required=false)]
                    public string MessageMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Proposal")]
                    [Validation(Required=false)]
                    public string Proposal { get; set; }

                    [NameInMap("ProposalMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ProposalMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("ProposalMcmsKey")]
                    [Validation(Required=false)]
                    public string ProposalMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public string Reason { get; set; }

                    [NameInMap("ReasonMcmsContext")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> ReasonMcmsContext { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("ReasonMcmsKey")]
                    [Validation(Required=false)]
                    public string ReasonMcmsKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("UpstreamErrorDetail")]
                    [Validation(Required=false)]
                    public object UpstreamErrorDetail { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1689250049</para>
                /// </summary>
                [NameInMap("Gmt")]
                [Validation(Required=false)]
                public long? Gmt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-13T17:29:54</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-13T17:29:54</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.xxx.xxx.1</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1689250071</para>
                /// </summary>
                [NameInMap("LatelyHeartbeatTimeSec")]
                [Validation(Required=false)]
                public long? LatelyHeartbeatTimeSec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx.xxx.xxx.1-7145:OB_ORACLE_np_4w3r***_4w:0000***97</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2883</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EXCEPTION</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2882</para>
                /// </summary>
                [NameInMap("StorePort")]
                [Validation(Required=false)]
                public int? StorePort { get; set; }

                /// <summary>
                /// <para>SubTopic。</para>
                /// 
                /// <b>Example:</b>
                /// <para>OB_ORACLE_np_4w3*<b>c_4w3</b>-0</para>
                /// </summary>
                [NameInMap("Subtopic")]
                [Validation(Required=false)]
                public string Subtopic { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ToSwitch")]
                [Validation(Required=false)]
                public bool? ToSwitch { get; set; }

                /// <summary>
                /// <para>Topic。</para>
                /// 
                /// <b>Example:</b>
                /// <para>OB_ORACLE_np_4w3r29c_4w3****</para>
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Tps")]
                [Validation(Required=false)]
                public long? Tps { get; set; }

            }

        }

        [NameInMap("ErrorDetail")]
        [Validation(Required=false)]
        public DescribeProjectComponentsResponseBodyErrorDetail ErrorDetail { get; set; }
        public class DescribeProjectComponentsResponseBodyErrorDetail : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CM-RESOAT1111</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("ExtraContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ERROR</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>A system error occurred.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("MessageMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> MessageMcmsContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("MessageMcmsKey")]
            [Validation(Required=false)]
            public string MessageMcmsKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Proposal")]
            [Validation(Required=false)]
            public string Proposal { get; set; }

            [NameInMap("ProposalMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> ProposalMcmsContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ProposalMcmsKey")]
            [Validation(Required=false)]
            public string ProposalMcmsKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("ReasonMcmsContext")]
            [Validation(Required=false)]
            public Dictionary<string, string> ReasonMcmsContext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ReasonMcmsKey")]
            [Validation(Required=false)]
            public string ReasonMcmsKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("UpstreamErrorDetail")]
            [Validation(Required=false)]
            public object UpstreamErrorDetail { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A system error occurred.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
