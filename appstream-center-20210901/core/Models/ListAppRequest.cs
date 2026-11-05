// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAppRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the application ID for exact match. If omitted, applications are not filtered by application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-bp1example****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The application name used to filter applications. Partial match is supported.</para>
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
        /// <item><description><b>USER_APP</b>: user-created application</description></item>
        /// <item><description><b>SYS_APP</b>: system-provided application</description></item>
        /// <item><description><b>VIRTUAL_APP</b>: virtual application</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER_APP</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>Filters by a single business type. If specified simultaneously with BizTypeList, the intersection is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: basic product</description></item>
        /// <item><description><b>2</b>: personal cloud</description></item>
        /// <item><description><b>3</b>: cloud office</description></item>
        /// <item><description><b>4</b>: cloud flow</description></item>
        /// <item><description><b>10</b>: personal edition</description></item>
        /// <item><description><b>20</b>: business edition</description></item>
        /// <item><description><b>60</b>: Linggou team edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The list of business types used to filter applications. An application is matched if it matches any business type in the list. If specified simultaneously with BizType, the single-value condition must still be met.</para>
        /// </summary>
        [NameInMap("BizTypeList")]
        [Validation(Required=false)]
        public List<int?> BizTypeList { get; set; }

        /// <summary>
        /// <para>The form of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CLIENT_BASE</b>: client application</description></item>
        /// <item><description><b>WEB_BASE</b>: browser application</description></item>
        /// <item><description><b>CLOUD_NATIVE_BASE</b>: cloud-native application</description></item>
        /// <item><description><b>PORT_SERVICE_BASE</b>: port service application</description></item>
        /// <item><description><b>AGENT_SERVICE_BASE</b>: agent application</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WEB_BASE</para>
        /// </summary>
        [NameInMap("OriginAppType")]
        [Validation(Required=false)]
        public string OriginAppType { get; set; }

        /// <summary>
        /// <para>The type of the operating system used by the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Unknown</b>: unknown operating system</description></item>
        /// <item><description><b>Windows</b>: Windows operating system</description></item>
        /// <item><description><b>Linux</b>: Linux operating system</description></item>
        /// <item><description><b>Android</b>: Android operating system</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The page number for the query. Query pages starting from 1. If omitted, set to 0, or set to 1, the first page is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records returned per page. If omitted or set to a value less than 1, the value is processed as 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters by a single associated product. If specified simultaneously with ProductTypeList, the intersection is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CloudGame</b>: cloud game</description></item>
        /// <item><description><b>CloudApp</b>: Wuying cloud application</description></item>
        /// <item><description><b>CloudBrowser</b>: secure browser</description></item>
        /// <item><description><b>CloudDesktop</b>: Wuying cloud computer</description></item>
        /// <item><description><b>ImageBuilder</b>: image building resource</description></item>
        /// <item><description><b>ImageValidate</b>: image validation resource</description></item>
        /// <item><description><b>AndroidCloud</b>: Android cloud</description></item>
        /// <item><description><b>GpuRender</b>: GPU rendering</description></item>
        /// <item><description><b>AndroidGpuRender</b>: Android cloud GPU rendering</description></item>
        /// <item><description><b>WuyingServer</b>: enterprise edition workstation</description></item>
        /// <item><description><b>GpuProxy</b>: GPU remote rendering proxy</description></item>
        /// <item><description><b>GpuCache</b>: GPU remote rendering cache</description></item>
        /// <item><description><b>AIAgent</b>: AI agent service</description></item>
        /// <item><description><b>HostedDesktop</b>: hosted computer</description></item>
        /// <item><description><b>WuyingWorkstation</b>: personal edition container workstation</description></item>
        /// <item><description><b>WuyingWorkstationBusiness</b>: business edition container workstation</description></item>
        /// <item><description><b>WuyingWorkstationTeam</b>: Linggou team edition container workstation</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The list of associated products used to filter applications. An application is matched if it matches any product in the list. If specified simultaneously with ProductType, the single-value condition must still be met.</para>
        /// </summary>
        [NameInMap("ProductTypeList")]
        [Validation(Required=false)]
        public List<string> ProductTypeList { get; set; }

        /// <summary>
        /// <para>The subtype of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PWA</b>: progressive web application</description></item>
        /// <item><description><b>SAAS</b>: software as a service (SaaS) application</description></item>
        /// <item><description><b>SANDBOX</b>: sandbox application</description></item>
        /// <item><description><b>CONTAINER</b>: container application</description></item>
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
