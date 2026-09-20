// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DeleteUserHdfsInfoRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hb-bp16o0pd52e3y****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The value of dfs.nameservices in addUserHdfsInfo. This value is returned when you call the <a href="https://help.aliyun.com/document_detail/144509.html">QueryXpackRelateDB</a> operation with relateDB set to hdfs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdfs_test</para>
        /// </summary>
        [NameInMap("NameService")]
        [Validation(Required=false)]
        public string NameService { get; set; }

    }

}
