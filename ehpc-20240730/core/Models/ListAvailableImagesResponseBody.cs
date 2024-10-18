// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListAvailableImagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the images.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<ListAvailableImagesResponseBodyImages> Images { get; set; }
        public class ListAvailableImagesResponseBodyImages : TeaModel {
            /// <summary>
            /// <para>The OS architecture of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>x86_64</description></item>
            /// <item><description>arm64</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>x86_64</para>
            /// </summary>
            [NameInMap("Architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            /// <summary>
            /// <para>The boot mode of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BIOS: Basic Input/Output System (BIOS)</description></item>
            /// <item><description>UEFI: Unified Extensible Firmware Interface (UEFI)</description></item>
            /// </list>
            /// <remarks>
            /// <para> When you change the OS boot mode of an instance, you must make sure that the boot mode matches the boot mode of the associated image. Otherwise, the instance fails to be booted.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>BIOS</para>
            /// </summary>
            [NameInMap("BootMode")]
            [Validation(Required=false)]
            public string BootMode { get; set; }

            /// <summary>
            /// <para>The image description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExampleDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>centos_7_06_64_20G_alibase_2019071****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHESS5V5.0.27</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The image source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system: system images</description></item>
            /// <item><description>self: custom images</description></item>
            /// <item><description>others: shared images</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>self</para>
            /// </summary>
            [NameInMap("ImageOwnerAlias")]
            [Validation(Required=false)]
            public string ImageOwnerAlias { get; set; }

            /// <summary>
            /// <para>The OS name in Chinese.</para>
            /// </summary>
            [NameInMap("OSName")]
            [Validation(Required=false)]
            public string OSName { get; set; }

            /// <summary>
            /// <para>The OS name in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CentOS  7.9 64 bit</para>
            /// </summary>
            [NameInMap("OSNameEn")]
            [Validation(Required=false)]
            public string OSNameEn { get; set; }

            /// <summary>
            /// <para>The OS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CentOS</description></item>
            /// <item><description>windows</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The image size. Unit: GiB</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
