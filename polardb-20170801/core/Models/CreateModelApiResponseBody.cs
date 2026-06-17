// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateModelApiResponseBody : TeaModel {
        /// <summary>
        /// <para>The invocation endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("InvokeEndpoint")]
        [Validation(Required=false)]
        public string InvokeEndpoint { get; set; }

        /// <summary>
        /// <para>The model API ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mi-xxxxxx</para>
        /// </summary>
        [NameInMap("ModelApiId")]
        [Validation(Required=false)]
        public string ModelApiId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6BD9CDE4-5E7B-4BF3-9BB8-83C73E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The model API status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
