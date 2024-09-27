// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeGlobalDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c213150d-7ac3-432c-b749-6e1e090b****</para>
        /// </summary>
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INTERNET</para>
        /// </summary>
        [NameInMap("DesktopAccessType")]
        [Validation(Required=false)]
        public string DesktopAccessType { get; set; }

        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DesktopTest</para>
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("DesktopStatus")]
        [Validation(Required=false)]
        public string DesktopStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-880841****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>关键字。支持模糊搜索桌面ID、云桌面名称和终端用户自定义的桌面名称。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("LoginRegionId")]
        [Validation(Required=false)]
        public string LoginRegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v147c9114a180489f89691663893169****</para>
        /// </summary>
        [NameInMap("LoginToken")]
        [Validation(Required=false)]
        public string LoginToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJkZWZhdWx0IjpbIjk2MjEy****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-880841****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AssignTime</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("QueryFotaUpdate")]
        [Validation(Required=false)]
        public bool? QueryFotaUpdate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("SearchRegionId")]
        [Validation(Required=false)]
        public string SearchRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5c456a41-1e65-4e72-ab4d-5dcfff52****</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithoutLatency")]
        [Validation(Required=false)]
        public bool? WithoutLatency { get; set; }

    }

}
