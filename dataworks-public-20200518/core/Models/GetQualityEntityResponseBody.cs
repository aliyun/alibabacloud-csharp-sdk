// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetQualityEntityResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the partition filter expression.</para>
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
            /// <item><description>0: The partition filter expression is at the SQL level. This indicates that the system checks data quality after each SQL statement is executed.</description></item>
            /// <item><description>1: The partition filter expression is at the node level. This indicates that the system checks data quality after all the SQL statements for a node are executed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("EntityLevel")]
            [Validation(Required=false)]
            public int? EntityLevel { get; set; }

            /// <summary>
            /// <para>The type of the compute engine instance or data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that is used to receive alert notifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1822931****</para>
            /// </summary>
            [NameInMap("Followers")]
            [Validation(Required=false)]
            public string Followers { get; set; }

            /// <summary>
            /// <para>Indicates whether the partition filter expression is associated with a node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The partition filter expression is associated with a node.</description></item>
            /// <item><description>false: The partition filter expression is not associated with a node.</description></item>
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
            /// <para>The time when the partition filter expression was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1593964800000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that is used to modify the partition filter expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1822931****</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that is used to configure the partition filter expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1822931****</para>
            /// </summary>
            [NameInMap("OnDuty")]
            [Validation(Required=false)]
            public string OnDuty { get; set; }

            /// <summary>
            /// <para>The name of the Alibaba Cloud account that is used to configure the partition filter expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("OnDutyAccountName")]
            [Validation(Required=false)]
            public string OnDutyAccountName { get; set; }

            /// <summary>
            /// <para>The name of the compute engine instance or data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>autotest</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The information about the node with which the partition filter expression is associated. The information includes the following items:</para>
            /// <list type="bullet">
            /// <item><description>ProjectName: the name of the workspace to which the node belongs.</description></item>
            /// <item><description>NodeID: the ID of the node.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;projectName&quot;:&quot;xc_DP****&quot;,&quot;nodeId&quot;:7000026****}]</para>
            /// </summary>
            [NameInMap("RelativeNode")]
            [Validation(Required=false)]
            public string RelativeNode { get; set; }

            /// <summary>
            /// <para>Indicates that the partition filter expression is at the SQL level.</para>
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
            /// <para>The node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Task")]
            [Validation(Required=false)]
            public int? Task { get; set; }

        }

        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>401</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You have no permission.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6d739ef6-098a-47****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
