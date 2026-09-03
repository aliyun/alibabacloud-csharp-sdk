// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeBundlesRequest : TeaModel {
        /// <summary>
        /// <para>The list of cloud computer template IDs. You can specify 1 to 100 IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bundle_ecd_graphics.2xlarge_s15d15_win2019</para>
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public List<string> BundleId { get; set; }

        /// <summary>
        /// <para>The cloud computer templatetype.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM</para>
        /// </summary>
        [NameInMap("BundleType")]
        [Validation(Required=false)]
        public string BundleType { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the stock status of the cloud computer instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CheckStock")]
        [Validation(Required=false)]
        public bool? CheckStock { get; set; }

        /// <summary>
        /// <para>The number of vCPUs included in the cloud computer instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        /// <summary>
        /// <para>The cloud computer instance family.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.general</para>
        /// </summary>
        [NameInMap("DesktopTypeFamily")]
        [Validation(Required=false)]
        public string DesktopTypeFamily { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("FotaChannel")]
        [Validation(Required=false)]
        public string FotaChannel { get; set; }

        /// <summary>
        /// <para>Specifies whether the template belongs to a cloud computer pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FromDesktopGroup")]
        [Validation(Required=false)]
        public bool? FromDesktopGroup { get; set; }

        /// <summary>
        /// <para>The number of GPUs included in the cloud computer instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GpuCount")]
        [Validation(Required=false)]
        public float? GpuCount { get; set; }

        /// <summary>
        /// <para>The GPU driver type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T4</para>
        /// </summary>
        [NameInMap("GpuDriverType")]
        [Validation(Required=false)]
        public string GpuDriverType { get; set; }

        /// <summary>
        /// <para>The list of image IDs.</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public List<string> ImageId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The memory size included in the cloud computer instance type. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MemorySize")]
        [Validation(Required=false)]
        public int? MemorySize { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The operating system type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The protocol type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="~~DescribeRegions~~">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FastBuy</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The selected template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SelectedBundle")]
        [Validation(Required=false)]
        public bool? SelectedBundle { get; set; }

        /// <summary>
        /// <para>The session type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SingleSession</para>
        /// </summary>
        [NameInMap("SessionType")]
        [Validation(Required=false)]
        public string SessionType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return multi-session cloud computer templates when querying the cloud computer list. Multi-session templates are not returned by default.</para>
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
