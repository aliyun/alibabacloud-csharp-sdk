// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataLimitSetRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Chinese (Simplified). This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: English (US).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the parent asset.</para>
        /// <para>The <a href="~~DescribeDataLimitDetail~~">DescribeDataLimitDetail</a> or <a href="~~DescribeDataLimits~~">DescribeDataLimits</a> operation returns this ID in the <b>ParentId</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>The region type.</para>
        /// <list type="bullet">
        /// <item><description><b>native_audit</b>: A region that supports traffic collection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>native_audit</para>
        /// </summary>
        [NameInMap("RegionType")]
        [Validation(Required=false)]
        public string RegionType { get; set; }

        /// <summary>
        /// <para>The type of data asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: MaxCompute.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: OSS.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: ADS.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: OTS.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: RDS.</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: SELF_DB.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you set this parameter to a value other than 2, the returned OssBucketList object is empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

    }

}
