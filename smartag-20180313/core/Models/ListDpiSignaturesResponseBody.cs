// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListDpiSignaturesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the application.</para>
        /// </summary>
        [NameInMap("DpiSignature")]
        [Validation(Required=false)]
        public List<ListDpiSignaturesResponseBodyDpiSignature> DpiSignature { get; set; }
        public class ListDpiSignaturesResponseBodyDpiSignature : TeaModel {
            /// <summary>
            /// <para>The ID of the application group to which the application belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("DpiGroupId")]
            [Validation(Required=false)]
            public string DpiGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>235</para>
            /// </summary>
            [NameInMap("DpiSignatureId")]
            [Validation(Required=false)]
            public string DpiSignatureId { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EdgeCast</para>
            /// </summary>
            [NameInMap("DpiSignatureName")]
            [Validation(Required=false)]
            public string DpiSignatureName { get; set; }

            /// <summary>
            /// <para>The earliest version of engine that supports the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0-0.0.1</para>
            /// </summary>
            [NameInMap("MinEngineVersion")]
            [Validation(Required=false)]
            public string MinEngineVersion { get; set; }

            /// <summary>
            /// <para>The earliest version of signature database that supports the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20201117_1_0-0.0.1</para>
            /// </summary>
            [NameInMap("MinSignatureDbVersion")]
            [Validation(Required=false)]
            public string MinSignatureDbVersion { get; set; }

        }

        /// <summary>
        /// <para>The token returned for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFrMV38kR4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63081123-B7C0-4BC9-B9E5-59E77A616EC9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
