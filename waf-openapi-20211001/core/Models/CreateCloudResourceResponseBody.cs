// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateCloudResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the resource that is added to WAF. The ID is automatically generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-***</para>
        /// </summary>
        [NameInMap("CloudResourceId")]
        [Validation(Required=false)]
        public string CloudResourceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66A98669-ER12-WE34-23PO-301469*****E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
