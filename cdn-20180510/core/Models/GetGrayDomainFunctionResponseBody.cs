// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class GetGrayDomainFunctionResponseBody : TeaModel {
        [NameInMap("DomainConfigList")]
        [Validation(Required=false)]
        public List<GetGrayDomainFunctionResponseBodyDomainConfigList> DomainConfigList { get; set; }
        public class GetGrayDomainFunctionResponseBodyDomainConfigList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>6295</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("FunctionArgs")]
            [Validation(Required=false)]
            public List<GetGrayDomainFunctionResponseBodyDomainConfigListFunctionArgs> FunctionArgs { get; set; }
            public class GetGrayDomainFunctionResponseBodyDomainConfigListFunctionArgs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>auth_type</para>
                /// </summary>
                [NameInMap("ArgName")]
                [Validation(Required=false)]
                public string ArgName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>req</para>
                /// </summary>
                [NameInMap("ArgValue")]
                [Validation(Required=false)]
                public string ArgValue { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ali_auth</para>
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>222728944812032</para>
            /// </summary>
            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("Progression")]
        [Validation(Required=false)]
        public string Progression { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C80705BF-0F76-41FA-BAD1-5B59296A4E59</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
