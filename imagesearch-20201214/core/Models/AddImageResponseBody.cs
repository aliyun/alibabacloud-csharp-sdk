// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class AddImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The code returned.</para>
        /// <list type="bullet">
        /// <item><description>A value of 0 indicates that the request was successful.</description></item>
        /// <item><description>Values other than 0 indicate that the request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// <remarks>
        /// <para>No value is returned if the request was successful, and an error message is returned if the request failed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The results of category prediction and subject identification.</para>
        /// </summary>
        [NameInMap("PicInfo")]
        [Validation(Required=false)]
        public AddImageResponseBodyPicInfo PicInfo { get; set; }
        public class AddImageResponseBodyPicInfo : TeaModel {
            /// <summary>
            /// <para>The result of category prediction. If a category is specified in the request, the specified category prevails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88888888</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public int? CategoryId { get; set; }

            /// <summary>
            /// <para>The result of subject identification. The subject area of the image is in the format of <c>x1,x2,y1,y2</c>. <c>x1 and y1</c> represent the position in the upper-left corner, in pixels. <c>x2 and y2</c> represent the position in the lower-right corner, in pixels. If a subject area is specified in the request, the specified subject area prevails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>94,691,206,650</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0845DE6-52AF-4B50-9F15-51ED4044E6AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
