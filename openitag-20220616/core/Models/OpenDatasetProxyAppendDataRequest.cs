// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class OpenDatasetProxyAppendDataRequest : TeaModel {
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>A list of data records. A single invocation can contain up to 100 records. Each element in the array is a map.</para>
        /// </summary>
        [NameInMap("DataMeta")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> DataMeta { get; set; }

        /// <summary>
        /// <para>Task ID, indicating the task to which data is appended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>154***518306500608</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>TraceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1ec3916825622257033399edb6b</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

        /// <summary>
        /// <para>Unique identifier ID, controlled by the business side.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e5c9db3f-f27c-445e-a52b-06ba6d1ba00f</para>
        /// </summary>
        [NameInMap("UUID")]
        [Validation(Required=false)]
        public string UUID { get; set; }

    }

}
