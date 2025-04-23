// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListImagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of images that are supported by E-HPC.</para>
        /// </summary>
        [NameInMap("OsTags")]
        [Validation(Required=false)]
        public ListImagesResponseBodyOsTags OsTags { get; set; }
        public class ListImagesResponseBodyOsTags : TeaModel {
            [NameInMap("OsInfo")]
            [Validation(Required=false)]
            public List<ListImagesResponseBodyOsTagsOsInfo> OsInfo { get; set; }
            public class ListImagesResponseBodyOsTagsOsInfo : TeaModel {
                /// <summary>
                /// <para>The architecture of the operating system. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>i386</description></item>
                /// <item><description>x86_64</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>i386</para>
                /// </summary>
                [NameInMap("Architecture")]
                [Validation(Required=false)]
                public string Architecture { get; set; }

                /// <summary>
                /// <para>The image tag of the operating system. The tag is used only for management nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS_7.2_64</para>
                /// </summary>
                [NameInMap("BaseOsTag")]
                [Validation(Required=false)]
                public string BaseOsTag { get; set; }

                /// <summary>
                /// <para>The ID of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-bp1h8aoe73p71iow****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The name of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS_7.2_64</para>
                /// </summary>
                [NameInMap("OSName")]
                [Validation(Required=false)]
                public string OSName { get; set; }

                /// <summary>
                /// <para>The name of the image in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS_7.2_64</para>
                /// </summary>
                [NameInMap("OSNameEn")]
                [Validation(Required=false)]
                public string OSNameEn { get; set; }

                /// <summary>
                /// <para>The tag that is added to the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS_7.2_64</para>
                /// </summary>
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public string OsTag { get; set; }

                /// <summary>
                /// <para>The operating system. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>CentOS</description></item>
                /// <item><description>windows</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CentOS</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// <para>The version of the operating system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7.2</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
