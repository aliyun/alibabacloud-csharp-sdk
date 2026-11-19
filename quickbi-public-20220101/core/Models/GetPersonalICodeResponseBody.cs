// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class GetPersonalICodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BCE45E6D-9304-4F94-86BB-5A772B1615FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The AccessKey model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///         &quot;icode&quot;: &quot;V2Yc/dMFWBwTKLNCNxgnN<em><em><b>z</b></em>5ARu&quot;,
        ///         &quot;icodeKey&quot;: &quot;b6f3</em>**32a62936&quot;,
        ///         &quot;type&quot;: 1
        ///     }</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetPersonalICodeResponseBodyResult Result { get; set; }
        public class GetPersonalICodeResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>SK</para>
            /// 
            /// <b>Example:</b>
            /// <para>V2Yc/dMFWBwTKLNCNxgnN*<em><b>z</b></em>5ARu</para>
            /// </summary>
            [NameInMap("Icode")]
            [Validation(Required=false)]
            public string Icode { get; set; }

            /// <summary>
            /// <para>AK</para>
            /// 
            /// <b>Example:</b>
            /// <para>asdasd</para>
            /// </summary>
            [NameInMap("IcodeKey")]
            [Validation(Required=false)]
            public string IcodeKey { get; set; }

            /// <summary>
            /// <para>The AccessKey type. Currently, only the value 1 is supported, which indicates a personal AccessKey.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
