// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListDpiSignaturesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of applications.</para>
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
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>235</para>
            /// </summary>
            [NameInMap("DpiSignatureId")]
            [Validation(Required=false)]
            public string DpiSignatureId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EdgeCast</para>
            /// </summary>
            [NameInMap("DpiSignatureName")]
            [Validation(Required=false)]
            public string DpiSignatureName { get; set; }

            /// <summary>
            /// <para>The minimum version of the deep packet inspection (DPI) engine that supports the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0-0.0.1</para>
            /// </summary>
            [NameInMap("MinEngineVersion")]
            [Validation(Required=false)]
            public string MinEngineVersion { get; set; }

            /// <summary>
            /// <para>The minimum version of the signature library that supports the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20201117_1_0-0.0.1</para>
            /// </summary>
            [NameInMap("MinSignatureDbVersion")]
            [Validation(Required=false)]
            public string MinSignatureDbVersion { get; set; }

        }

        /// <summary>
        /// <para>The token for the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFrMV38kR4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63081123-B7C0-4BC9-B9E5-59E77A616EC9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of applications returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
