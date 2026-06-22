// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListMachineAppsRequest : TeaModel {
        /// <summary>
        /// <para>The SAE application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b41f4bf-349f-4263-89b1-9234c034****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The SAE application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-commprice-shop</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AppRegionId")]
        [Validation(Required=false)]
        public string AppRegionId { get; set; }

        /// <summary>
        /// <para>The authorization version of the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>6</b>: Anti-virus Edition</description></item>
        /// <item><description><b>5</b>: Premium Edition</description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>7</b>: Ultimate Edition</description></item>
        /// <item><description><b>10</b>: value-added service Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("AuthVersion")]
        [Validation(Required=false)]
        public string AuthVersion { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The UID of the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("ResourceDirectoryUid")]
        [Validation(Required=false)]
        public long? ResourceDirectoryUid { get; set; }

    }

}
