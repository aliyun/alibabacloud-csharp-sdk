// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class SearchManualDagNodeInstanceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchManualDagNodeInstanceResponseBodyData Data { get; set; }
        public class SearchManualDagNodeInstanceResponseBodyData : TeaModel {
            [NameInMap("NodeInsInfo")]
            [Validation(Required=false)]
            public List<SearchManualDagNodeInstanceResponseBodyDataNodeInsInfo> NodeInsInfo { get; set; }
            public class SearchManualDagNodeInstanceResponseBodyDataNodeInsInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-12-12 00:00:00</para>
                /// </summary>
                [NameInMap("BeginRunningTime")]
                [Validation(Required=false)]
                public string BeginRunningTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-12-12 00:00:00</para>
                /// </summary>
                [NameInMap("BeginWaitResTime")]
                [Validation(Required=false)]
                public string BeginWaitResTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-12-12 00:00:00</para>
                /// </summary>
                [NameInMap("BeginWaitTimeTime")]
                [Validation(Required=false)]
                public string BeginWaitTimeTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-12-12 00:00:00</para>
                /// </summary>
                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public string Bizdate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-12-12 00:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12434232423</para>
                /// </summary>
                [NameInMap("DagId")]
                [Validation(Required=false)]
                public long? DagId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("DagType")]
                [Validation(Required=false)]
                public int? DagType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-12-12 00:00:00</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12322434112</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-12-12 00:00:00</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test_node</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>param_k1=param_v1</para>
                /// </summary>
                [NameInMap("ParaValue")]
                [Validation(Required=false)]
                public string ParaValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2d9ced66-38ef-4923-baf6-391dd3a7e656</para>
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
