// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetSupplementDagrunInstanceResponseBody : TeaModel {
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

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<GetSupplementDagrunInstanceResponseBodyInstanceList> InstanceList { get; set; }
        public class GetSupplementDagrunInstanceResponseBodyInstanceList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-04-01</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public long? BizDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-04-02</para>
            /// </summary>
            [NameInMap("DueTime")]
            [Validation(Required=false)]
            public long? DueTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-04-12 00:25:02</para>
            /// </summary>
            [NameInMap("EndExecuteTime")]
            [Validation(Required=false)]
            public long? EndExecuteTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;a&quot;:&quot;b&quot;}</para>
            /// </summary>
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t_239496_20210411_246982077481</para>
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
            public GetSupplementDagrunInstanceResponseBodyInstanceListNodeInfo NodeInfo { get; set; }
            public class GetSupplementDagrunInstanceResponseBodyInstanceListNodeInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("BizUnitName")]
                [Validation(Required=false)]
                public string BizUnitName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-30 10:08:49</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public GetSupplementDagrunInstanceResponseBodyInstanceListNodeInfoCreator Creator { get; set; }
                public class GetSupplementDagrunInstanceResponseBodyInstanceListNodeInfoCreator : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1001012</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xx测试</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DryRun")]
                [Validation(Required=false)]
                public bool? DryRun { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("From")]
                [Validation(Required=false)]
                public string From { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
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
                /// <para>n_239496</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-30 10:08:49</para>
                /// </summary>
                [NameInMap("LastModifiedTime")]
                [Validation(Required=false)]
                public string LastModifiedTime { get; set; }

                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public GetSupplementDagrunInstanceResponseBodyInstanceListNodeInfoModifier Modifier { get; set; }
                public class GetSupplementDagrunInstanceResponseBodyInstanceListNodeInfoModifier : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1001012</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xx测试</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OwnerList")]
                [Validation(Required=false)]
                public List<GetSupplementDagrunInstanceResponseBodyInstanceListNodeInfoOwnerList> OwnerList { get; set; }
                public class GetSupplementDagrunInstanceResponseBodyInstanceListNodeInfoOwnerList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1001012</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xx测试</para>
                    /// </summary>
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
                /// <para>true</para>
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
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-04-12 00:00:00</para>
            /// </summary>
            [NameInMap("StartExecuteTime")]
            [Validation(Required=false)]
            public long? StartExecuteTime { get; set; }

            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUPPLEMENT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
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
