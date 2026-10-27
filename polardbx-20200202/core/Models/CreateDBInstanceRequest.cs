// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreateDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enables auto-renewal.</description></item>
        /// <item><description><b>false</b>: Disables auto-renewal.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You must specify a unique token for each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxx-xxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The specifications of compute nodes. Required when you create an Enterprise Edition instance. Not required for a Standard Edition instance.</para>
        /// <para>Local node specifications for Enterprise Edition:</para>
        /// <list type="bullet">
        /// <item><description><b>polarx.x4.medium.2e</b>: 2 vCPUs, 8 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.x4.large.2e</b>: 4 vCPUs, 16 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.x4.xlarge.2e</b>: 8 vCPUs, 32 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.x4.2xlarge.2e</b>: 16 vCPUs, 64 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.x8.large.2e</b>: 4 vCPUs, 32 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x2.large.2x</b>: 8 vCPUs, 16 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x4.xlarge.2x</b>: 8 vCPUs, 32 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x8.xlarge.2e</b>: 8 vCPUs, 64 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x8.2xlarge.2e</b>: 16 vCPUs, 128 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x4.4xlarge.2e</b>: 32 vCPUs, 128 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x8.4xlarge.2e</b>: 32 vCPUs, 256 GB (dedicated)</description></item>
        /// <item><description><b>polarx.st.8xlarge.2e</b>: 60 vCPUs, 470 GB (dedicated)</description></item>
        /// <item><description><b>polarx.st.12xlarge.2e</b>: 90 vCPUs, 720 GB (dedicated)</description></item>
        /// </list>
        /// <para>Cloud node specifications for Enterprise Edition:</para>
        /// <list type="bullet">
        /// <item><description><b>polarx.x4.medium.c2e</b>: 2 vCPUs, 8 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.x4.large.c2e</b>: 4 vCPUs, 16 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.x4.xlarge.c2e</b>: 8 vCPUs, 32 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.x4.2xlarge.c2e</b>: 16 vCPUs, 64 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.x8.large.c2e</b>: 4 vCPUs, 32 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x2.large.c2x</b>: 8 vCPUs, 16 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x4.xlarge.c2x</b>: 8 vCPUs, 32 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x8.xlarge.c2e</b>: 8 vCPUs, 64 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x8.2xlarge.c2e</b>: 16 vCPUs, 128 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x4.4xlarge.c2e</b>: 32 vCPUs, 128 GB (dedicated)</description></item>
        /// <item><description><b>polarx.x8.4xlarge.c2e</b>: 32 vCPUs, 256 GB (dedicated)</description></item>
        /// <item><description><b>polarx.st.8xlarge.c2e</b>: 60 vCPUs, 470 GB (dedicated)</description></item>
        /// <item><description><b>polarx.st.12xlarge.c2e</b>: 90 vCPUs, 720 GB (dedicated)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>polarx.x4.medium.2e</para>
        /// </summary>
        [NameInMap("CnClass")]
        [Validation(Required=false)]
        public string CnClass { get; set; }

        /// <summary>
        /// <para>Required when you create a Standard Edition instance. Not required for an Enterprise Edition instance.</para>
        /// <para>Local disk specifications for Standard Edition:</para>
        /// <list type="bullet">
        /// <item><description><b>mysql.n8.small.25</b>: 1 vCPU, 8 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n2.medium.25</b>: 2 vCPUs, 4 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n4.medium.25</b>: 2 vCPUs, 8 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n8.medium.25</b>: 2 vCPUs, 16 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n2.large.25</b>: 4 vCPUs, 8 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n4.large.25</b>: 4 vCPUs, 16 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n8.large.25</b>: 4 vCPUs, 32 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n2.xlarge.25</b>: 8 vCPUs, 16 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n4.xlarge.25</b>: 8 vCPUs, 32 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n8.xlarge.25</b>: 8 vCPUs, 64 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n2.2xlarge.25</b>: 16 vCPUs, 32 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n4.2xlarge.25</b>: 16 vCPUs, 64 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n8.2xlarge.25</b>: 16 vCPUs, 128 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.x2.medium.25</b>: 2 vCPUs, 4 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x4.medium.25</b>: 2 vCPUs, 8 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.medium.25</b>: 2 vCPUs, 16 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x2.large.25</b>: 4 vCPUs, 8 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x4.large.25</b>: 4 vCPUs, 16 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.large.25</b>: 4 vCPUs, 32 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x2.xlarge.25</b>: 8 vCPUs, 16 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x4.xlarge.25</b>: 8 vCPUs, 32 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.xlarge.25</b>: 8 vCPUs, 64 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x2.2xlarge.25</b>: 16 vCPUs, 32 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x4.2xlarge.25</b>: 16 vCPUs, 64 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.2xlarge.25</b>: 16 vCPUs, 128 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x4.4xlarge.25</b>: 32 vCPUs, 128 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.4xlarge.25</b>: 32 vCPUs, 256 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x4.8xlarge.25</b>: 64 vCPUs, 256 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.8xlarge.25</b>: 64 vCPUs, 512 GB (dedicated)</description></item>
        /// <item><description><b>mysql.st.12xlarge.25</b>: 90 vCPUs, 720 GB (dedicated)</description></item>
        /// </list>
        /// <para>Cloud disk specifications for Standard Edition:</para>
        /// <list type="bullet">
        /// <item><description><b>polarx.mysql.n2.medium.c25</b>: 2 vCPUs, 4 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.medium.c25</b>: 2 vCPUs, 8 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n8.medium.c25</b>: 2 vCPUs, 16 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n2.large.c25</b>: 4 vCPUs, 8 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.large.c25</b>: 4 vCPUs, 16 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n8.large.c25</b>: 4 vCPUs, 32 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n2.xlarge.c25</b>: 8 vCPUs, 16 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.xlarge.c25</b>: 8 vCPUs, 32 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n8.xlarge.c25</b>: 8 vCPUs, 64 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.x2.medium.c25</b>: 2 vCPUs, 4 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x4.medium.c25</b>: 2 vCPUs, 8 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.medium.c25</b>: 2 vCPUs, 16 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x2.large.c25</b>: 4 vCPUs, 8 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x4.large.c25</b>: 4 vCPUs, 16 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.large.c25</b>: 4 vCPUs, 32 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x2.xlarge.c25</b>: 8 vCPUs, 16 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x4.xlarge.c25</b>: 8 vCPUs, 32 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.xlarge.c25</b>: 8 vCPUs, 64 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x2.2xlarge.c25</b>: 16 vCPUs, 32 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x4.2xlarge.c25</b>: 16 vCPUs, 64 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.2xlarge.c25</b>: 16 vCPUs, 128 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x2.4xlarge.c25</b>: 32 vCPUs, 64 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x4.4xlarge.c25</b>: 32 vCPUs, 128 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.4xlarge.c25</b>: 32 vCPUs, 256 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x2.8xlarge.c25</b>: 64 vCPUs, 128 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x4.8xlarge.c25</b>: 64 vCPUs, 256 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.8xlarge.c25</b>: 64 vCPUs, 512 GB (dedicated)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>polarx.x4.2xlarge.2d</para>
        /// </summary>
        [NameInMap("DBNodeClass")]
        [Validation(Required=false)]
        public string DBNodeClass { get; set; }

        /// <summary>
        /// <para>The number of nodes in the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard Edition: 1</description></item>
        /// <item><description>Enterprise Edition: 2 or greater</description></item>
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
        /// <para>The specifications of storage nodes. Required when you create an Enterprise Edition instance. Not required for a Standard Edition instance.</para>
        /// <para>Local node specifications for Enterprise Edition:</para>
        /// <list type="bullet">
        /// <item><description><b>mysql.n2.medium.25</b>: 2 vCPUs, 4 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n4.medium.25</b>: 2 vCPUs, 8 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n2.large.25</b>: 4 vCPUs, 8 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n4.large.25</b>: 4 vCPUs, 16 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n4.xlarge.25</b>: 8 vCPUs, 32 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.n4.2xlarge.25</b>: 16 vCPUs, 64 GB (general-purpose)</description></item>
        /// <item><description><b>mysql.x4.large.25</b>: 4 vCPUs, 16 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.large.25</b>: 4 vCPUs, 32 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x2.xlarge.25</b>: 8 vCPUs, 16 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.xlarge.25</b>: 8 vCPUs, 64 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.2xlarge.25</b>: 16 vCPUs, 128 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x4.4xlarge.25</b>: 32 vCPUs, 128 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.4xlarge.25</b>: 32 vCPUs, 256 GB (dedicated)</description></item>
        /// <item><description><b>mysql.st.8xlarge.25</b>: 60 vCPUs, 470 GB (dedicated)</description></item>
        /// <item><description><b>mysql.st.12xlarge.25</b>: 90 vCPUs, 720 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.45xlarge.25</b>: 180 vCPUs, 1440 GB (dedicated)</description></item>
        /// <item><description><b>mysql.x8.60xlarge.25</b>: 240 vCPUs, 1920 GB (dedicated)</description></item>
        /// </list>
        /// <para>Cloud node specifications for Enterprise Edition:</para>
        /// <list type="bullet">
        /// <item><description><b>polarx.mysql.n2.medium.c25</b>: 2 vCPUs, 4 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.medium.c25</b>: 2 vCPUs, 8 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n2.large.c25</b>: 4 vCPUs, 8 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.large.c25</b>: 4 vCPUs, 16 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.xlarge.c25</b>: 8 vCPUs, 32 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.n4.2xlarge.c25</b>: 16 vCPUs, 64 GB (general-purpose)</description></item>
        /// <item><description><b>polarx.mysql.x4.large.c25</b>: 4 vCPUs, 16 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.large.c25</b>: 4 vCPUs, 32 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x2.xlarge.c25</b>: 8 vCPUs, 16 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.xlarge.c25</b>: 8 vCPUs, 64 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.2xlarge.c25</b>: 16 vCPUs, 128 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x4.4xlarge.c25</b>: 32 vCPUs, 128 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.4xlarge.c25</b>: 32 vCPUs, 256 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.st.8xlarge.c25</b>: 60 vCPUs, 470 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.st.12xlarge.c25</b>: 90 vCPUs, 720 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.45xlarge.c25</b>: 180 vCPUs, 1440 GB (dedicated)</description></item>
        /// <item><description><b>polarx.mysql.x8.60xlarge.c25</b>: 240 vCPUs, 1920 GB (dedicated)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.n4.medium.25</para>
        /// </summary>
        [NameInMap("DnClass")]
        [Validation(Required=false)]
        public string DnClass { get; set; }

        /// <summary>
        /// <para>The disk space of the storage nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1500</para>
        /// </summary>
        [NameInMap("DnStorageSpace")]
        [Validation(Required=false)]
        public string DnStorageSpace { get; set; }

        /// <summary>
        /// <para>The MySQL DPI engine version. Valid values: 5.7 and 8.0.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.7</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The extra parameters.</para>
        /// </summary>
        [NameInMap("ExtraParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtraParams { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance to be created is a column store read-only instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsColumnarReadDBInstance")]
        [Validation(Required=false)]
        public bool? IsColumnarReadDBInstance { get; set; }

        /// <summary>
        /// <para>Specifies whether the instance is a read-only instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsReadDBInstance")]
        [Validation(Required=false)]
        public bool? IsReadDBInstance { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Only VPC is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The minor engine version. This parameter is generally not required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb-2.4.0_standard_xcluster8.4.20-20260331</para>
        /// </summary>
        [NameInMap("OriginMinorVersion")]
        [Validation(Required=false)]
        public string OriginMinorVersion { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PREPAY</b>: subscription</description></item>
        /// <item><description><b>POSTPAY</b>: pay-as-you-go</description></item>
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
        /// <para>The billing cycle. Valid values for subscription instances: Year and Month. Default value for pay-as-you-go instances: Hour.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The name of the primary instance. This parameter is required if the instance is a read-only instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-*********</para>
        /// </summary>
        [NameInMap("PrimaryDBInstanceName")]
        [Validation(Required=false)]
        public string PrimaryDBInstanceName { get; set; }

        /// <summary>
        /// <para>The primary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen-e</para>
        /// </summary>
        [NameInMap("PrimaryZone")]
        [Validation(Required=false)]
        public string PrimaryZone { get; set; }

        /// <summary>
        /// <para>The region of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID. This parameter is not supported and can be left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen-a</para>
        /// </summary>
        [NameInMap("SecondaryZone")]
        [Validation(Required=false)]
        public string SecondaryZone { get; set; }

        /// <summary>
        /// <para>The edition of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enterprise: Enterprise Edition</description></item>
        /// <item><description>standard: Standard Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise</para>
        /// </summary>
        [NameInMap("Series")]
        [Validation(Required=false)]
        public string Series { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>custom_local_ssd: local disk</description></item>
        /// <item><description>cloud_auto: cloud disk</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The third active zone in a Three-zone deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen-e</para>
        /// </summary>
        [NameInMap("TertiaryZone")]
        [Validation(Required=false)]
        public string TertiaryZone { get; set; }

        /// <summary>
        /// <para>The topology type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>3azones</b>: Three-zone deployment (three active zones).</description></item>
        /// <item><description><b>1azone</b>: Single active zone.</description></item>
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
        /// <para>The subscription duration. This parameter is required when the billing method is set to subscription.</para>
        /// <remarks>
        /// <para>If Period is set to Year, valid values are 1, 2, and 3.</para>
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
        /// <para>The zone of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
