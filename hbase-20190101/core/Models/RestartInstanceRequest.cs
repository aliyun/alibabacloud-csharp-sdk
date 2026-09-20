// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class RestartInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of target instance. You can call <a href="https://help.aliyun.com/document_detail/144595.html">DescribeInstances</a> to obtain target instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp150tns0sjxs****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the component in the target instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HBASE</b></description></item>
        /// <item><description><b>HADOOP</b></description></item>
        /// <item><description><b>PHOENIX</b></description></item>
        /// <item><description><b>SOLR</b></description></item>
        /// <item><description><b>THRIFT</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>THRIFT</para>
        /// </summary>
        [NameInMap("Components")]
        [Validation(Required=false)]
        public string Components { get; set; }

    }

}
