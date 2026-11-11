// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListRelatedResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This field is returned when the request fails. A successful response may not contain this field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListRelatedResourceResponseBodyData Data { get; set; }
        public class ListRelatedResourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of cloud desktops associated with the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public int? DesktopCount { get; set; }

            /// <summary>
            /// <para>The number of cloud desktop pools associated with the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DesktopGroupCount")]
            [Validation(Required=false)]
            public int? DesktopGroupCount { get; set; }

            /// <summary>
            /// <para>The number of associated templates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateCount")]
            [Validation(Required=false)]
            public int? TemplateCount { get; set; }

        }

        /// <summary>
        /// <para>The description of the request processing result. The value <c>success</c> is typically returned when the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. A value of true indicates that the request is successful, and a value of false indicates that the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
