// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchBindTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>Result list.</para>
        /// </summary>
        [NameInMap("Bindings")]
        [Validation(Required=false)]
        public List<BatchBindTemplateResponseBodyBindings> Bindings { get; set; }
        public class BatchBindTemplateResponseBodyBindings : TeaModel {
            /// <summary>
            /// <para>Error message.</para>
            /// <remarks>
            /// <para>This field exists only when the operation fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>some error</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>323*****994-cn-qingdao</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>323*****998-cn-qingdao</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
