// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateDomainRequest : TeaModel {
        /// <summary>
        /// <para>The domain name of the website.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Registration information parameters.</para>
        /// </summary>
        [NameInMap("Filing")]
        [Validation(Required=false)]
        public CreateDomainRequestFiling Filing { get; set; }
        public class CreateDomainRequestFiling : TeaModel {
            /// <summary>
            /// <para>Record number associated with the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>浙xx-xxxxxx</para>
            /// </summary>
            [NameInMap("IcpNumber")]
            [Validation(Required=false)]
            public string IcpNumber { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
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
