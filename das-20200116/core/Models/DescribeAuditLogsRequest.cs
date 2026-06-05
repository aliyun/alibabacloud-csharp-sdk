// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeAuditLogsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2c548e83-1473-4fda-b3dc-5a189074ead5</para>
        /// </summary>
        [NameInMap("AsyncRequestId")]
        [Validation(Required=false)]
        public string AsyncRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11.26.118.7</para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        [NameInMap("ClientUa")]
        [Validation(Required=false)]
        public string ClientUa { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TestDB</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>in[1 33]</para>
        /// </summary>
        [NameInMap("EffectRowRange")]
        [Validation(Required=false)]
        public string EffectRowRange { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15682887991222</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>in[1000 2000]</para>
        /// </summary>
        [NameInMap("ExecuteTimeRange")]
        [Validation(Required=false)]
        public string ExecuteTimeRange { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rm-t4ni1cezz5y3xxxx</para>
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
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LoadWhiteList")]
        [Validation(Required=false)]
        public bool? LoadWhiteList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SLOW_SQL</para>
        /// </summary>
        [NameInMap("LogSource")]
        [Validation(Required=false)]
        public string LogSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Insert</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>N.A</para>
        /// </summary>
        [NameInMap("OssObjectKey")]
        [Validation(Required=false)]
        public string OssObjectKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>true</para>
        /// </summary>
        [NameInMap("RuleAggQuery")]
        [Validation(Required=false)]
        public bool? RuleAggQuery { get; set; }

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
        [NameInMap("RuleID")]
        [Validation(Required=false)]
        public string RuleID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>867028</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_rule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SELECT * FROM test where name = \&quot;das\&quot;</para>
        /// </summary>
        [NameInMap("SqlText")]
        [Validation(Required=false)]
        public string SqlText { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1608888296000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
