// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddUnknownThreatDetectProcessResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of results for the added processes.</para>
        /// </summary>
        [NameInMap("IdList")]
        [Validation(Required=false)]
        public List<AddUnknownThreatDetectProcessResponseBodyIdList> IdList { get; set; }
        public class AddUnknownThreatDetectProcessResponseBodyIdList : TeaModel {
            /// <summary>
            /// <para>The ID generated for the added process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>92666883</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADE57832-9666-511C-9A80-B87DE2E8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
