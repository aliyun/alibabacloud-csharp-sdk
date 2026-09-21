// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DataAgentApplication : TeaModel {
        /// <summary>
        /// <para>The ID of the currently associated Data Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>avgwuxxxxxxxxhldt7el9</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The stable identifier of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac6izw6xxxxxxxxxxx3ulya0d</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app-name</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The extension information of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ApplicationExtraInfo")]
        [Validation(Required=false)]
        public string ApplicationExtraInfo { get; set; }

        /// <summary>
        /// <para>The name of the application creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-name</para>
        /// </summary>
        [NameInMap("CreatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// <para>The UID of the application owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30031588888885853</para>
        /// </summary>
        [NameInMap("CreatorUid")]
        [Validation(Required=false)]
        public string CreatorUid { get; set; }

        /// <summary>
        /// <para>The description of the application. The description can be up to 250 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test application</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the application was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-12T10:40:12.000+00:00</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The time when the application was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-09-12T10:40:12.000+00:00</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1673828888852166</para>
        /// </summary>
        [NameInMap("MainUid")]
        [Validation(Required=false)]
        public string MainUid { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the current or most recently associated session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>axc3lsxxxxxxxxxdapwe</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The status of the application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>REGISTERED</description></item>
        /// <item><description>DEPLOYING</description></item>
        /// <item><description>DEPLOYED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>REGISTERED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3700inkdc2y7zs0r37m5pika6</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
