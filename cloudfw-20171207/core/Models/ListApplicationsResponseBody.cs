// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ListApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of applications. In the Chinese environment, the applications are sorted in descending order of group name and ascending order of application level.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListApplicationsResponseBodyApplications> Applications { get; set; }
        public class ListApplicationsResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>The application ID in the built-in application signature library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10012150000</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public long? ApplicationId { get; set; }

            /// <summary>
            /// <para>The application name. The name is returned in Chinese or English based on the Lang parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The application category ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            /// <summary>
            /// <para>The application category name. The name is returned in Chinese or English based on the Lang parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Office Collaboration</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The default action for the application in the built-in application library. The value is fixed as Alert (Monitor).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alert</para>
            /// </summary>
            [NameInMap("DefaultAction")]
            [Validation(Required=false)]
            public string DefaultAction { get; set; }

            /// <summary>
            /// <para>The application description. The description is returned in Chinese or English based on the Lang parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>An enterprise-grade intelligent mobile office and collaboration platform that provides features such as instant messaging, audio and video conferencing, organization management, online documents, approval and attendance, and AI office assistants</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The application group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dingtalk</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The level value of the application. The value is obtained from the built-in application signature library and used for list sorting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>700</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            /// <summary>
            /// <para>The list of protocols used by the application.</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public List<string> Protocol { get; set; }

            /// <summary>
            /// <para>The list of detection prerequisites for the application.</para>
            /// </summary>
            [NameInMap("Requirements")]
            [Validation(Required=false)]
            public List<string> Requirements { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Information</b>: Informational.</description></item>
            /// <item><description><b>Low</b>: Low.</description></item>
            /// <item><description><b>Medium</b>: Medium.</description></item>
            /// <item><description><b>High</b>: High.</description></item>
            /// <item><description><b>Critical</b>: Critical.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Low</para>
            /// </summary>
            [NameInMap("Risk")]
            [Validation(Required=false)]
            public string Risk { get; set; }

            /// <summary>
            /// <para>The technology type name. The name is returned in Chinese or English based on the Lang parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Browser-based</para>
            /// </summary>
            [NameInMap("Technology")]
            [Validation(Required=false)]
            public string Technology { get; set; }

            /// <summary>
            /// <para>The last update time of the application information. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731465600</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            /// <summary>
            /// <para>The application vendor name. The name is returned in Chinese or English based on the Lang parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk Technology Co., Ltd</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The current page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of applications that meet the filter conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
