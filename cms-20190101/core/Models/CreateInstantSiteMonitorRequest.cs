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
        /// <para>The type of the detection point. Valid values: PC and MOBILE. PC indicates a fixed broadband detection point. MOBILE indicates a mobile detection point. Default value: PC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PC</para>
        /// </summary>
        [NameInMap("AgentGroup")]
        [Validation(Required=false)]
        public string AgentGroup { get; set; }

        /// <summary>
        /// <para>The information about the detection points. If this parameter is left empty, the system randomly selects three detection points.</para>
        /// <para>The value is a JSON array. Example: [{&quot;city&quot;:&quot;546&quot;,&quot;isp&quot;:&quot;465&quot;, &quot;type&quot;:&quot;IDC&quot;},{&quot;city&quot;:&quot;572&quot;,&quot;isp&quot;:&quot;465&quot;, &quot;type&quot;:&quot;LASTMILE&quot;},{&quot;city&quot;:&quot;738&quot;,&quot;isp&quot;:&quot;465&quot;}], which correspond to Beijing, Hangzhou, and Qingdao.</para>
        /// <para>type indicates the type of the detection point. When AgentGroup is set to PC, valid values are IDC and LASTMILE. IDC indicates a detection point deployed in a data center. LASTMILE indicates a detection point deployed in a residential area that uses a fixed broadband network. type is optional and defaults to IDC. When AgentGroup is set to MOBILE, you do not need to specify type.</para>
        /// <para>For more information about how to obtain detection point information, see <a href="https://help.aliyun.com/document_detail/115045.html">DescribeSiteMonitorISPCityList</a>.</para>
        /// <remarks>
        /// <para>You must specify either IspCities or RandomIspCity.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;city&quot;:&quot;546&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;572&quot;,&quot;isp&quot;:&quot;465&quot;},{&quot;city&quot;:&quot;738&quot;,&quot;isp&quot;:&quot;465&quot;}]</para>
        /// </summary>
        [NameInMap("IspCities")]
        [Validation(Required=false)]
        public string IspCities { get; set; }

        /// <summary>
        /// <para>The advanced extension options for the protocol type of the detection task. Different protocol types correspond to different extension options.</para>
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
        /// <item><description>You must specify either IspCities or RandomIspCity. - If you specify RandomIspCity, IspCities automatically becomes invalid.</description></item>
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
        /// <para>&lt;props=&quot;china&quot;&gt;The name must be 4 to 100 characters in length and can contain letters, digits, underscores (_), and Chinese characters.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;The name must be 4 to 100 characters in length and can contain letters, digits, and underscores (_).</para>
        /// <para>&lt;props=&quot;partner&quot;&gt;The name must be 4 to 100 characters in length and can contain letters, digits, and underscores (_).</para>
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
