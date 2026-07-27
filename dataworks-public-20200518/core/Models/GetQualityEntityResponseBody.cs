// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetQualityEntityResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetQualityEntityResponseBodyData> Data { get; set; }
        public class GetQualityEntityResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the partition filter expression was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1593964800000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The level of the partition filter expression. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0 (SQL-level): A data quality check is triggered after each SQL statement is run.</para>
            /// </description></item>
            /// <item><description><para>1 (Task-level): A data quality check is triggered after all SQL statements are run.</para>
            /// </description></item>
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
            /// <para>The subscribers who receive alert notifications. The value is the ID of an Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1822931****</para>
            /// </summary>
            [NameInMap("Followers")]
            [Validation(Required=false)]
            public string Followers { get; set; }

            /// <summary>
            /// <para>Indicates whether the partition filter expression is associated with a scheduling node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The partition filter expression is associated with a scheduling node.</para>
            /// </description></item>
            /// <item><description><para>false: The partition filter expression is not associated with a scheduling node.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasRelativeNode")]
            [Validation(Required=false)]
            public bool? HasRelativeNode { get; set; }

            /// <summary>
            /// <para>The ID of the partition filter expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4003918</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The partition filter expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dt=$[yyyymmdd-1]</para>
            /// </summary>
            [NameInMap("MatchExpression")]
            [Validation(Required=false)]
            public string MatchExpression { get; set; }

            /// <summary>
            /// <para>The time when the partition filter expression was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1593964800000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The user who updates the partition filter expression. The value is the ID of an Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1822931****</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// <para>The owner who configures the partition filter expression. The value is the ID of an Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1822931****</para>
            /// </summary>
            [NameInMap("OnDuty")]
            [Validation(Required=false)]
            public string OnDuty { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud account of the owner.</para>
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
            /// <para>The scheduling node that is associated with the partition filter expression. This parameter includes the following sub-parameters:</para>
            /// <list type="bullet">
            /// <item><description><para>ProjectName: The name of the workspace to which the scheduling node belongs.</para>
            /// </description></item>
            /// <item><description><para>NodeID: The ID of the scheduling node.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;projectName&quot;:&quot;xc_DP****&quot;,&quot;nodeId&quot;:7000026****}]</para>
            /// </summary>
            [NameInMap("RelativeNode")]
            [Validation(Required=false)]
            public string RelativeNode { get; set; }

            /// <summary>
            /// <para>The SQL-level partition filter expression.</para>
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
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
