// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class AddUserHdfsInfoRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cluster ID. You can call the <a href="https://help.aliyun.com/document_detail/144595.html">DescribeInstances</a> operation to obtain the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hb-bp16o0pd5****582s</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>dfs.nameservices specifies the nameservices name of DFS. dfs.ha.namenodes specifies the DFS nodes, such as nn1 and nn2.
        /// dfs.namenode.http-address.{dfs.nameservices}.nn1 specifies the port 50070 connection of HDFS nn1.
        /// dfs.namenode.http-address.{dfs.nameservices}.nn2 specifies the port 50070 connection of HDFS nn2.
        /// dfs.namenode.rpc-address.{dfs.nameservices}.nn1 specifies the port 8020 connection of HDFS nn1.
        /// dfs.namenode.rpc-address.{dfs.nameservices}.nn2 specifies the port 8020 connection of HDFS nn2.
        /// Port 50070 connections and port 8020 connections exist on each HDFS node. The number of port 50070 and port 8020 connection pairs equals the number of HDFS nodes.</para>
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
