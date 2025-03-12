// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableCpuResourceRequest : TeaModel {
        /// <summary>
        /// <para>The CPU resources available.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob317v4uif****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <pre><c>http(s)://[Endpoint]/?Action=DescribeAvailableCpuResource
        /// &amp;InstanceId=ob317v4uif****
        /// &amp;TenantId=ob2mr3oae0****
        /// &amp;ModifyType=update
        /// &amp;Common request parameters
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>update</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform.<br>Set the value to <b>DescribeAvailableCpuResource</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob2mr3oae0****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
