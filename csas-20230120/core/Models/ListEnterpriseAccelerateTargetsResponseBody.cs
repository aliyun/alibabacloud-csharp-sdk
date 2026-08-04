// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListEnterpriseAccelerateTargetsResponseBody : TeaModel {
        /// <summary>
        /// <para>Enterprise Acceleration Policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eap-7fed37a757a0de24</para>
        /// </summary>
        [NameInMap("EapId")]
        [Validation(Required=false)]
        public string EapId { get; set; }

        /// <summary>
        /// <para>ID of the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>529F755E-2E75-52EC-9C2E-6293FB8BF986</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of enterprise acceleration targets.</para>
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<string> Targets { get; set; }

        /// <summary>
        /// <para>The total number of addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>103</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
