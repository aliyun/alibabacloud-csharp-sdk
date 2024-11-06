// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateDcdnSubTaskRequest : TeaModel {
        /// <summary>
        /// <para>The domain names to be tracked. Separate multiple domain names with commas (,). You can specify up to 500 domain names. If you want to specify more than 500 domain names, <a href="https://workorder-intl.console.aliyun.com/?spm=5176.2020520001.aliyun_topbar.18.dbd44bd3e4f845#/ticket/createIndex">submit a ticket</a>.</para>
        /// <remarks>
        /// <para>If you do not specify a domain name, the tracking task is created for all domain names that belong to your Alibaba Cloud account.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example.com,example.org</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The IDs of the metrics that you want to include in the report. Separate multiple IDs with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2</b>: Popular URLs by Request</description></item>
        /// <item><description><b>4</b>: Popular URLs by Traffic</description></item>
        /// <item><description><b>6</b>: Popular Referer by Request</description></item>
        /// <item><description><b>8</b>: Popular Referer by Traffic</description></item>
        /// <item><description><b>10</b>: Popular Back-to-origin URLs by Request</description></item>
        /// <item><description><b>12</b>: Popular Back-to-origin URLs by Traffic</description></item>
        /// <item><description><b>14</b>: Top Client IPs by Request</description></item>
        /// <item><description><b>16</b>: Top Client IPs by Traffic</description></item>
        /// <item><description><b>18</b>: Popular Domain Names by Traffic</description></item>
        /// <item><description><b>20</b>: PV/UV</description></item>
        /// <item><description><b>22</b>: Visit Distribution by Region</description></item>
        /// <item><description><b>24</b>: Distribution of ISPs</description></item>
        /// <item><description><b>26</b>: Peak IPv4/IPv6 Bandwidth</description></item>
        /// <item><description><b>27</b>: Back-to-origin bandwidth</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2,4,6</para>
        /// </summary>
        [NameInMap("ReportIds")]
        [Validation(Required=false)]
        public string ReportIds { get; set; }

    }

}
