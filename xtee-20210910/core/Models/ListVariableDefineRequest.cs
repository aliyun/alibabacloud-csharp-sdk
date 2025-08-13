// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class ListVariableDefineRequest : TeaModel {
        /// <summary>
        /// <para>Sets the language type for requests and received messages, default value is <b>zh</b>. Values: </para>
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
        /// <para>Whether binding is allowed, default is ENABLE</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLE</para>
        /// </summary>
        [NameInMap("allowBind")]
        [Validation(Required=false)]
        public string AllowBind { get; set; }

        /// <summary>
        /// <para>Charging mode</para>
        /// 
        /// <b>Example:</b>
        /// <para>FREE</para>
        /// </summary>
        [NameInMap("chargingMode")]
        [Validation(Required=false)]
        public string ChargingMode { get; set; }

        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Page size, default value is 10</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Paging identifier</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("paging")]
        [Validation(Required=false)]
        public string Paging { get; set; }

        /// <summary>
        /// <para>Query content</para>
        /// 
        /// <b>Example:</b>
        /// <para>age</para>
        /// </summary>
        [NameInMap("queryContent")]
        [Validation(Required=false)]
        public string QueryContent { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        /// <summary>
        /// <para>Authorization type</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("roleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

        /// <summary>
        /// <para>Scenario</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;EVENT_ACTION\&quot;]</para>
        /// </summary>
        [NameInMap("scenesStr")]
        [Validation(Required=false)]
        public string ScenesStr { get; set; }

        /// <summary>
        /// <para>Source</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAF</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>Status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLE</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>变量的title</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>Type</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;IDENTIFY_SERVICE\&quot;]</para>
        /// </summary>
        [NameInMap("typesStr")]
        [Validation(Required=false)]
        public string TypesStr { get; set; }

    }

}
