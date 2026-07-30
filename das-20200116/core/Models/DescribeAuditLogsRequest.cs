// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeAuditLogsRequest : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2c548e83-1473-4fda-b3dc-5a189074ead5</para>
        /// </summary>
        [NameInMap("AsyncRequestId")]
        [Validation(Required=false)]
        public string AsyncRequestId { get; set; }

        /// <summary>
        /// <para>The IP address of the request client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11.26.118.7</para>
        /// </summary>
        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        /// <summary>
        /// <para>The client type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql</para>
        /// </summary>
        [NameInMap("ClientUa")]
        [Validation(Required=false)]
        public string ClientUa { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestDB</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The range of affected rows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>in[1 33]</para>
        /// </summary>
        [NameInMap("EffectRowRange")]
        [Validation(Required=false)]
        public string EffectRowRange { get; set; }

        /// <summary>
        /// <para>The end time of the alert log. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15682887991222</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The range of execution time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>in[1000 2000]</para>
        /// </summary>
        [NameInMap("ExecuteTimeRange")]
        [Validation(Required=false)]
        public string ExecuteTimeRange { get; set; }

        /// <summary>
        /// <para>The name of the asset instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4ni1cezz5y3xxxx</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>default</b> (default): non-Alibaba Cloud service.</para>
        /// </description></item>
        /// <item><description><para><b>aliyun</b>: Alibaba Cloud service.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public string IpType { get; set; }

        /// <summary>
        /// <para>The language type for sending and receiving messages. Default value: zh_cn. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh_cn: Chinese.</description></item>
        /// <item><description>en_us: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to load the whitelist status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LoadWhiteList")]
        [Validation(Required=false)]
        public bool? LoadWhiteList { get; set; }

        [NameInMap("LogQueryOpJson")]
        [Validation(Required=false)]
        public string LogQueryOpJson { get; set; }

        /// <summary>
        /// <para>The data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SLOW_SQL</para>
        /// </summary>
        [NameInMap("LogSource")]
        [Validation(Required=false)]
        public string LogSource { get; set; }

        /// <summary>
        /// <para>The operation type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Insert</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>The key of the OSS storage object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N.A</para>
        /// </summary>
        [NameInMap("OssObjectKey")]
        [Validation(Required=false)]
        public string OssObjectKey { get; set; }

        /// <summary>
        /// <para>The maximum number of records per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the product to which the data asset belongs. Valid values: <b>RDS, PolarDB, PolarDB-X 2.0</b>, and others.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID that corresponds to the product name to which the data object belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>3: ADB-MYSQL</description></item>
        /// <item><description>5: RDS</description></item>
        /// <item><description>7: PolarDB-X</description></item>
        /// <item><description>8: PolarDB</description></item>
        /// <item><description>9: ADB-PG</description></item>
        /// <item><description>11: MongoDB</description></item>
        /// <item><description>25: Redis</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform an aggregate query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RuleAggQuery")]
        [Validation(Required=false)]
        public bool? RuleAggQuery { get; set; }

        /// <summary>
        /// <para>The rule type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RuleCategory")]
        [Validation(Required=false)]
        public string RuleCategory { get; set; }

        /// <summary>
        /// <para>The ID of the audit policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9953411</para>
        /// </summary>
        [NameInMap("RuleID")]
        [Validation(Required=false)]
        public string RuleID { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>867028</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The name of the audit policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_rule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The content of the SQL statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT * FROM test where name = \&quot;das\&quot;</para>
        /// </summary>
        [NameInMap("SqlText")]
        [Validation(Required=false)]
        public string SqlText { get; set; }

        /// <summary>
        /// <para>The start time of the alert log, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1608888296000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
