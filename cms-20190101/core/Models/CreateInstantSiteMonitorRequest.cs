// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateInstantSiteMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The URL or IP address of the detection task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The type of the detection points. Valid values: PC and MOBILE. PC indicates detection points on PCs. MOBILE indicates detection points on mobile devices. Default value: PC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PC</para>
        /// </summary>
        [NameInMap("AgentGroup")]
        [Validation(Required=false)]
        public string AgentGroup { get; set; }

        /// <summary>
        /// <para>The detection points. If you do not specify this parameter, the system randomly selects three detection points.</para>
        /// <para>The value must be a JSON array. Example: <c>[{&quot;city&quot;:&quot;546&quot;,&quot;isp&quot;:&quot;465&quot;, &quot;type&quot;:&quot;IDC&quot;},{&quot;city&quot;:&quot;572&quot;,&quot;isp&quot;:&quot;465&quot;, &quot;type&quot;:&quot;LASTMILE&quot;},{&quot;city&quot;:&quot;738&quot;,&quot;isp&quot;:&quot;465&quot;}]</c>. These values correspond to Beijing, Hangzhou, and Qingdao.</para>
        /// <para>The type parameter specifies the type of the detection point. If AgentGroup is set to PC, valid values for type are IDC and LASTMILE. IDC indicates that the detection point is deployed in a data center. LASTMILE indicates that the detection point is deployed on the PC of a netizen that is connected to the last mile of an ISP network. The type parameter is optional. The default value is IDC. You do not need to specify this parameter if AgentGroup is set to MOBILE.</para>
        /// <para>For more information about how to obtain detection points, see <a href="https://help.aliyun.com/document_detail/115045.html">DescribeSiteMonitorISPCityList</a>.</para>
        /// <remarks>
        /// <para>You must specify either <c>IspCities</c> or <c>RandomIspCity</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;city&quot;:&quot;546&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;572&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;738&quot;,&quot;isp&quot;:&quot;465&quot;}]</para>
        /// </summary>
        [NameInMap("IspCities")]
        [Validation(Required=false)]
        public string IspCities { get; set; }

        /// <summary>
        /// <para>The extended options for the protocol type of the detection task. The extended options vary based on the protocol type.</para>
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
        /// <list type="bullet">
        /// <item><description>You must specify either <c>IspCities</c> or <c>RandomIspCity</c>. If you specify <c>RandomIspCity</c>, <c>IspCities</c> is ignored.</description></item>
        /// </list>
        /// </remarks>
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
        /// <para>The name of the detection task.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The name must be 4 to 100 characters in length and can contain letters, digits, and underscores (_).</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>The name must be 4 to 100 characters in length and can contain letters, digits, and underscores (_).</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;</para>
        /// <para>The name must be 4 to 100 characters in length and can contain letters, digits, and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task1</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The type of the detection task. Valid values: HTTP, PING, TCP, UDP, and DNS.</para>
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
