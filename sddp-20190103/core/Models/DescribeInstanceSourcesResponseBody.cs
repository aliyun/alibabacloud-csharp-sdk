// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeInstanceSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The assets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeInstanceSourcesResponseBodyItems> Items { get; set; }
        public class DescribeInstanceSourcesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>Indicates whether the security audit feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public int? AuditStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the automatic scan feature is enabled to detect sensitive data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: no</description></item>
            /// <item><description><b>1</b>: yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AutoScan")]
            [Validation(Required=false)]
            public int? AutoScan { get; set; }

            /// <summary>
            /// <para>Indicates whether the username and password can be changed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanModifyUserName")]
            [Validation(Required=false)]
            public bool? CanModifyUserName { get; set; }

            /// <summary>
            /// <para>The data detection status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The data detection is ready.</description></item>
            /// <item><description><b>1</b>: The data detection is running.</description></item>
            /// <item><description><b>2</b>: The connectivity test is in progress.</description></item>
            /// <item><description><b>3</b>: The connectivity test passed.</description></item>
            /// <item><description><b>4</b>: The connectivity test failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public int? CheckStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether DSC has the data de-identification permissions on the data asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DatamaskStatus")]
            [Validation(Required=false)]
            public int? DatamaskStatus { get; set; }

            /// <summary>
            /// <para>The name of the database to which the data asset belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>Indicates whether sensitive data detection is enabled for the data asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            /// <summary>
            /// <para>The engine type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MySQL</b></description></item>
            /// <item><description><b>MariaDB</b></description></item>
            /// <item><description><b>Oracle</b></description></item>
            /// <item><description><b>PostgreSQL</b></description></item>
            /// <item><description><b>SQLServer</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The reason for the failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The password is invalid.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The time when the data asset was created. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1625587423000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The unique ID of the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The ID of the instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The storage space size of the instance. This parameter is valid only if the value of the ProductId parameter is 2. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>409600</para>
            /// </summary>
            [NameInMap("InstanceSize")]
            [Validation(Required=false)]
            public long? InstanceSize { get; set; }

            /// <summary>
            /// <para>The time when the data asset was last modified. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1625587423000</para>
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }

            /// <summary>
            /// <para>The ID of the account that is last used to modify the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("LastModifyUserId")]
            [Validation(Required=false)]
            public string LastModifyUserId { get; set; }

            /// <summary>
            /// <para>The retention period of raw logs. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("LogStoreDay")]
            [Validation(Required=false)]
            public int? LogStoreDay { get; set; }

            /// <summary>
            /// <para>Indicates whether the password is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: yes</description></item>
            /// <item><description><b>0</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PasswordStatus")]
            [Validation(Required=false)]
            public int? PasswordStatus { get; set; }

            /// <summary>
            /// <para>The ID of the service to which the asset belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: MaxCompute</description></item>
            /// <item><description><b>2</b>: OSS</description></item>
            /// <item><description><b>3</b>: AnalyticDB for MySQL</description></item>
            /// <item><description><b>4</b>: OTS</description></item>
            /// <item><description><b>5</b>: ApsaraDB RDS</description></item>
            /// <item><description><b>6</b>: self-managed databases</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public long? ProductId { get; set; }

            /// <summary>
            /// <para>The ID of the region where the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China (Hangzhou)</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>The number of sensitive data samples. Valid values: <b>0</b>, <b>5</b>, and <b>10</b>. Unit: data entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SamplingSize")]
            [Validation(Required=false)]
            public int? SamplingSize { get; set; }

            /// <summary>
            /// <para>The ID of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The name of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// <para>The username of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User01</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A7E8FB9-5011-5A90-97D9-AE587047****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
