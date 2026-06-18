// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreateDBInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Default value: true.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enable</description></item>
        /// <item><description><b>false</b>: Disable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The number of compute nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CNNodeCount")]
        [Validation(Required=false)]
        public int? CNNodeCount { get; set; }

        /// <summary>
        /// <para>The idempotency token. Ensure that a unique value is used for each creation request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx-xxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The compute node specification. Required for creating Enterprise Edition instances. Not required for Standard Edition.</para>
        /// <para>Enterprise Edition local disk:</para>
        /// <list type="bullet">
        /// <item><description><b>polarx.x4.medium.2e</b>:	2 Cores 8 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.x4.large.2e</b>:	4 Cores 16 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.x4.xlarge.2e</b>:	8 Cores 32 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.x4.2xlarge.2e</b>:	16 Cores 64 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.x8.large.2e</b>:	4 Cores 32 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.x2.large.2x</b>:	8 Cores 16 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.x4.xlarge.2x</b>:	8 Cores 32 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.x8.xlarge.2e</b>:	8 Cores 64 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.x8.2xlarge.2e</b>:	16 Cores 128 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.x4.4xlarge.2e</b>:	32 Cores 128 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.x8.4xlarge.2e</b>:	32 Cores 256 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.st.8xlarge.2e</b>:	60 Cores 470 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.st.12xlarge.2e</b>:	90 Cores 720 GB (Dedicated)</description></item>
        /// </list>
        /// <para>Enterprise Edition cloud disk:</para>
        /// <list type="bullet">
        /// <item><description><b>polarx.x4.medium.c2e</b>:	2 Cores 8 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.x4.large.c2e</b>:	4 Cores 16 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.x4.xlarge.c2e</b>:	8 Cores 32 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.x4.2xlarge.c2e</b>:	16 Cores 64 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.x8.large.c2e</b>:	4 Cores 32 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.x2.large.c2x</b>:	8 Cores 16 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.x4.xlarge.c2x</b>:	8 Cores 32 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.x8.xlarge.c2e</b>:	8 Cores 64 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.x8.2xlarge.c2e</b>:	16 Cores 128 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.x4.4xlarge.c2e</b>:	32 Cores 128 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.x8.4xlarge.c2e</b>:	32 Cores 256 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.st.8xlarge.c2e</b>:	60 Cores 470 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.st.12xlarge.c2e</b>:	90 Cores 720 GB (Dedicated)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>polarx.x4.medium.2e</para>
        /// </summary>
        [NameInMap("CnClass")]
        [Validation(Required=false)]
        public string CnClass { get; set; }

        /// <summary>
        /// <para>Required for creating Standard Edition instances. Not required for Enterprise Edition.</para>
        /// <para>Standard Edition local disk specifications:</para>
        /// <list type="bullet">
        /// <item><description><b>mysql.n8.small.25</b>:	1 Core 8 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n2.medium.25</b>:	2 Cores 4 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n4.medium.25</b>:	2 Cores 8 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n8.medium.25</b>:	2 Cores 16 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n2.large.25</b>:	4 Cores 8 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n4.large.25</b>:	4 Cores 16 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n8.large.25</b>:	4 Cores 32 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n2.xlarge.25</b>:	8 Cores 16 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n4.xlarge.25</b>:	8 Cores 32 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n8.xlarge.25</b>:	8 Cores 64 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n2.2xlarge.25</b>:	16 Cores 32 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n4.2xlarge.25</b>:	16 Cores 64 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n8.2xlarge.25</b>:	16 Cores 128 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.x2.medium.25</b>:	2 Cores 4 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x4.medium.25</b>:	2 Cores 8 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x8.medium.25</b>:	2 Cores 16 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x2.large.25</b>:	4 Cores 8 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x4.large.25</b>:	4 Cores 16 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x8.large.25</b>:	4 Cores 32 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x2.xlarge.25</b>:	8 Cores 16 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x4.xlarge.25</b>:	8 Cores 32 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x8.xlarge.25</b>:	8 Cores 64 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x2.2xlarge.25</b>:	16 Cores 32 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x4.2xlarge.25</b>:	16 Cores 64 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x8.2xlarge.25</b>:	16 Cores 128 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x4.4xlarge.25</b>:	32 Cores 128 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x8.4xlarge.25</b>:	32 Cores 256 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x4.8xlarge.25</b>:	64 Cores 256 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x8.8xlarge.25</b>:	64 Cores 512 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.st.12xlarge.25</b>:	90 Cores 720 GB (Dedicated)</description></item>
        /// </list>
        /// <para>Standard Edition cloud disk specifications:</para>
        /// <list type="bullet">
        /// <item><description><b>polarx.mysql.n2.medium.c25</b>:	2 Cores 4 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.medium.c25</b>:	2 Cores 8 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.mysql.n8.medium.c25</b>:	2 Cores 16 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.mysql.n2.large.c25</b>:	4 Cores 8 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.large.c25</b>:	4 Cores 16 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.mysql.n8.large.c25</b>:	4 Cores 32 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.mysql.n2.xlarge.c25</b>:	8 Cores 16 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.xlarge.c25</b>:	8 Cores 32 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.mysql.n8.xlarge.c25</b>:	8 Cores 64 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.mysql.x2.medium.c25</b>:	2 Cores 4 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x4.medium.c25</b>:	2 Cores 8 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.medium.c25</b>:	2 Cores 16 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x2.large.c25</b>:	4 Cores 8 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x4.large.c25</b>:	4 Cores 16 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.large.c25</b>:	4 Cores 32 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x2.xlarge.c25</b>:	8 Cores 16 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x4.xlarge.c25</b>:	8 Cores 32 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.xlarge.c25</b>:	8 Cores 64 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x2.2xlarge.c25</b>:	16 Cores 32 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x4.2xlarge.c25</b>:	16 Cores 64 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.2xlarge.c25</b>:	16 Cores 128 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x2.4xlarge.c25</b>:	32 Cores 64 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x4.4xlarge.c25</b>:	32 Cores 128 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.4xlarge.c25</b>:	32 Cores 256 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x2.8xlarge.c25</b>:	64 Cores 128 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x4.8xlarge.c25</b>:	64 Cores 256 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.8xlarge.c25</b>:	64 Cores 512 GB (Dedicated)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>polarx.x4.2xlarge.2d</para>
        /// </summary>
        [NameInMap("DBNodeClass")]
        [Validation(Required=false)]
        public string DBNodeClass { get; set; }

        /// <summary>
        /// <para>The number of instance nodes:</para>
        /// <list type="bullet">
        /// <item><description>Standard Edition: 1</description></item>
        /// <item><description>Enterprise Edition: &gt;=2</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DBNodeCount")]
        [Validation(Required=false)]
        public int? DBNodeCount { get; set; }

        /// <summary>
        /// <para>The number of storage nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DNNodeCount")]
        [Validation(Required=false)]
        public int? DNNodeCount { get; set; }

        /// <summary>
        /// <para>The description of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ods_api_apidata_mobilegame_pay_api_di</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The storage node specification. Required for creating Enterprise Edition instances. Not required for Standard Edition.</para>
        /// <para>Enterprise Edition local disk:</para>
        /// <list type="bullet">
        /// <item><description><b>mysql.n2.medium.25</b>:	2 Cores 4 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n4.medium.25</b>:	2 Cores 8 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n2.large.25</b>:	4 Cores 8 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n4.large.25</b>:	4 Cores 16 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n4.xlarge.25</b>:	8 Cores 32 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.n4.2xlarge.25</b>:	16 Cores 64 GB (General Purpose)</description></item>
        /// <item><description><b>mysql.x4.large.25</b>:	4 Cores 16 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x8.large.25</b>:	4 Cores 32 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x2.xlarge.25</b>:	8 Cores 16 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x8.xlarge.25</b>:	8 Cores 64 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x8.2xlarge.25</b>:	16 Cores 128 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x4.4xlarge.25</b>:	32 Cores 128 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x8.4xlarge.25</b>:	32 Cores 256 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.st.8xlarge.25</b>:	60 Cores 470 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.st.12xlarge.25</b>:	90 Cores 720 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x8.45xlarge.25</b>:	180 Cores 1440 GB (Dedicated)</description></item>
        /// <item><description><b>mysql.x8.60xlarge.25</b>:	240 Cores 1920 GB (Dedicated)</description></item>
        /// </list>
        /// <para>Enterprise Edition cloud disk:</para>
        /// <list type="bullet">
        /// <item><description><b>polarx.mysql.n2.medium.c25</b>:	2 Cores 4 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.medium.c25</b>:	2 Cores 8 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.mysql.n2.large.c25</b>:	4 Cores 8 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.large.c25</b>:	4 Cores 16 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.xlarge.c25</b>:	8 Cores 32 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.2xlarge.c25</b>:	16 Cores 64 GB (General Purpose)</description></item>
        /// <item><description><b>polarx.mysql.x4.large.c25</b>:	4 Cores 16 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.large.c25</b>:	4 Cores 32 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x2.xlarge.c25</b>:	8 Cores 16 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.xlarge.c25</b>:	8 Cores 64 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.2xlarge.c25</b>:	16 Cores 128 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x4.4xlarge.c25</b>:	32 Cores 128 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.4xlarge.c25</b>:	32 Cores 256 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.st.8xlarge.c25</b>:	60 Cores 470 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.st.12xlarge.c25</b>: 90 Cores 720 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.45xlarge.c25</b>: 180 Cores 1440 GB (Dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.60xlarge.c25</b>: 240 Cores 1920 GB (Dedicated)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.n4.medium.25</para>
        /// </summary>
        [NameInMap("DnClass")]
        [Validation(Required=false)]
        public string DnClass { get; set; }

        /// <summary>
        /// <para>The disk space size of the storage node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1500</para>
        /// </summary>
        [NameInMap("DnStorageSpace")]
        [Validation(Required=false)]
        public string DnStorageSpace { get; set; }

        /// <summary>
        /// <para>The MySQL engine version. Valid values: 5.7 and 8.0.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.7</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>Additional parameters.</para>
        /// </summary>
        [NameInMap("ExtraParams")]
        [Validation(Required=false)]
        public string ExtraParamsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance to be created is a columnar read-only instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsColumnarReadDBInstance")]
        [Validation(Required=false)]
        public bool? IsColumnarReadDBInstance { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is a read-only instance.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes</description></item>
        /// <item><description><b>false</b>: No</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsReadDBInstance")]
        [Validation(Required=false)]
        public bool? IsReadDBInstance { get; set; }

        /// <summary>
        /// <para>The network type. Only VPC is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The minor version number. This parameter is generally not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb-2.4.0_standard_xcluster8.4.20-20260331</para>
        /// </summary>
        [NameInMap("OriginMinorVersion")]
        [Validation(Required=false)]
        public string OriginMinorVersion { get; set; }

        /// <summary>
        /// <para>The billing method of the instance.</para>
        /// <list type="bullet">
        /// <item><description><b>PREPAY</b>: Subscription</description></item>
        /// <item><description><b>POSTPAY</b>: Pay-as-you-go</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The billing cycle. For subscription instances, valid values are Year and Month. For pay-as-you-go instances, the default value is Hour.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The primary instance must be specified if the instance is a read-only instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-*********</para>
        /// </summary>
        [NameInMap("PrimaryDBInstanceName")]
        [Validation(Required=false)]
        public string PrimaryDBInstanceName { get; set; }

        /// <summary>
        /// <para>The primary availability zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen-e</para>
        /// </summary>
        [NameInMap("PrimaryZone")]
        [Validation(Required=false)]
        public string PrimaryZone { get; set; }

        /// <summary>
        /// <para>The region where the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. This parameter can be left empty. This feature is currently not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The secondary availability zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen-a</para>
        /// </summary>
        [NameInMap("SecondaryZone")]
        [Validation(Required=false)]
        public string SecondaryZone { get; set; }

        /// <summary>
        /// <para>Enterprise Edition: enterprise
        /// Standard Edition: standard</para>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise</para>
        /// </summary>
        [NameInMap("Series")]
        [Validation(Required=false)]
        public string Series { get; set; }

        /// <summary>
        /// <para>The storage type.</para>
        /// <list type="bullet">
        /// <item><description>Local disk: custom_local_ssd</description></item>
        /// <item><description>Cloud disk: cloud_auto</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The tertiary availability zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen-e</para>
        /// </summary>
        [NameInMap("TertiaryZone")]
        [Validation(Required=false)]
        public string TertiaryZone { get; set; }

        /// <summary>
        /// <para>The topology type:</para>
        /// <list type="bullet">
        /// <item><description><b>3azones</b>: Three availability zones</description></item>
        /// <item><description><b>1azone</b>: Single availability zone</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3azones</para>
        /// </summary>
        [NameInMap("TopologyType")]
        [Validation(Required=false)]
        public string TopologyType { get; set; }

        /// <summary>
        /// <para>The subscription duration. You can specify the number of months or years for prepaid instances.</para>
        /// <remarks>
        /// <para>When Period is set to Year, valid values for this parameter are 1, 2, and 3.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-*****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*********</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The availability zone of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
