// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetQualityEntityResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetQualityEntityResponseBodyData> Data { get; set; }
        public class GetQualityEntityResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the partition expression was created.</para>
            /// <para>The value is a 13-digit number, for example, <c>1593964800000</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1593964800000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The level of the partition expression. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0 (SQL level): DQC verification is triggered after each SQL statement is executed.</description></item>
            /// <item><description>1 (Task level): Verification is performed after all SQL statements are executed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("EntityLevel")]
            [Validation(Required=false)]
            public int? EntityLevel { get; set; }

            /// <summary>
            /// <para>The type of the engine or data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The subscribers. The Alibaba Cloud account IDs that receive alert notifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1822931****</para>
            /// </summary>
            [NameInMap("Followers")]
            [Validation(Required=false)]
            public string Followers { get; set; }

            /// <summary>
            /// <para>Indicates whether the partition expression is associated with scheduling. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Associated with scheduling.</description></item>
            /// <item><description>false: Not associated with scheduling.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasRelativeNode")]
            [Validation(Required=false)]
            public bool? HasRelativeNode { get; set; }

            /// <summary>
            /// <para>The ID of the partition expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4003918</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The partition expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dt=$[yyyymmdd-1]</para>
            /// </summary>
            [NameInMap("MatchExpression")]
            [Validation(Required=false)]
            public string MatchExpression { get; set; }

            /// <summary>
            /// <para>The time when the partition expression was updated.</para>
            /// <para>The value is a 13-digit number, for example, <c>1593964800000</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1593964800000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The account ID of the user who updated the partition expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1822931****</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// <para>The owner. The account ID of the user who configured the partition expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1822931****</para>
            /// </summary>
            [NameInMap("OnDuty")]
            [Validation(Required=false)]
            public string OnDuty { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account name of the owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("OnDutyAccountName")]
            [Validation(Required=false)]
            public string OnDutyAccountName { get; set; }

            /// <summary>
            /// <para>The name of the engine or data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>autotest</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The information about the scheduling node associated with the partition expression, including:</para>
            /// <list type="bullet">
            /// <item><description>ProjectName: the name of the project to which the scheduling node belongs.</description></item>
            /// <item><description>NodeID: the node ID of the scheduling node.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;projectName&quot;:&quot;xc_DP****&quot;,&quot;nodeId&quot;:7000026****}]</para>
            /// </summary>
            [NameInMap("RelativeNode")]
            [Validation(Required=false)]
            public string RelativeNode { get; set; }

            /// <summary>
            /// <para>The SQL-level partition expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Sql")]
            [Validation(Required=false)]
            public int? Sql { get; set; }

            /// <summary>
            /// <para>The name of the partitioned table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_dqc_de****</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The task node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Task")]
            [Validation(Required=false)]
            public int? Task { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>401</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You have no permission.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6d739ef6-098a-47****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
