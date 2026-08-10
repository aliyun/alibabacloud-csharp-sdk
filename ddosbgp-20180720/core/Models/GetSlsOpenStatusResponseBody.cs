// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class GetSlsOpenStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D01666F5-541B-4C78-98A6-D29E02DAAC7C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether Simple Log Service is activated for the current Alibaba Cloud account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Simple Log Service is activated.</description></item>
        /// <item><description><b>false</b>: Simple Log Service is not activated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SlsOpenStatus")]
        [Validation(Required=false)]
        public bool? SlsOpenStatus { get; set; }

    }

}
