// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ResourceDiagnosisDetail : TeaModel {
        /// <summary>
        /// <para>The exceeded resources.</para>
        /// </summary>
        [NameInMap("ExceedResources")]
        [Validation(Required=false)]
        public List<string> ExceedResources { get; set; }

        /// <summary>
        /// <para>The resource quota.</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public ResourceAmount Limit { get; set; }

        /// <summary>
        /// <para>The diagnosis status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The resource usage.</para>
        /// </summary>
        [NameInMap("Used")]
        [Validation(Required=false)]
        public ResourceAmount Used { get; set; }

        /// <summary>
        /// <para>The related workload IDs.</para>
        /// </summary>
        [NameInMap("WorkloadIds")]
        [Validation(Required=false)]
        public List<string> WorkloadIds { get; set; }

    }

}
