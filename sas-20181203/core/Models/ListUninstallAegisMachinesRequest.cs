// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUninstallAegisMachinesRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The operating system of the server.</para>
        /// <remarks>
        /// <para> The value of this parameter is the value of the Values parameter that is returned by calling the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation. If the value of the <b>Name</b> parameter in the response is <b>osType</b>, the value of the <b>Values</b> parameter indicates an operating system.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>5</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region in which the server resides.</para>
        /// <remarks>
        /// <para> The value of this parameter is the value of the Values parameter that is returned by calling the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation. If the value of the <b>Name</b> parameter in the response is <b>regionId</b>, the value of the <b>Values</b> parameter indicates a region ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionIdStr")]
        [Validation(Required=false)]
        public string RegionIdStr { get; set; }

        /// <summary>
        /// <para>The region in which the server resides.</para>
        /// <remarks>
        /// <para> The value of this parameter is the value of the Values parameter that is returned by calling the <a href="~~DescribeCriteria~~">DescribeCriteria</a> operation. If the value of the <b>Name</b> parameter in the response is <b>regionId</b>, the value of the <b>Values</b> parameter indicates a region ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The information about the server that you want to query. The value can be the name or the public IP address of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.20.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180.113.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The source of the server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: an asset provided by Alibaba Cloud.</description></item>
        /// <item><description><b>1</b>: a third-party cloud server</description></item>
        /// <item><description><b>2</b>: a server in a data center</description></item>
        /// <item><description><b>3</b>, <b>4</b>, <b>5</b>, and <b>7</b>: other cloud asset</description></item>
        /// <item><description><b>8</b>: a lightweight asset</description></item>
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
