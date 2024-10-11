// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyPageResult PageResult { get; set; }
        public class ListInstancesResponseBodyPageResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyPageResultData> Data { get; set; }
            public class ListInstancesResponseBodyPageResultData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-30</para>
                /// </summary>
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public string BizDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-30 16:47:13</para>
                /// </summary>
                [NameInMap("DueTime")]
                [Validation(Required=false)]
                public string DueTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60s</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-30 16:47:13</para>
                /// </summary>
                [NameInMap("EndExecuteTime")]
                [Validation(Required=false)]
                public long? EndExecuteTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("ExtendInfo")]
                [Validation(Required=false)]
                public string ExtendInfo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>t_23231</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                [NameInMap("NodeInfo")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyPageResultDataNodeInfo NodeInfo { get; set; }
                public class ListInstancesResponseBodyPageResultDataNodeInfo : TeaModel {
                    [NameInMap("BizUnitName")]
                    [Validation(Required=false)]
                    public string BizUnitName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-05-30 16:47:13</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("Creator")]
                    [Validation(Required=false)]
                    public ListInstancesResponseBodyPageResultDataNodeInfoCreator Creator { get; set; }
                    public class ListInstancesResponseBodyPageResultDataNodeInfoCreator : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>21313112</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("DryRun")]
                    [Validation(Required=false)]
                    public bool? DryRun { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DATA_PROCES</para>
                    /// </summary>
                    [NameInMap("From")]
                    [Validation(Required=false)]
                    public string From { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("HasDev")]
                    [Validation(Required=false)]
                    public bool? HasDev { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("HasProd")]
                    [Validation(Required=false)]
                    public bool? HasProd { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>n_132331</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-05-30 16:47:13</para>
                    /// </summary>
                    [NameInMap("LastModifiedTime")]
                    [Validation(Required=false)]
                    public string LastModifiedTime { get; set; }

                    [NameInMap("Modifier")]
                    [Validation(Required=false)]
                    public ListInstancesResponseBodyPageResultDataNodeInfoModifier Modifier { get; set; }
                    public class ListInstancesResponseBodyPageResultDataNodeInfoModifier : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>21313112</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("OwnerList")]
                    [Validation(Required=false)]
                    public List<ListInstancesResponseBodyPageResultDataNodeInfoOwnerList> OwnerList { get; set; }
                    public class ListInstancesResponseBodyPageResultDataNodeInfoOwnerList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>21313112</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    [NameInMap("PriorityList")]
                    [Validation(Required=false)]
                    public List<string> PriorityList { get; set; }

                    [NameInMap("ResourceGroupList")]
                    [Validation(Required=false)]
                    public List<string> ResourceGroupList { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("SchedulePaused")]
                    [Validation(Required=false)]
                    public bool? SchedulePaused { get; set; }

                    [NameInMap("SchedulePeriodList")]
                    [Validation(Required=false)]
                    public List<string> SchedulePeriodList { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SHELL</para>
                    /// </summary>
                    [NameInMap("SubDetailType")]
                    [Validation(Required=false)]
                    public string SubDetailType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DATA_PROCES</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-30 16:46:13</para>
                /// </summary>
                [NameInMap("StartExecuteTime")]
                [Validation(Required=false)]
                public long? StartExecuteTime { get; set; }

                [NameInMap("StatusList")]
                [Validation(Required=false)]
                public List<string> StatusList { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>107</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
