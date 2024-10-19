// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class SetVpcAccessResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ015</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC access authorization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4c68e061860f441ab72af7404137440e</para>
        /// </summary>
        [NameInMap("VpcAccessId")]
        [Validation(Required=false)]
        public string VpcAccessId { get; set; }

    }

}
