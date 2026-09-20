// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeInstanceTypeRequest : TeaModel {
        /// <summary>
        /// <para>The instance specification name. For more information, see <a href="https://help.aliyun.com/document_detail/194870.html">Instance node specifications</a>.</para>
        /// <remarks>
        /// <para>If InstanceType is left empty, all instance specifications are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hbase.n2.4xlarge</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

    }

}
