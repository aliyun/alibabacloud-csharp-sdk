// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ModifyInstanceTypeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of target instance. You can call <a href="https://help.aliyun.com/document_detail/144595.html">DescribeInstances</a> to obtain target instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hb-bp1x940uh********</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The new node specifications of the core node. You can invoke <a href="https://help.aliyun.com/document_detail/145796.html">DescribeInstanceType</a> to obtain the available node specifications.</para>
        /// <remarks>
        /// <para>You must specify either the MasterInstanceType parameter or the CoreInstanceType parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hbase.sn1.8xlarge</para>
        /// </summary>
        [NameInMap("CoreInstanceType")]
        [Validation(Required=false)]
        public string CoreInstanceType { get; set; }

        /// <summary>
        /// <para>The new node specifications of the master node. You can invoke <a href="https://help.aliyun.com/document_detail/145796.html">DescribeInstanceType</a> to obtain the available node specifications.</para>
        /// <remarks>
        /// <para>You must specify either the MasterInstanceType parameter or the CoreInstanceType parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hbase.sn1.large</para>
        /// </summary>
        [NameInMap("MasterInstanceType")]
        [Validation(Required=false)]
        public string MasterInstanceType { get; set; }

    }

}
