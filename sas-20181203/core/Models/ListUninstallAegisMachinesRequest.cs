// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUninstallAegisMachinesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the first page to display in the query results. Default value: <b>1</b>, which indicates that the query results are displayed from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The operating system.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation to obtain supported operating systems from the <b>Values</b> of the item whose <b>Name</b> is <b>osType</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Default value: <b>5</b>, which indicates that 5 entries are displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the server resides.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation to obtain supported regions from the <b>Values</b> of the item whose <b>Name</b> is <b>regionId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionIdStr")]
        [Validation(Required=false)]
        public string RegionIdStr { get; set; }

        /// <summary>
        /// <para>The region where the server resides.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation to obtain supported regions from the <b>Values</b> of the item whose <b>Name</b> is <b>regionId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The asset information to query. You can set this parameter to the asset name or public IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180.113.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The server vendor. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Alibaba Cloud asset</description></item>
        /// <item><description><b>1</b>: non-cloud asset</description></item>
        /// <item><description><b>2</b>: IDC asset</description></item>
        /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, <b>7</b>: third-party cloud asset</description></item>
        /// <item><description><b>8</b>: lightweight asset.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public int? Vendor { get; set; }

    }

}
