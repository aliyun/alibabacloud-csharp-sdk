// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeMultiZoneClusterRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the multi-zone instance. You can call <a href="https://help.aliyun.com/document_detail/144595.html">DescribeInstances</a> to obtain the list. The multi-zone instance has <b>DbType</b> set to hbaseue and <b>ModuleStackVersion</b> set to 2.0.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-t4nn71xa0yn****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
