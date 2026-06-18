// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class ModifyDBInstanceClassRequest : TeaModel {
        /// <summary>
        /// <para>The client token. It can be any unique string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEA5DC20-6D8A-5979-97AA-FC57546ADC20</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para><b>Target specifications for Enterprise Edition compute node specification changes</b></para>
        /// <para><b>Primary instance compute node specifications (Enterprise Edition CN) general-purpose</b>	</para>
        /// <list type="bullet">
        /// <item><description>polarx.x4.medium.2e	2 cores, 8 GB (general-purpose)</description></item>
        /// <item><description>polarx.x4.large.2e	4 cores, 16 GB (general-purpose)</description></item>
        /// <item><description>polarx.x4.xlarge.2e	8 cores, 32 GB (general-purpose)</description></item>
        /// <item><description>polarx.x4.2xlarge.2e 16 cores, 64 GB (general-purpose)</description></item>
        /// </list>
        /// <para><b>Primary instance compute node specifications (Enterprise Edition CN) dedicated</b>	</para>
        /// <list type="bullet">
        /// <item><description>polarx.x8.large.2e	4 cores, 32 GB (dedicated)</description></item>
        /// <item><description>polarx.x8.xlarge.2e	8 cores, 64 GB (dedicated)</description></item>
        /// <item><description>polarx.x8.2xlarge.2e	16 cores, 128 GB (dedicated)</description></item>
        /// <item><description>polarx.x4.4xlarge.2e	32 cores, 128 GB (dedicated)</description></item>
        /// <item><description>polarx.x8.4xlarge.2e	32 cores, 256 GB (dedicated)</description></item>
        /// <item><description>polarx.st.8xlarge.2e	60 cores, 470 GB (dedicated)</description></item>
        /// <item><description>polarx.st.12xlarge.2e	90 cores, 720 GB (dedicated)</description></item>
        /// </list>
        /// <para><b>Read-only instance compute node specifications (Enterprise Edition CN) general-purpose</b>	</para>
        /// <list type="bullet">
        /// <item><description>polarxro.x4.medium.2e	2 cores, 8 GB (general-purpose)</description></item>
        /// <item><description>polarxro.x4.large.2e	4 cores, 16 GB (general-purpose)</description></item>
        /// <item><description>polarxro.x4.xlarge.2e	8 cores, 32 GB (general-purpose)</description></item>
        /// <item><description>polarxro.x4.2xlarge.2e	16 cores, 64 GB (general-purpose)</description></item>
        /// </list>
        /// <para><b>Read-only instance compute node specifications (Enterprise Edition CN) dedicated</b>	</para>
        /// <list type="bullet">
        /// <item><description>polarxro.x8.large.2e	4 cores, 32 GB (dedicated)</description></item>
        /// <item><description>polarxro.x8.xlarge.2e	8 cores, 64 GB (dedicated)</description></item>
        /// <item><description>polarxro.x8.2xlarge.2e	16 cores, 128 GB (dedicated)</description></item>
        /// <item><description>polarxro.x4.4xlarge.2e	32 cores, 128 GB (dedicated)</description></item>
        /// <item><description>polarxro.x8.4xlarge.2e	32 cores, 256 GB (dedicated)</description></item>
        /// <item><description>polarxro.st.8xlarge.2e	60 cores, 470 GB (dedicated physical machine)</description></item>
        /// <item><description>polarxro.st.12xlarge.2e	90 cores, 720 GB (dedicated physical machine).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>polarx.x4.medium.2e</para>
        /// </summary>
        [NameInMap("CnClass")]
        [Validation(Required=false)]
        public string CnClass { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-hzjasd****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para><b>Target specifications for Enterprise Edition storage node specification changes</b></para>
        /// <para><b>Storage node specifications (Enterprise Edition DN) general-purpose</b>	</para>
        /// <list type="bullet">
        /// <item><description>mysql.n4.medium.25	2 cores, 8 GB (general-purpose)</description></item>
        /// <item><description>mysql.n4.large.25	4 cores, 16 GB (general-purpose)</description></item>
        /// <item><description>mysql.n4.xlarge.25	8 cores, 32 GB (general-purpose)</description></item>
        /// <item><description>mysql.n4.2xlarge.25	16 cores, 64 GB (general-purpose)</description></item>
        /// </list>
        /// <para><b>Storage node specifications (Enterprise Edition DN) dedicated</b>	</para>
        /// <list type="bullet">
        /// <item><description>mysql.x8.large.25	4 cores, 32 GB (dedicated)</description></item>
        /// <item><description>mysql.x8.xlarge.25	8 cores, 64 GB (dedicated)</description></item>
        /// <item><description>mysql.x8.2xlarge.25	16 cores, 128 GB (dedicated)</description></item>
        /// <item><description>mysql.x4.4xlarge.25	32 cores, 128 GB (dedicated)</description></item>
        /// <item><description>mysql.x8.4xlarge.25	32 cores, 256 GB (dedicated)</description></item>
        /// <item><description>mysql.st.8xlarge.25	60 cores, 470 GB (dedicated)</description></item>
        /// <item><description>mysql.st.12xlarge.25	90 cores, 720 GB (dedicated)</description></item>
        /// </list>
        /// <para><b>Read-only instance storage node specifications (Enterprise Edition DN) general-purpose</b>	</para>
        /// <list type="bullet">
        /// <item><description>rds.mysql.s2.xlarge	2 cores, 8 GB (general-purpose)</description></item>
        /// <item><description>mysqlro.x4.large.1	4 cores, 16 GB (general-purpose)</description></item>
        /// <item><description>mysqlro.x4.xlarge.1	8 cores, 32 GB (general-purpose)</description></item>
        /// <item><description>mysqlro.x4.2xlarge.1	16 cores, 64 GB (general-purpose)</description></item>
        /// </list>
        /// <para><b>Read-only instance storage node specifications (Enterprise Edition DN) dedicated</b>	</para>
        /// <list type="bullet">
        /// <item><description>mysqlro.x8.large.1	4 cores, 32 GB (dedicated)</description></item>
        /// <item><description>mysqlro.x8.xlarge.1	8 cores, 64 GB (dedicated)</description></item>
        /// <item><description>mysqlro.x8.2xlarge.1	16 cores, 128 GB (dedicated)</description></item>
        /// <item><description>mysqlro.x4.4xlarge.1	32 cores, 128 GB (dedicated)</description></item>
        /// <item><description>mysqlro.x8.4xlarge.1	32 cores, 256 GB (dedicated)</description></item>
        /// <item><description>rds.mysql.st.h43	60 cores, 470 GB (dedicated physical machine)</description></item>
        /// <item><description>rds.mysql.st.v52	90 cores, 720 GB (dedicated physical machine).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.n4.medium.25</para>
        /// </summary>
        [NameInMap("DnClass")]
        [Validation(Required=false)]
        public string DnClass { get; set; }

        /// <summary>
        /// <para>The target disk size for the specification change.</para>
        /// <list type="bullet">
        /// <item><description>If the instance uses a fixed-size disk, the disk cannot be changed. In this case, do not specify DnStorageSpace.</description></item>
        /// <item><description>Valid values of DnStorageSpace: [20, 3072].</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DnStorageSpace")]
        [Validation(Required=false)]
        public string DnStorageSpace { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to change specifications for multiple DNs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SpecifiedDNScale")]
        [Validation(Required=false)]
        public bool? SpecifiedDNScale { get; set; }

        /// <summary>
        /// <para>The target specifications for each DN when changing specifications for multiple DNs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;pxc-xdb-s-htr3rh44ki3s6a4354&quot;:&quot;mysql.n4.medium.25&quot;,&quot;pxc-xdb-s-htr3rh44ki3s6a71c6&quot;:&quot;mysql.n4.medium.25&quot;}</para>
        /// </summary>
        [NameInMap("SpecifiedDNSpecMapJson")]
        [Validation(Required=false)]
        public string SpecifiedDNSpecMapJson { get; set; }

        /// <summary>
        /// <para>The start time of the switch. The switch time range is [start time T, T+30m]. This parameter is not yet available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-11T17:10:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The switch time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: immediately</description></item>
        /// <item><description>1: within the O&amp;M window.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public string SwitchTimeMode { get; set; }

        /// <summary>
        /// <para><b>Target specifications for Standard Edition specification changes</b></para>
        /// <para><b>Primary instance node specifications (for Standard Edition) (general-purpose):</b></para>
        /// <list type="bullet">
        /// <item><description>mysql.n2.medium.25	2 cores, 4 GB (general-purpose)</description></item>
        /// <item><description>mysql.n4.medium.25	2 cores, 8 GB (general-purpose)</description></item>
        /// <item><description>mysql.n8.medium.25	2 cores, 16 GB (general-purpose)</description></item>
        /// <item><description>mysql.n2.large.25	4 cores, 8 GB (general-purpose)</description></item>
        /// <item><description>mysql.n4.large.25	4 cores, 16 GB (general-purpose)</description></item>
        /// <item><description>mysql.n8.large.25	4 cores, 32 GB (general-purpose)</description></item>
        /// <item><description>mysql.n2.xlarge.25	8 cores, 16 GB (general-purpose)</description></item>
        /// <item><description>mysql.n4.xlarge.25	8 cores, 32 GB (general-purpose)</description></item>
        /// <item><description>mysql.n8.xlarge.25	8 cores, 64 GB (general-purpose)</description></item>
        /// <item><description>mysql.n2.2xlarge.25	16 cores, 32 GB (general-purpose)</description></item>
        /// <item><description>mysql.n4.2xlarge.25	16 cores, 64 GB (general-purpose)</description></item>
        /// <item><description>mysql.n8.2xlarge.25	16 cores, 128 GB (general-purpose)</description></item>
        /// </list>
        /// <para><b>Primary instance node specifications (for Standard Edition) (dedicated):</b></para>
        /// <list type="bullet">
        /// <item><description>mysql.x2.medium.25	2 cores, 4 GB (dedicated)</description></item>
        /// <item><description>mysql.x4.medium.25	2 cores, 8 GB (dedicated)</description></item>
        /// <item><description>mysql.x8.medium.25	2 cores, 16 GB (dedicated)</description></item>
        /// <item><description>mysql.x2.large.25	4 cores, 8 GB (dedicated)</description></item>
        /// <item><description>mysql.x4.large.25	4 cores, 16 GB (dedicated)</description></item>
        /// <item><description>mysql.x8.large.25	4 cores, 32 GB (dedicated)</description></item>
        /// <item><description>mysql.x2.xlarge.25	8 cores, 16 GB (dedicated)</description></item>
        /// <item><description>mysql.x4.xlarge.25	8 cores, 32 GB (dedicated)</description></item>
        /// <item><description>mysql.x8.xlarge.25	8 cores, 64 GB (dedicated)</description></item>
        /// <item><description>mysql.x2.2xlarge.25	16 cores, 32 GB (dedicated)</description></item>
        /// <item><description>mysql.x4.2xlarge.25	16 cores, 64 GB (dedicated)</description></item>
        /// <item><description>mysql.x8.2xlarge.25	16 cores, 128 GB (dedicated)</description></item>
        /// </list>
        /// <para><b>Read-only instance node specifications (for Standard Edition) general-purpose</b>	</para>
        /// <list type="bullet">
        /// <item><description>rds.mysql.s2.xlarge 	2 cores, 8 GB (general-purpose)</description></item>
        /// <item><description>mysqlro.x4.large.1 	4 cores, 16 GB (general-purpose)</description></item>
        /// <item><description>mysqlro.x4.xlarge.1 	8 cores, 32 GB (general-purpose)</description></item>
        /// <item><description>mysqlro.x4.2xlarge.1 	16 cores, 64 GB (general-purpose)</description></item>
        /// </list>
        /// <para><b>Read-only instance node specifications (for Standard Edition) dedicated</b>	</para>
        /// <list type="bullet">
        /// <item><description>mysqlro.x8.large.1 	4 cores, 32 GB (dedicated) </description></item>
        /// <item><description>mysqlro.x8.xlarge.1 	8 cores, 64 GB (dedicated) </description></item>
        /// <item><description>mysqlro.x8.2xlarge.1 	16 cores, 128 GB (dedicated) </description></item>
        /// <item><description>mysqlro.x4.4xlarge.1 	32 cores, 128 GB (dedicated) </description></item>
        /// <item><description>mysqlro.x8.4xlarge.1	32 cores, 256 GB (dedicated).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.n2.medium.25</para>
        /// </summary>
        [NameInMap("TargetDBInstanceClass")]
        [Validation(Required=false)]
        public string TargetDBInstanceClass { get; set; }

    }

}
