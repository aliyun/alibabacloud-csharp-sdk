// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class DataDisk : TeaModel {
        /// <summary>
        /// <para>磁盘类型。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>每个节点磁盘数量。</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>创建ESSD云盘作为数据盘使用时，设置云盘的性能等级。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>PL0：单盘最高随机读写IOPS 1万。</description></item>
        /// <item><description>PL1（默认）：单盘最高随机读写IOPS 5万。</description></item>
        /// <item><description>PL2：单盘最高随机读写IOPS 10万。</description></item>
        /// <item><description>PL3：单盘最高随机读写IOPS 100万。</description></item>
        /// </list>
        /// <para>默认值：PL1。</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>单位GB。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
