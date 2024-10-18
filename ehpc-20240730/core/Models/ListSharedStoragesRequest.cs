// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListSharedStoragesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the attached file system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bd504b0**</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The type of the attached file system. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>nas</description></item>
        /// <item><description>cpfs</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>nas</para>
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

    }

}
