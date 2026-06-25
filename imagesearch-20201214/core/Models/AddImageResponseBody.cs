// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class AddImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description>0: success.</description></item>
        /// <item><description>Non-zero: failure.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// <remarks>
        /// <para>No data is returned for successful requests. Error messages are returned for failed requests.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The category prediction and subject identification results.</para>
        /// </summary>
        [NameInMap("PicInfo")]
        [Validation(Required=false)]
        public AddImageResponseBodyPicInfo PicInfo { get; set; }
        public class AddImageResponseBodyPicInfo : TeaModel {
            /// <summary>
            /// <para>The information about all categories supported by the system.</para>
            /// </summary>
            [NameInMap("AllCategories")]
            [Validation(Required=false)]
            public List<AddImageResponseBodyPicInfoAllCategories> AllCategories { get; set; }
            public class AddImageResponseBodyPicInfoAllCategories : TeaModel {
                /// <summary>
                /// <para>The category ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88888888</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// <para>The category name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Other</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The category prediction result. If the user specifies a category in the request, the specified category is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88888888</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public int? CategoryId { get; set; }

            /// <summary>
            /// <para>The collection of subject identification results.</para>
            /// <remarks>
            /// <para>Upgrade to V3.1.1 or later to use this feature.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("MultiRegion")]
            [Validation(Required=false)]
            public List<AddImageResponseBodyPicInfoMultiRegion> MultiRegion { get; set; }
            public class AddImageResponseBodyPicInfoMultiRegion : TeaModel {
                /// <summary>
                /// <para>The subject identification result. The subject region of the image, in the format of x1,x2,y1,y2, where x1,y1 is the upper-left point and x2,y2 is the lower-right point. If the user specifies a subject region in the request, the specified region is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>94,691,206,650</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

            /// <summary>
            /// <para>The subject identification result. The subject region of the image, in the format of <c>x1,x2,y1,y2</c>, where <c>x1,y1</c> is the upper-left point and <c>x2,y2</c> is the lower-right point. If the user specifies a subject region in the request, the specified region is used.</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
