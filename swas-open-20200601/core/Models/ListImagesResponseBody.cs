// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class ListImagesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the queried images.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<ListImagesResponseBodyImages> Images { get; set; }
        public class ListImagesResponseBodyImages : TeaModel {
            /// <summary>
            /// <para>The description of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Apps ImageOS ImageCustom Images
            /// WordPress is a popular and powerful platform that allows you to build blogs and content management websites and implement custom features by using third-party templates and plug-ins. This WordPress image is built based on CentOS 7.9, PHP 7.4, MySQL 5.7, and Apache 2.4.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>794c230fd3e64ea19f83f4d7a0ad****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The name of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WordPress-4.8.1</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The type of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system</description></item>
            /// <item><description>app</description></item>
            /// <item><description>custom</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            /// <summary>
            /// <para>The operating system type of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Linux</description></item>
            /// <item><description>Windows</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20758A-585D-4A41-A9B2-28DA8F4F534F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
