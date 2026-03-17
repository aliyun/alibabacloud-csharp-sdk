// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class GetAclAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the ACL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-xhwhyuo43l0n*****</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>The name of the ACL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dpi_test</para>
        /// </summary>
        [NameInMap("AclName")]
        [Validation(Required=false)]
        public string AclName { get; set; }

        /// <summary>
        /// <para>The number of SAG devices that are associated with the ACL who has DPI configuration errors.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/197566.html">ListDpiConfigError</a> operation to query exception details and SAG device information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ErrorConfigSmartAGCount")]
        [Validation(Required=false)]
        public int? ErrorConfigSmartAGCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D2013F0-85AB-4332-9094-8023A598C2C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
