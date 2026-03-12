// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class KibanaNodeConfiguration : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("disk")]
        [Validation(Required=false)]
        public long? Disk { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>elasticsearch.sn2ne.large</para>
        /// </summary>
        [NameInMap("spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
