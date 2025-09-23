// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetApplicationVariables4FailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetApplicationVariables4FailResponseBodyData> Data { get; set; }
        public class GetApplicationVariables4FailResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>instance_name</para>
            /// </summary>
            [NameInMap("Attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cadt-app-01</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>${name}</para>
            /// </summary>
            [NameInMap("PlaceHolder")]
            [Validation(Required=false)]
            public string PlaceHolder { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-shenzhen</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cadt-app-01</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>${name}</para>
            /// </summary>
            [NameInMap("Variable")]
            [Validation(Required=false)]
            public string Variable { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>BFB7F5C8-FE7A-06CA-9F87-ABBF6B848F0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
