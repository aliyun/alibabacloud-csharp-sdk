// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class CreateCdnSubTaskRequest : TeaModel {
        /// <summary>
        /// <para>The domain names to be tracked. Separate multiple domain names with commas (,). You can specify up to 500 domain names. If you want to specify more than 500 domain names, <a href="https://workorder-intl.console.aliyun.com/?spm=5176.2020520001.aliyun_topbar.18.dbd44bd3e4f845#/ticket/createIndex">submit a ticket</a>.</para>
        /// <remarks>
        /// <para>If you do not specify a domain name, the custom operations report is created for all domain names that belong to your Alibaba Cloud account.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example1.com,www.example2.com">www.example1.com,www.example2.com</a></para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The IDs of the metrics that you want to include in the report. Separate multiple IDs with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: frequently requested URLs (ranked by the number of requests)</description></item>
        /// <item><description><b>3</b>: frequently requested URLs (ranked by the amount of network traffic)</description></item>
        /// <item><description><b>5</b>: frequently used Referer headers (ranked by the number of requests)</description></item>
        /// <item><description><b>7</b>: frequently used Referer headers (ranked by the amount of network traffic)</description></item>
        /// <item><description><b>9</b>: frequently requested URLs that are redirected to the origin (ranked by the number of requests)</description></item>
        /// <item><description><b>11</b>: frequently requested URLs that are redirected to the origin (ranked by the amount of network traffic)</description></item>
        /// <item><description><b>13</b>: top client IP addresses (ranked by the number of requests)</description></item>
        /// <item><description><b>15</b>: top client IP addresses (ranked by the amount of network traffic)</description></item>
        /// <item><description><b>17</b>: domain names ranked by the amount of network traffic</description></item>
        /// <item><description><b>19</b>: page views and unique visitors</description></item>
        /// <item><description><b>21</b>: regions from which requests are initiated</description></item>
        /// <item><description><b>23</b>: Internet service providers (ISPs)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,3,5</para>
        /// </summary>
        [NameInMap("ReportIds")]
        [Validation(Required=false)]
        public string ReportIds { get; set; }

    }

}
