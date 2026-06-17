// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSecurityModeResponseBody : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The application module.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg_server</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        [Obsolete]
        public string Module { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C6D68A02-54D5-5F5C-A8AA-6D6C2874****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The security mode. Valid values:</para>
        /// <para><b>0</b>: disabled.</para>
        /// <para><b>1</b>: enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SecurityMode")]
        [Validation(Required=false)]
        public int? SecurityMode { get; set; }

    }

}
