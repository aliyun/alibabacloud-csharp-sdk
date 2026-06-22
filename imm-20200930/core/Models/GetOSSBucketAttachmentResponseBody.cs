// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetOSSBucketAttachmentResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the dataset was created. The value is a UTC timestamp in ISO 8601 format with millisecond precision.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;2023-12-19T17:29:34.790931971+08:00&quot;</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The dataset description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;数据集&quot;</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the bound project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5F74C5C9-5AC0-49F9-914D-E01589D3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the dataset was last updated. The value is a UTC timestamp in ISO 8601 format with millisecond precision.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;2023-12-19T17:29:34.790931971+08:00&quot;</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
