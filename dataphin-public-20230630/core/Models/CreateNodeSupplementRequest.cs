// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateNodeSupplementRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateNodeSupplementRequestCreateCommand CreateCommand { get; set; }
        public class CreateNodeSupplementRequestCreateCommand : TeaModel {
            [NameInMap("ContainAllDownStream")]
            [Validation(Required=false)]
            public bool? ContainAllDownStream { get; set; }

            [NameInMap("DownStreamNodeIdList")]
            [Validation(Required=false)]
            public List<CreateNodeSupplementRequestCreateCommandDownStreamNodeIdList> DownStreamNodeIdList { get; set; }
            public class CreateNodeSupplementRequestCreateCommandDownStreamNodeIdList : TeaModel {
                [NameInMap("FieldIdList")]
                [Validation(Required=false)]
                public List<string> FieldIdList { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-01</para>
            /// </summary>
            [NameInMap("EndBizDate")]
            [Validation(Required=false)]
            public string EndBizDate { get; set; }

            [NameInMap("FilterList")]
            [Validation(Required=false)]
            public List<CreateNodeSupplementRequestCreateCommandFilterList> FilterList { get; set; }
            public class CreateNodeSupplementRequestCreateCommandFilterList : TeaModel {
                [NameInMap("Exclude")]
                [Validation(Required=false)]
                public bool? Exclude { get; set; }

                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("ValueList")]
                [Validation(Required=false)]
                public List<string> ValueList { get; set; }

            }

            [NameInMap("GlobalParamList")]
            [Validation(Required=false)]
            public List<CreateNodeSupplementRequestCreateCommandGlobalParamList> GlobalParamList { get; set; }
            public class CreateNodeSupplementRequestCreateCommandGlobalParamList : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("MaxDueTime")]
            [Validation(Required=false)]
            public string MaxDueTime { get; set; }

            [NameInMap("MinDueTime")]
            [Validation(Required=false)]
            public string MinDueTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx测试</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("NodeIdList")]
            [Validation(Required=false)]
            public List<CreateNodeSupplementRequestCreateCommandNodeIdList> NodeIdList { get; set; }
            public class CreateNodeSupplementRequestCreateCommandNodeIdList : TeaModel {
                [NameInMap("FieldIdList")]
                [Validation(Required=false)]
                public List<string> FieldIdList { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            [NameInMap("NodeParamsList")]
            [Validation(Required=false)]
            public List<CreateNodeSupplementRequestCreateCommandNodeParamsList> NodeParamsList { get; set; }
            public class CreateNodeSupplementRequestCreateCommandNodeParamsList : TeaModel {
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("ParamList")]
                [Validation(Required=false)]
                public List<CreateNodeSupplementRequestCreateCommandNodeParamsListParamList> ParamList { get; set; }
                public class CreateNodeSupplementRequestCreateCommandNodeParamsListParamList : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("Parallelism")]
            [Validation(Required=false)]
            public int? Parallelism { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101121</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-01</para>
            /// </summary>
            [NameInMap("StartBizDate")]
            [Validation(Required=false)]
            public string StartBizDate { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DEV/PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
