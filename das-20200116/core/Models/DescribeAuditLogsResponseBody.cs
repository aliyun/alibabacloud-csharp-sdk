// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeAuditLogsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3926fba5-1774-44f4-af2d-ac7b33e86c3b</para>
        /// </summary>
        [NameInMap("AsyncRequestId")]
        [Validation(Required=false)]
        public string AsyncRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAuditLogsResponseBodyItems> Items { get; set; }
        public class DescribeAuditLogsResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100.104.16.251</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>53815</para>
            /// </summary>
            [NameInMap("ClientPort")]
            [Validation(Required=false)]
            public string ClientPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("ClientUa")]
            [Validation(Required=false)]
            public string ClientUa { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ds</para>
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1536751124000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>chngc_b2b_migration_sh</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("EffectRow")]
            [Validation(Required=false)]
            public long? EffectRow { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExecuteStatus")]
            [Validation(Required=false)]
            public int? ExecuteStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1751870592000</para>
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public long? ExecuteTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("InWhiteList")]
            [Validation(Required=false)]
            public bool? InWhiteList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InstanceAuditStatus")]
            [Validation(Required=false)]
            public string InstanceAuditStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>instance dscription</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-instance-003</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyun</para>
            /// </summary>
            [NameInMap("IpType")]
            [Validation(Required=false)]
            public string IpType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SLOW_SQL</para>
            /// </summary>
            [NameInMap("LogSource")]
            [Validation(Required=false)]
            public string LogSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1751870592000</para>
            /// </summary>
            [NameInMap("LogTime")]
            [Validation(Required=false)]
            public long? LogTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Drop</para>
            /// </summary>
            [NameInMap("OperateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

            [NameInMap("OssObjectKey")]
            [Validation(Required=false)]
            public string OssObjectKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test01</para>
            /// </summary>
            [NameInMap("PackageName")]
            [Validation(Required=false)]
            public string PackageName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public long? ProductId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RuleCategory")]
            [Validation(Required=false)]
            public string RuleCategory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9953411</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>select * from test03</para>
            /// </summary>
            [NameInMap("SqlText")]
            [Validation(Required=false)]
            public string SqlText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>it_table</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19********94</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WarnLevel")]
            [Validation(Required=false)]
            public string WarnLevel { get; set; }

            [NameInMap("WarnLevelName")]
            [Validation(Required=false)]
            public string WarnLevelName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A7021857-AFD9-5AD6-979D-AA7DFC5AFADF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
