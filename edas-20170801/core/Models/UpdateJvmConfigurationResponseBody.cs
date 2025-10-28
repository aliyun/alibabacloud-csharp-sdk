// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateJvmConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The settings of the JVM parameters.</para>
        /// </summary>
        [NameInMap("JvmConfiguration")]
        [Validation(Required=false)]
        public UpdateJvmConfigurationResponseBodyJvmConfiguration JvmConfiguration { get; set; }
        public class UpdateJvmConfigurationResponseBodyJvmConfiguration : TeaModel {
            /// <summary>
            /// <para>The maximum size of the heap memory. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("MaxHeapSize")]
            [Validation(Required=false)]
            public int? MaxHeapSize { get; set; }

            /// <summary>
            /// <para>The size of the permanent generation heap memory. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxPermSize")]
            [Validation(Required=false)]
            public int? MaxPermSize { get; set; }

            /// <summary>
            /// <para>The initial size of the heap memory. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("MinHeapSize")]
            [Validation(Required=false)]
            public int? MinHeapSize { get; set; }

            /// <summary>
            /// <para>The optional parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>”“</para>
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

        }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D16979DC-4D42-********************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
