// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class RunApplicationActionResponseBody : TeaModel {
        /// <summary>
        /// <para>The abnormal nodes.</para>
        /// </summary>
        [NameInMap("AbnInstances")]
        [Validation(Required=false)]
        public List<RunApplicationActionResponseBodyAbnInstances> AbnInstances { get; set; }
        public class RunApplicationActionResponseBodyAbnInstances : TeaModel {
            /// <summary>
            /// <para>The ID of the abnormal node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1cudc25w2bfwl5****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The name of the abnormal node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>core1-1</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

        }

        /// <summary>
        /// <para>The operation ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>op-13c37a77c505****</para>
        /// </summary>
        [NameInMap("OperationId")]
        [Validation(Required=false)]
        public string OperationId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E3A7161-EB7B-172B-8D18-FFB06BA3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
