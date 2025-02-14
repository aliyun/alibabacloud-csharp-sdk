// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListMachineAppsRequest : TeaModel {
        /// <summary>
        /// <para>SAE application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b41f4bf-349f-4263-89b1-9234c034****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>SAE application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-commprice-shop</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AppRegionId")]
        [Validation(Required=false)]
        public string AppRegionId { get; set; }

        /// <summary>
        /// <para>The authorization version of the asset. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>6</b>: Anti-virus edition</description></item>
        /// <item><description><b>5</b>: Advanced edition</description></item>
        /// <item><description><b>3</b>: Enterprise edition</description></item>
        /// <item><description><b>7</b>: Ultimate edition</description></item>
        /// <item><description><b>10</b>: Value-added Service Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("AuthVersion")]
        [Validation(Required=false)]
        public string AuthVersion { get; set; }

        /// <summary>
        /// <para>The page number to display in a paginated query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The language type for request and response, default value is <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of items to display per page in a paginated query.</para>
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
