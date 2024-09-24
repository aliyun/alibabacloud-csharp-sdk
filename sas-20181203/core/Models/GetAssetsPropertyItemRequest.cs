// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAssetsPropertyItemRequest : TeaModel {
        /// <summary>
        /// <para>The type of the asset fingerprint that you want to query. Default value: <b>sca</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lkm</b>: kernel module</description></item>
        /// <item><description><b>autorun</b>: startup item</description></item>
        /// <item><description><b>web_server</b>: website</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lkm</para>
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
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
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
        /// <para>The value of the search condition. You must specify this parameter based on the value of the <b>SearchItem</b> parameter.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>SearchItem</b> to <b>domain</b>, you must enter the domain name.</description></item>
        /// <item><description>If you set <b>SearchItem</b> to <b>module_name</b>, you must enter the module name.</description></item>
        /// <item><description>If you set <b>SearchItem</b> to <b>path</b>, you must enter the path to the self-starting item.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify both the <b>SearchItem</b> and <b>SearchInfo</b> parameters before you can query the information about asset fingerprints by asset fingerprint name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/lib/systemd/s****</para>
        /// </summary>
        [NameInMap("SearchInfo")]
        [Validation(Required=false)]
        public string SearchInfo { get; set; }

        /// <summary>
        /// <para>The type of the search condition. You must specify this parameter based on the value of the <b>Biz</b> parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <b>Biz</b> to <b>web_server</b>, set <b>SearchItem</b> to the following value:</para>
        /// <list type="bullet">
        /// <item><description><b>domain</b>: the domain name</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you set <b>Biz</b> to <b>lkm</b>, set <b>SearchItem</b> to the following value:</para>
        /// <list type="bullet">
        /// <item><description><b>module_name</b>: the name of the module</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you set <b>Biz</b> to <b>autorun</b>, set <b>SearchItem</b> to the following value:</para>
        /// <list type="bullet">
        /// <item><description><b>path</b>: the path to the self-starting item</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify both the <b>SearchItem</b> and <b>SearchInfo</b> parameters before you can query the information about asset fingerprints by asset fingerprint name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>path</para>
        /// </summary>
        [NameInMap("SearchItem")]
        [Validation(Required=false)]
        public string SearchItem { get; set; }

    }

}
