// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetDeploymentBySelectorResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried workloads.</para>
        /// </summary>
        [NameInMap("DeploymentNameList")]
        [Validation(Required=false)]
        public List<byte[]> DeploymentNameList { get; set; }

        /// <summary>
        /// <para>The end-of-data marker.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJ2IjoibWV0YS5rOHMuaW8vdjEiLCJydiI6NTgyMDUzMzk5MCwic3RhcnQiOiJwbXMtYWRhcHRlci1kZGxsXHUwMDA****</para>
        /// </summary>
        [NameInMap("Mark")]
        [Validation(Required=false)]
        public string Mark { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>946690C2-41D3-55A0-A501-E2FFAB5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
