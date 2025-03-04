// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeBundlesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the cloud computer templates. You can specify 1 to 100 IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bundle_ecd_graphics.2xlarge_s15d15_win2019</para>
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public List<string> BundleId { get; set; }

        /// <summary>
        /// <para>The type of the cloud computer template.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SYSTEM: system template</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>CUSTOM: custom template</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM</para>
        /// </summary>
        [NameInMap("BundleType")]
        [Validation(Required=false)]
        public string BundleType { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the inventory status of the cloud computer instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CheckStock")]
        [Validation(Required=false)]
        public bool? CheckStock { get; set; }

        /// <summary>
        /// <para>The number of vCPUs contained in the cloud computer instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// <para>The instance family of the cloud computers.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>eds.graphics: graphical instance families</description></item>
        /// <item><description>eds.hf: instance families with high clock speeds</description></item>
        /// <item><description>eds.general: general-purpose instance families</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>eds.general</para>
        /// </summary>
        [NameInMap("DesktopTypeFamily")]
        [Validation(Required=false)]
        public string DesktopTypeFamily { get; set; }

        /// <summary>
        /// <remarks>
        /// <para> This parameter is not available for public use.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>This parameter is now in invitational preview and unavailable.</para>
        /// </summary>
        [NameInMap("FotaChannel")]
        [Validation(Required=false)]
        public string FotaChannel { get; set; }

        /// <summary>
        /// <para>Specifies whether the cloud computers in the template belong to a cloud computer pool.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>false</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FromDesktopGroup")]
        [Validation(Required=false)]
        public bool? FromDesktopGroup { get; set; }

        /// <summary>
        /// <para>The number of GPUs contained in the cloud computer instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GpuCount")]
        [Validation(Required=false)]
        public float? GpuCount { get; set; }

        /// <summary>
        /// <para>The GPU driver type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>T4</description></item>
        /// <item><description>A10</description></item>
        /// <item><description>G28</description></item>
        /// <item><description>G39</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>T4</para>
        /// </summary>
        [NameInMap("GpuDriverType")]
        [Validation(Required=false)]
        public string GpuDriverType { get; set; }

        /// <summary>
        /// <para>The image IDs.</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public List<string> ImageId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The memory size of the cloud computer instance type. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MemorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The type of the OS.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Linux</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Windows</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The protocol type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HDX: High-definition Experience (HDX) protocol</description></item>
        /// <item><description>ASP: in-house Adaptive Streaming Protocol (ASP) (recommend)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the regions supported by Elastic Desktop Service (EDS).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The scenario to use the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FastBuy</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The desktop template that is selected based on specific criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SelectedBundle")]
        [Validation(Required=false)]
        public bool? SelectedBundle { get; set; }

        /// <summary>
        /// <para>The type of the session. Valide values:</para>
        /// <list type="bullet">
        /// <item><description>SingleSession</description></item>
        /// <item><description>MultipleSession</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SingleSession</para>
        /// </summary>
        [NameInMap("SessionType")]
        [Validation(Required=false)]
        public string SessionType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return multi-session cloud computer templates. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SupportMultiSession")]
        [Validation(Required=false)]
        public bool? SupportMultiSession { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable disk encryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VolumeEncryptionEnabled")]
        [Validation(Required=false)]
        public bool? VolumeEncryptionEnabled { get; set; }

    }

}
