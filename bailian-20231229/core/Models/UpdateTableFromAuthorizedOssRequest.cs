// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class UpdateTableFromAuthorizedOssRequest : TeaModel {
        /// <summary>
        /// <para>Name of the OSS bucket. For details, see <a href="https://help.aliyun.com/document_detail/177682.html">bucket</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yinghuo-ai</para>
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <para>Object key of the file in the OSS bucket. For details, see <a href="https://help.aliyun.com/document_detail/273129.html">object naming</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a0deedbce4a8162b8d66c63ace28330c</para>
        /// </summary>
        [NameInMap("OssKey")]
        [Validation(Required=false)]
        public string OssKey { get; set; }

        /// <summary>
        /// <para>Region ID of the OSS bucket. For details, see <a href="https://help.aliyun.com/document_detail/31837.html">OSS regions and endpoints</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("OssRegionId")]
        [Validation(Required=false)]
        public string OssRegionId { get; set; }

        /// <summary>
        /// <para>Update mode. Valid values: APPEND and OVERWRITE.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OVERWRITE</para>
        /// </summary>
        [NameInMap("UpdateMode")]
        [Validation(Required=false)]
        public string UpdateMode { get; set; }

    }

}
