// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateDomainRequest : TeaModel {
        /// <summary>
        /// <para>域名。最大长度限制255，格式由数字、字母、横线（-）点（.）组成;</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>备案信息参数。</para>
        /// </summary>
        [NameInMap("Filing")]
        [Validation(Required=false)]
        public CreateDomainRequestFiling Filing { get; set; }
        public class CreateDomainRequestFiling : TeaModel {
            /// <summary>
            /// <para>域名关联的备案号，长度最大限制64。</para>
            /// 
            /// <b>Example:</b>
            /// <para>浙xx-xxxxxx</para>
            /// </summary>
            [NameInMap("IcpNumber")]
            [Validation(Required=false)]
            public string IcpNumber { get; set; }

        }

        /// <summary>
        /// <para>IDaaS EIAM实例的ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
