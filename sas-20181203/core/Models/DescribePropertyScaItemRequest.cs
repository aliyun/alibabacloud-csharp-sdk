// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyScaItemRequest : TeaModel {
        /// <summary>
        /// <para>The type of the asset fingerprint that you want to query. Default value: <b>sca</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sca</b>: middleware</description></item>
        /// <item><description><b>sca_database</b>: database</description></item>
        /// <item><description><b>sca_web</b>: web service</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the default value <b>sca</b> is used, which indicates that middleware fingerprints are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sca</para>
        /// </summary>
        [NameInMap("Biz")]
        [Validation(Required=false)]
        public string Biz { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully refresh the data that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceFlush")]
        [Validation(Required=false)]
        public bool? ForceFlush { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <remarks>
        /// <para>We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search keyword. You must specify this parameter based on the value of the <b>SearchItem</b> parameter.</para>
        /// <list type="bullet">
        /// <item><description><para>If the <b>SearchItem</b> parameter is set to <b>name</b>, you must enter the name of an asset fingerprint.</para>
        /// </description></item>
        /// <item><description><para>If the <b>SearchItem</b> parameter is set to <b>type</b>, you must enter the type of an asset fingerprint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>system_service</b>: system service</description></item>
        /// <item><description><b>software_library</b>: software library</description></item>
        /// <item><description><b>docker_component</b>: container component</description></item>
        /// <item><description><b>database</b>: database</description></item>
        /// <item><description><b>web_container</b>: web container</description></item>
        /// <item><description><b>jar</b>: JAR package</description></item>
        /// <item><description><b>web_framework</b>: web framework</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify both the <b>SearchItem</b> and <b>SearchInfo</b> parameters before you can query the asset fingerprints based on the specified name or type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>system_service</para>
        /// </summary>
        [NameInMap("SearchInfo")]
        [Validation(Required=false)]
        public string SearchInfo { get; set; }

        /// <summary>
        /// <para>The type of the search condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the name of a database, middleware, or web service</description></item>
        /// <item><description><b>type</b>: the type of a database, middleware, or web service</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify both the <b>SearchItem</b> and <b>SearchInfo</b> parameters before you can query the asset fingerprints based on the specified name or type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>type</para>
        /// </summary>
        [NameInMap("SearchItem")]
        [Validation(Required=false)]
        public string SearchItem { get; set; }

    }

}
