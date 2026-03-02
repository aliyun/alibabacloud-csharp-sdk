// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MobiInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>commit_pckesd7d_20230227215101</para>
        /// </summary>
        [NameInMap("mobiCommitId")]
        [Validation(Required=false)]
        public string MobiCommitId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("mobiId")]
        [Validation(Required=false)]
        public long? MobiId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>module_tvtpydeq</para>
        /// </summary>
        [NameInMap("mobiModuleId")]
        [Validation(Required=false)]
        public string MobiModuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sda</para>
        /// </summary>
        [NameInMap("storeUrl")]
        [Validation(Required=false)]
        public string StoreUrl { get; set; }

    }

}
