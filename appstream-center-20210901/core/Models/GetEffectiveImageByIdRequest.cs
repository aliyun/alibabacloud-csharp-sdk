// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetEffectiveImageByIdRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the business region to query. If this parameter is not specified, regions are not filtered by this parameter. The returned regions are still constrained by the product and the visible scope of the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The content language of the community image document in BCP 47 format, such as zh-CN or en-US. Default value: zh-CN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("ContentLocale")]
        [Validation(Required=false)]
        public string ContentLocale { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip filtering by the operating system and adaptation status of applications. Default value: false. A value of false retains only applications that match the image operating system and have completed adaptation. A value of true skips these two filters. Application type filtering is still controlled by the API operation and the ShowHidden parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IgnoreFilter")]
        [Validation(Required=false)]
        public bool? IgnoreFilter { get; set; }

        /// <summary>
        /// <para>The image ID. Required when querying effective versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-bp1example****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>System: System image.</description></item>
        /// <item><description>User: Custom image.</description></item>
        /// <item><description>Shared: Shared image.</description></item>
        /// <item><description>Community: Community image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// <para>The product type, such as CloudDesktop, CloudApp, or WuyingServer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudDesktop</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The additional types of virtual applications to include, in addition to the user and system applications returned by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VIRTUAL_DESKTOP_APP: Desktop virtual applications.</description></item>
        /// <item><description>ALL_VIRTUAL_APP: All virtual applications.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VIRTUAL_DESKTOP_APP</para>
        /// </summary>
        [NameInMap("ShowHidden")]
        [Validation(Required=false)]
        public string ShowHidden { get; set; }

    }

}
