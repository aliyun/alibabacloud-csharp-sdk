// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListAvailableImagesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The information about the domain account service.</para>
        /// </summary>
        [NameInMap("DirectoryService")]
        [Validation(Required=false)]
        public string DirectoryServiceShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to return images in which hyper-threading is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableHT")]
        [Validation(Required=false)]
        public bool? EnableHT { get; set; }

        /// <summary>
        /// <para>The network type of the images that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("HPCInterConnect")]
        [Validation(Required=false)]
        public string HPCInterConnect { get; set; }

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
        /// <para>The instance type for which you want to query available images. If you do not specify the instance type, all available images are returned, regardless of the supported instance types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c7.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether to return published community images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: returns published community images. If you set the value of this parameter to true, the ImageOwnerAlias parameter must be set to others.</description></item>
        /// <item><description>false: returns non-community images. The value of the ImageOwnerAlias parameter prevails.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsPublic")]
        [Validation(Required=false)]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// <para>The page number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 50. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The scheduler information about the images that you want to query.</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string SchedulerShrink { get; set; }

    }

}
