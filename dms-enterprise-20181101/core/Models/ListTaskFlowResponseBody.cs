// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTaskFlowResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4116147E-C628-5816-8779-8EEAF8E973F4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The information about the task flows returned.</para>
        /// </summary>
        [NameInMap("TaskFlowList")]
        [Validation(Required=false)]
        public ListTaskFlowResponseBodyTaskFlowList TaskFlowList { get; set; }
        public class ListTaskFlowResponseBodyTaskFlowList : TeaModel {
            [NameInMap("TaskFlow")]
            [Validation(Required=false)]
            public List<ListTaskFlowResponseBodyTaskFlowListTaskFlow> TaskFlow { get; set; }
            public class ListTaskFlowResponseBodyTaskFlowListTaskFlow : TeaModel {
                /// <summary>
                /// <para>The ID of the user who creates the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>51****</para>
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// <para>The name of the user who creates the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Creator_NickName</para>
                /// </summary>
                [NameInMap("CreatorNickName")]
                [Validation(Required=false)]
                public string CreatorNickName { get; set; }

                /// <summary>
                /// <para>The name of the task flow owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Owner_NickName</para>
                /// </summary>
                [NameInMap("DagOwnerNickName")]
                [Validation(Required=false)]
                public string DagOwnerNickName { get; set; }

                /// <summary>
                /// <para>The ID of the latest deployment record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12**</para>
                /// </summary>
                [NameInMap("DeployId")]
                [Validation(Required=false)]
                public long? DeployId { get; set; }

                /// <summary>
                /// <para>The ID of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>134137****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The status of the latest execution. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: invalid.</description></item>
                /// <item><description><b>1</b>: scheduling disabled.</description></item>
                /// <item><description><b>2</b>: waiting to be scheduled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LatestInstanceStatus")]
                [Validation(Required=false)]
                public int? LatestInstanceStatus { get; set; }

                /// <summary>
                /// <para>The time when the latest execution record was generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-13</para>
                /// </summary>
                [NameInMap("LatestInstanceTime")]
                [Validation(Required=false)]
                public string LatestInstanceTime { get; set; }

                /// <summary>
                /// <para>The status of the task flow. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The task flow is invalid.</description></item>
                /// <item><description><b>1</b>: Scheduling is disabled for the task flow.</description></item>
                /// <item><description><b>2</b>: The task flow is waiting to be scheduled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

    }

}
