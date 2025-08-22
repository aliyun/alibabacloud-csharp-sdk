// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateInstantSiteMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The URL or IP address that you want to test.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("AgentGroup")]
        [Validation(Required=false)]
        public string AgentGroup { get; set; }

        /// <summary>
        /// <para>The detection points. If you leave this parameter empty, the system randomly selects three detection points.</para>
        /// <para>The value is a <c>JSON array</c>. Example: {&quot;city&quot;:&quot;546&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;572&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;738&quot;,&quot;isp&quot;:&quot;465&quot;}. The values of the city field indicate Beijing, Hangzhou, and Qingdao.</para>
        /// <para>For information about how to obtain detection points, see <a href="https://help.aliyun.com/document_detail/115045.html">DescribeSiteMonitorISPCityList</a>.</para>
        /// <remarks>
        /// <para>You must specify one of the <c>IspCities</c> and <c>RandomIspCity</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;city&quot;:&quot;546&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;572&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;738&quot;,&quot;isp&quot;:&quot;465&quot;}]</para>
        /// </summary>
        [NameInMap("IspCities")]
        [Validation(Required=false)]
        public string IspCities { get; set; }

        /// <summary>
        /// <para>The extended options of the protocol that is used by the instant test task. The options vary based on the protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;time_out&quot;:5000}</para>
        /// </summary>
        [NameInMap("OptionsJson")]
        [Validation(Required=false)]
        public string OptionsJson { get; set; }

        /// <summary>
        /// <para>The number of detection points.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You must specify one of the <c>IspCities</c> and <c>RandomIspCity</c> parameters. If you specify the <c>RandomIspCity</c> parameter, the <c>IspCities</c> parameter automatically becomes invalid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RandomIspCity")]
        [Validation(Required=false)]
        public int? RandomIspCity { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the instant test task.</para>
        /// <para>The name must be 4 to 100 characters in length, and can contain letters, digits, and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task1</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The type of the instant test task. Valid values: HTTP, PING, TCP, UDP, and DNS.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
