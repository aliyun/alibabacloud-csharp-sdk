// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAssetsPropertyItemRequest : TeaModel {
        /// <summary>
        /// <para>The type of Asset Fingerprints to query. Default value: <b>sca</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lkm</b>: kernel module</description></item>
        /// <item><description><b>autorun</b>: startup item</description></item>
        /// <item><description><b>web_server</b>: website.</description></item>
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
        /// <para>The page number of the page to return. Default value: <b>1</b>, which indicates the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully refresh the data to be queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Forcefully refresh.</description></item>
        /// <item><description><b>false</b>: Do not forcefully refresh.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceFlush")]
        [Validation(Required=false)]
        public bool? ForceFlush { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page when using paging. Default value: 20. If the PageSize parameter is left empty, 20 entries are returned by default.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The content to query. Specify different query content based on the value of <b>SearchItem</b>:</para>
        /// <list type="bullet">
        /// <item><description>If <b>SearchItem</b> is set to <b>domain</b>, enter the domain name of the Asset Fingerprints entry.</description></item>
        /// <item><description>If <b>SearchItem</b> is set to <b>module_name</b>, enter the module name of the Asset Fingerprints entry.</description></item>
        /// <item><description>If <b>SearchItem</b> is set to <b>path</b>, enter the startup item path of the Asset Fingerprints entry.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The <b>SearchItem</b> and <b>SearchInfo</b> parameters must be used together. Both parameters must be set at the same time for the query to take effect. Setting only one parameter does not take effect. You can use these parameters to query all data of a specific Asset Fingerprints entry by name.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/lib/systemd/s****</para>
        /// </summary>
        [NameInMap("SearchInfo")]
        [Validation(Required=false)]
        public string SearchInfo { get; set; }

        /// <summary>
        /// <para>The type of query condition. Set different aggregation search conditions based on the <b>Biz</b> parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>Biz</b> is set to <b>web_server</b>, the following search conditions are supported for <b>SearchItem</b>:<list type="bullet">
        /// <item><description><b>domain</b>: domain name</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If <b>Biz</b> is set to <b>lkm</b>, the following search conditions are supported for <b>SearchItem</b>:<list type="bullet">
        /// <item><description><b>module_name</b>: module name</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If <b>Biz</b> is set to <b>autorun</b>, the following search conditions are supported for <b>SearchItem</b>:<list type="bullet">
        /// <item><description><b>path</b>: startup item path<remarks>
        /// <para>The <b>SearchItem</b> and <b>SearchInfo</b> parameters must be used together. Both parameters must be set at the same time for the query to take effect. Setting only one parameter does not take effect. You can use these parameters to query all data of a specific Asset Fingerprints entry by name.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>path</para>
        /// </summary>
        [NameInMap("SearchItem")]
        [Validation(Required=false)]
        public string SearchItem { get; set; }

    }

}
