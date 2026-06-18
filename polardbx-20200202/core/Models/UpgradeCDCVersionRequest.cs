// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class UpgradeCDCVersionRequest : TeaModel {
        /// <summary>
        /// <para>The target database engine version to which you want to upgrade. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDBClusterVersion</a> operation to query the upgrade instructions for all database engine versions in a specific region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.343</para>
        /// </summary>
        [NameInMap("CdcDbVersion")]
        [Validation(Required=false)]
        public string CdcDbVersion { get; set; }

        /// <summary>
        /// <para>The target version number to which you want to upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polarx-cdc-kernel-5.4.19-20240928_17274884</para>
        /// </summary>
        [NameInMap("CdcMinorVersion")]
        [Validation(Required=false)]
        public string CdcMinorVersion { get; set; }

        /// <summary>
        /// <para>The instance ID. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDBInstances</a> operation to query the details of all instances in a specific region, including instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-hzrp****3p72fi</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-shrvdc****wtf5uk-cdc</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The region in which the instance resides. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196841.html">DescribeRegions</a> operation to query the regions supported by PolarDB-X, including region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The switch mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: immediately switches.</description></item>
        /// <item><description>1: switches within the O&amp;M window.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public string SwitchMode { get; set; }

    }

}
