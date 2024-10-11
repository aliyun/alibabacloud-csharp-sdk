// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetPhysicalInstanceResponseBody : TeaModel {
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

        [NameInMap("Instance")]
        [Validation(Required=false)]
        public GetPhysicalInstanceResponseBodyInstance Instance { get; set; }
        public class GetPhysicalInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-25</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-27 00:30:00</para>
            /// </summary>
            [NameInMap("DueTime")]
            [Validation(Required=false)]
            public string DueTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3600s</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-27 02:30:00</para>
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
            public GetPhysicalInstanceResponseBodyInstanceNodeInfo NodeInfo { get; set; }
            public class GetPhysicalInstanceResponseBodyInstanceNodeInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("BizUnitName")]
                [Validation(Required=false)]
                public string BizUnitName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-02-02 23:53:17</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public GetPhysicalInstanceResponseBodyInstanceNodeInfoCreator Creator { get; set; }
                public class GetPhysicalInstanceResponseBodyInstanceNodeInfoCreator : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2323111</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>zhangsan</para>
                    /// </summary>
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
                /// <para>n_3232312</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-02-02 23:53:17</para>
                /// </summary>
                [NameInMap("LastModifiedTime")]
                [Validation(Required=false)]
                public string LastModifiedTime { get; set; }

                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public GetPhysicalInstanceResponseBodyInstanceNodeInfoModifier Modifier { get; set; }
                public class GetPhysicalInstanceResponseBodyInstanceNodeInfoModifier : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2323111</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>zhangsan</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OwnerList")]
                [Validation(Required=false)]
                public List<GetPhysicalInstanceResponseBodyInstanceNodeInfoOwnerList> OwnerList { get; set; }
                public class GetPhysicalInstanceResponseBodyInstanceNodeInfoOwnerList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2323111</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>zhangsan</para>
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
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-27 01:30:00</para>
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
