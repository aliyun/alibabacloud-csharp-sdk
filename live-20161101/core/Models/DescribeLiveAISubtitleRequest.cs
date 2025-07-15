// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveAISubtitleRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query the default subtitle template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// <para>**</para>
        /// <para>**Note **The default template includes the built-in parameter configurations. You can specify the copyFrom parameter when you call the AddLiveAISubtitle operation to use the default template.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: [1,100].</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: [1,100].</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the subtitle template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("SubtitleId")]
        [Validation(Required=false)]
        public string SubtitleId { get; set; }

        /// <summary>
        /// <para>The name of the subtitle template. The name can contain only digits, letters, and hyphens (-). The name cannot start with a hyphen.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sub01</para>
        /// </summary>
        [NameInMap("SubtitleName")]
        [Validation(Required=false)]
        public string SubtitleName { get; set; }

    }

}
