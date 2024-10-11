// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetDevObjectDependencyResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DevObjectDependencyList")]
        [Validation(Required=false)]
        public List<GetDevObjectDependencyResponseBodyDevObjectDependencyList> DevObjectDependencyList { get; set; }
        public class GetDevObjectDependencyResponseBodyDevObjectDependencyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoParse")]
            [Validation(Required=false)]
            public bool? AutoParse { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SCRIPT</para>
            /// </summary>
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13111</para>
            /// </summary>
            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public string BizUnitId { get; set; }

            [NameInMap("BizUnitName")]
            [Validation(Required=false)]
            public string BizUnitName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0 0 0 * * ?</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CustomCronExpression")]
            [Validation(Required=false)]
            public bool? CustomCronExpression { get; set; }

            [NameInMap("DependFieldList")]
            [Validation(Required=false)]
            public List<string> DependFieldList { get; set; }

            [NameInMap("DependencyPeriod")]
            [Validation(Required=false)]
            public GetDevObjectDependencyResponseBodyDevObjectDependencyListDependencyPeriod DependencyPeriod { get; set; }
            public class GetDevObjectDependencyResponseBodyDevObjectDependencyListDependencyPeriod : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PeriodOffset")]
                [Validation(Required=false)]
                public int? PeriodOffset { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CURRENT_PERIOD</para>
                /// </summary>
                [NameInMap("PeriodType")]
                [Validation(Required=false)]
                public string PeriodType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("DependencyStrategy")]
            [Validation(Required=false)]
            public string DependencyStrategy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DimMidNode")]
            [Validation(Required=false)]
            public bool? DimMidNode { get; set; }

            [NameInMap("EffectFieldList")]
            [Validation(Required=false)]
            public List<string> EffectFieldList { get; set; }

            [NameInMap("ExternalBizInfo")]
            [Validation(Required=false)]
            public string ExternalBizInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ManuallyAdd")]
            [Validation(Required=false)]
            public bool? ManuallyAdd { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>n_13211</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>n_xx</para>
            /// </summary>
            [NameInMap("NodeOutputName")]
            [Validation(Required=false)]
            public string NodeOutputName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t_xx</para>
            /// </summary>
            [NameInMap("NodeOutputTableName")]
            [Validation(Required=false)]
            public string NodeOutputTableName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DATA_PROCESS</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            [NameInMap("OutputContextParamList")]
            [Validation(Required=false)]
            public List<GetDevObjectDependencyResponseBodyDevObjectDependencyListOutputContextParamList> OutputContextParamList { get; set; }
            public class GetDevObjectDependencyResponseBodyDevObjectDependencyListOutputContextParamList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxtest</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            [NameInMap("OwnerList")]
            [Validation(Required=false)]
            public List<GetDevObjectDependencyResponseBodyDevObjectDependencyListOwnerList> OwnerList { get; set; }
            public class GetDevObjectDependencyResponseBodyDevObjectDependencyListOwnerList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>11123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PeriodDiff")]
            [Validation(Required=false)]
            public int? PeriodDiff { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123131</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SelfDepend")]
            [Validation(Required=false)]
            public bool? SelfDepend { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SHELL</para>
            /// </summary>
            [NameInMap("SubBizType")]
            [Validation(Required=false)]
            public string SubBizType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Valid")]
            [Validation(Required=false)]
            public bool? Valid { get; set; }

        }

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
