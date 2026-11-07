// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAppRequest : TeaModel {
        /// <summary>
        /// <para>The application ID for exact query. If this parameter is omitted, applications are not filtered by application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-bp1example****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The application name filter. Contains matching is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business management</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The source type of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>USER_APP</b>: User-created applications.</description></item>
        /// <item><description><b>SYS_APP</b>: System-provided applications.</description></item>
        /// <item><description><b>VIRTUAL_APP</b>: Virtual applications.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER_APP</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>Filters by a single business type. If specified together with BizTypeList, the intersection is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Basic products.</description></item>
        /// <item><description><b>2</b>: Personal cloud.</description></item>
        /// <item><description><b>3</b>: Cloud office.</description></item>
        /// <item><description><b>4</b>: Cloud Flow.</description></item>
        /// <item><description><b>10</b>: Personal Edition.</description></item>
        /// <item><description><b>20</b>: Business Edition.</description></item>
        /// <item><description><b>60</b>: Linggou Team Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The list of business types for filtering. A match with any business type in the list is considered a match. If specified together with BizType, the single-value condition must still be met.</para>
        /// </summary>
        [NameInMap("BizTypeList")]
        [Validation(Required=false)]
        public List<int?> BizTypeList { get; set; }

        /// <summary>
        /// <para>The form of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLIENT_BASE</b>: Client applications.</description></item>
        /// <item><description><b>WEB_BASE</b>: Browser applications.</description></item>
        /// <item><description><b>CLOUD_NATIVE_BASE</b>: Cloud-native applications.</description></item>
        /// <item><description><b>PORT_SERVICE_BASE</b>: Port service applications.</description></item>
        /// <item><description><b>AGENT_SERVICE_BASE</b>: Agent applications.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WEB_BASE</para>
        /// </summary>
        [NameInMap("OriginAppType")]
        [Validation(Required=false)]
        public string OriginAppType { get; set; }

        /// <summary>
        /// <para>The type of operating system used by the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Unknown</b>: The operating system is unknown.</description></item>
        /// <item><description><b>Windows</b>: Windows operating system.</description></item>
        /// <item><description><b>Linux</b>: Linux operating system.</description></item>
        /// <item><description><b>Android</b>: Android operating system.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The page number for the query. Start from 1. If this parameter is omitted, set to 0, or set to 1, the first page is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records to return on each page. If this parameter is omitted or set to a value less than 1, the value 10 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters by a single associated product. If specified together with ProductTypeList, the intersection is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CloudGame</b>: Cloud game.</description></item>
        /// <item><description><b>CloudApp</b>: Wuying cloud application.</description></item>
        /// <item><description><b>CloudBrowser</b>: Secure browser.</description></item>
        /// <item><description><b>CloudDesktop</b>: Wuying cloud desktop.</description></item>
        /// <item><description><b>ImageBuilder</b>: Image builder resources.</description></item>
        /// <item><description><b>ImageValidate</b>: Image validation resources.</description></item>
        /// <item><description><b>AndroidCloud</b>: Android cloud.</description></item>
        /// <item><description><b>GpuRender</b>: GPU rendering.</description></item>
        /// <item><description><b>AndroidGpuRender</b>: Android cloud GPU rendering.</description></item>
        /// <item><description><b>WuyingServer</b>: Enterprise Edition workstation.</description></item>
        /// <item><description><b>GpuProxy</b>: GPU remote rendering proxy.</description></item>
        /// <item><description><b>GpuCache</b>: GPU remote rendering cache.</description></item>
        /// <item><description><b>AIAgent</b>: AI Agent service.</description></item>
        /// <item><description><b>HostedDesktop</b>: Hosted desktop.</description></item>
        /// <item><description><b>WuyingWorkstation</b>: Personal Edition container workstation.</description></item>
        /// <item><description><b>WuyingWorkstationBusiness</b>: Business Edition container workstation.</description></item>
        /// <item><description><b>WuyingWorkstationTeam</b>: Linggou Team Edition container workstation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The list of associated products for filtering. A match with any product in the list is considered a match. If specified together with ProductType, the single-value condition must still be met.</para>
        /// </summary>
        [NameInMap("ProductTypeList")]
        [Validation(Required=false)]
        public List<string> ProductTypeList { get; set; }

        /// <summary>
        /// <para>The subtype of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PWA</b>: Progressive web applications.</description></item>
        /// <item><description><b>SAAS</b>: Software as a Service (SaaS) applications.</description></item>
        /// <item><description><b>SANDBOX</b>: Sandbox applications.</description></item>
        /// <item><description><b>CONTAINER</b>: Container applications.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SAAS</para>
        /// </summary>
        [NameInMap("SubAppType")]
        [Validation(Required=false)]
        public string SubAppType { get; set; }

    }

}
