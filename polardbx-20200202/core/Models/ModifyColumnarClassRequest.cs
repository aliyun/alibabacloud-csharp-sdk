// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class ModifyColumnarClassRequest : TeaModel {
        /// <summary>
        /// <para>The column store specifications.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polarx.n8.large.col</para>
        /// </summary>
        [NameInMap("ColumnarClass")]
        [Validation(Required=false)]
        public string ColumnarClass { get; set; }

        /// <summary>
        /// <para>The number of column store nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>**</para>
        /// </summary>
        [NameInMap("ColumnarNodeCount")]
        [Validation(Required=false)]
        public string ColumnarNodeCount { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-hzrh51fze****pon-cdc</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The region in which the instance resides. &gt; You can call the <a href="https://help.aliyun.com/document_detail/196841.html">DescribeRegions</a> operation to query the regions supported by PolarDB-X, including region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The switch mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public string SwitchMode { get; set; }

    }

}
