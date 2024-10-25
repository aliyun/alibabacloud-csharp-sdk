// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeAICImagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the images.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<DescribeAICImagesResponseBodyImages> Images { get; set; }
        public class DescribeAICImagesResponseBodyImages : TeaModel {
            /// <summary>
            /// <para>The time when the image was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-09-22 10:54:34</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test operation of console</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The image ID of the AIC instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-ad0ddaddc2d54adeaa09b7c0f1e****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The URL of the AIC image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>****.alibaba-inc.com/aic/socimage:test</para>
            /// </summary>
            [NameInMap("ImageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The status of the image. <b>Available</b> is returned for this parameter. Available indicates that the image is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The username of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72DC6C0A-D9A8-5345-A2BE-FE354CC728A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
