// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ListRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of Regions.</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<RegionType> Regions { get; set; }

        /// <summary>
        /// <para>Request ID for the interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F7D235C-76FF-4B65-800C-8238AE3F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
