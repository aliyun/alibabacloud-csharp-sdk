// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListVirusScanAdditionalListsRequest : TeaModel {
        /// <summary>
        /// <para>Filters by match dimension. Duplicate values are not allowed. If this parameter is not specified, all match dimensions are returned.</para>
        /// </summary>
        [NameInMap("AdditionalTypes")]
        [Validation(Required=false)]
        public List<string> AdditionalTypes { get; set; }

        /// <summary>
        /// <para>The operating system type for which the list takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>windows</b>: Windows.</description></item>
        /// <item><description><b>macOS</b>: macOS.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>windows</para>
        /// </summary>
        [NameInMap("DevType")]
        [Validation(Required=false)]
        public string DevType { get; set; }

        /// <summary>
        /// <para>The content of the list entry. Exact match is used. This parameter is used to locate a specific list by content. Fuzzy match is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.tmp</para>
        /// </summary>
        [NameInMap("ListDetail")]
        [Validation(Required=false)]
        public string ListDetail { get; set; }

        /// <summary>
        /// <para>Filters by list entry ID. Duplicate values are not allowed. If this parameter is not specified, no filtering by list entry ID is performed.</para>
        /// </summary>
        [NameInMap("ListIds")]
        [Validation(Required=false)]
        public List<string> ListIds { get; set; }

        /// <summary>
        /// <para>Filters by list type. If this parameter is not specified, both blacklists and whitelists are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Blacklist</b>: Blacklist. Matched files are directly identified as virus files.</description></item>
        /// <item><description><b>Whitelist</b>: Whitelist. Matched files are excluded from virus detection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Whitelist</para>
        /// </summary>
        [NameInMap("ListType")]
        [Validation(Required=false)]
        public string ListType { get; set; }

    }

}
