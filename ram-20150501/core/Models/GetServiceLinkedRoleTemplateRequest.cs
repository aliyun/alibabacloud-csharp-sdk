// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class GetServiceLinkedRoleTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The cloud service name.</para>
        /// <para>For more information, see the <b>Cloud service identity</b> column in <a href="https://help.aliyun.com/document_detail/461722.html">Cloud services that support service-linked roles</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polardb.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
