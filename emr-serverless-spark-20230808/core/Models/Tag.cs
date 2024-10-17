// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class Tag : TeaModel {
        /// <summary>
        /// <para>标签key值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>workflowId</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>标签key值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>wf-123test</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
