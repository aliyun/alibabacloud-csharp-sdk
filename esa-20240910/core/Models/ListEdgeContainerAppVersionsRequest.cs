// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListEdgeContainerAppVersionsRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can call the <a href="~~ListEdgeContainerApps~~">ListEdgeContainerApps</a> operation to obtain the application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The sort field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Name</b>: the version name.</description></item>
        /// <item><description><b>CreateTime</b>: the version creation time.</description></item>
        /// <item><description><b>ModifyTime</b>: the version modification time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Name</para>
        /// </summary>
        [NameInMap("OrderKey")]
        [Validation(Required=false)]
        public string OrderKey { get; set; }

        /// <summary>
        /// <para>The sort direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Asc</b>: ascending order.</para>
        /// </description></item>
        /// <item><description><para><b>Desc</b>: descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Desc</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: any integer from <b>1</b> to <b>65535</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size. Valid values: any integer from <b>1</b> to <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ver-100568263967926****</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The type for fuzzy match. Supported values: VersionId and Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VersionId</para>
        /// </summary>
        [NameInMap("SearchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

    }

}
