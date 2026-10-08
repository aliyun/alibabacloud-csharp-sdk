// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class DeleteContactTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the contact templates to delete. Separate multiple values with commas (,).</para>
        /// <para>The system automatically generates an ID upon successful creation of a contact template. You can invoke the <a href="https://help.aliyun.com/document_detail/67701.html">QueryRegistrantProfiles</a> API to query the template IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123,45,67</para>
        /// </summary>
        [NameInMap("RegistrantProfileIds")]
        [Validation(Required=false)]
        public string RegistrantProfileIds { get; set; }

        /// <summary>
        /// <para>User IP address. You can set this parameter to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
