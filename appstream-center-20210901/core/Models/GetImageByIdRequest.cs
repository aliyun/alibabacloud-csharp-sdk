// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetImageByIdRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the business region to query. If this parameter is not specified, regions are not filtered by this parameter. The returned regions are still subject to the visibility scope of the product and the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip the operating system and adaptation status filtering for adapted applications. Default value: false. A value of false indicates that only applications whose operating system matches the image and whose adaptation is complete are retained. A value of true indicates that these two filters are skipped. Application type filtering is still controlled by the API and ShowHidden.</para>
        /// </summary>
        [NameInMap("IgnoreFilter")]
        [Validation(Required=false)]
        public bool? IgnoreFilter { get; set; }

        /// <summary>
        /// <para>The image ID. You must specify at least one of ImageId and VersionId. If only this parameter is specified, the online version is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>imgc-bp1example****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The product type, such as CloudDesktop (Cloud Desktop), CloudApp (Cloud App), or WuyingServer (WUYING Workspace Enterprise Edition workstation).</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudDesktop</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The types of virtual applications to include in addition to the default user applications and system applications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VIRTUAL_DESKTOP_APP: desktop virtual applications.</description></item>
        /// <item><description>ALL_VIRTUAL_APP: all virtual applications.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VIRTUAL_DESKTOP_APP</para>
        /// </summary>
        [NameInMap("ShowHidden")]
        [Validation(Required=false)]
        public string ShowHidden { get; set; }

        /// <summary>
        /// <para>The image version ID. You can specify this parameter alone to query a specific version. If both ImageId and VersionId are specified, the version must belong to the specified image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iv-xxx</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
