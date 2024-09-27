// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetEpdInventoryConstituteResponseBody : TeaModel {
        /// <summary>
        /// <para>List of environmental impact results.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<EpdInventoryConstituteItem> Data { get; set; }

        /// <summary>
        /// <para>The ID of the request. The value is unique for each request. This facilitates subsequent troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83A5A7DD-8974-5769-952E-590A97BEA34E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
