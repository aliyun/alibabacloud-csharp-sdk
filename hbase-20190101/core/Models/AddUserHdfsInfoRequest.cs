// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class AddUserHdfsInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hb-bp16o0pd5****582s</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dfs.nameservices&quot;:&quot;hdfs_test&quot;,&quot;dfs.ha.namenodes&quot;:&quot;nn1,nn2&quot;,&quot;dfs.namenode.http-address.hdfs_test.nn1&quot;:&quot;TEST-xxx1.com:50070&quot;,&quot;dfs.namenode.http-address.hdfs_test.nn2&quot;:&quot;TEST-xxx2.com:50070&quot;,&quot;dfs.namenode.rpc-address.hdfs_test.nn1&quot;:&quot;TEST-xxx1.com:8020&quot;,&quot;dfs.namenode.rpc-address.hdfs_test.nn2&quot;:&quot;TEST-xxx2.com:8020&quot;}</para>
        /// </summary>
        [NameInMap("ExtInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

    }

}
