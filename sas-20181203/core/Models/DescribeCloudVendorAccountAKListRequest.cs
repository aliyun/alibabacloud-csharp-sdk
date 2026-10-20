// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCloudVendorAccountAKListRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the AK.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2624</para>
        /// </summary>
        [NameInMap("AuthIds")]
        [Validation(Required=false)]
        public string AuthIds { get; set; }

        /// <summary>
        /// <para>The page number of the current page during paging. Default value: 1.</para>
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
        /// <item><description><b>zh</b>: Chinese.</description></item>
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
        /// <para>The maximum number of entries to return on each page during paging. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the AK. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Enabled.</description></item>
        /// <item><description><b>1</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The username of the sub-account of the cloud service provider to which the AK belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AlibabaCloud_***</para>
        /// </summary>
        [NameInMap("SubAccountName")]
        [Validation(Required=false)]
        public string SubAccountName { get; set; }

        /// <summary>
        /// <para>The cloud service provider. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Tencent</b>: Tencent Cloud.</description></item>
        /// <item><description><b>HUAWEICLOUD</b>: Huawei Cloud.</description></item>
        /// <item><description><b>Azure</b>: Azure.</description></item>
        /// <item><description><b>AWS</b>: AWS.</description></item>
        /// <item><description><b>VOLCENGINE</b>: Volcengine.</description></item>
        /// <item><description><b>google</b>: Google Cloud.</description></item>
        /// <item><description><b>CHAITIN</b>: Chaitin Tech.</description></item>
        /// <item><description><b>FORTINET</b>: Fortinet.</description></item>
        /// <item><description><b>THREATBOOK</b>: ThreatBook.</description></item>
        /// <item><description><b>KingsoftCloud</b>: Kingsoft Cloud.</description></item>
        /// <item><description><b>UCloud</b>: UCloud.</description></item>
        /// <item><description><b>BaiduCloud</b>: Baidu AI Cloud.</description></item>
        /// <item><description><b>WIZ</b>: Wiz.</description></item>
        /// <item><description><b>OracleCloud</b>: Oracle Cloud.</description></item>
        /// <item><description><b>StateCloud</b>: CTYun.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VOLCENGINE</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

        /// <summary>
        /// <para>The name of the AK account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("VendorAuthAlias")]
        [Validation(Required=false)]
        public string VendorAuthAlias { get; set; }

    }

}
